using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;

using Server;
using Core.Extensions;

using SteamKit2;
using SteamKit2.Internal;

namespace InterfaceUser
{
    public class User : ClientTied<User>
    {
        private static Dictionary<int, User> ActiveUsers { get; set; } = new Dictionary<int, User>();

        public enum LogonState
        {
            LoggedOff,
            LoggingOn,
            LoggingOff,
            LoggedOn,
        }

        SteamUser steam_user;
        SteamApps steam_apps;
        public EAccountFlags AccountFlags { get; private set; }
        public IPAddress public_ip;

        public override void Init()
        {
            steam_user = Instance.SteamClient.GetHandler<SteamUser>();
            steam_apps = Instance.SteamClient.GetHandler<SteamApps>();

            Instance.CallbackManager.Subscribe<SteamUser.LoggedOnCallback>(cb => OnLoggedOn(cb));
            Instance.CallbackManager.Subscribe<SteamUser.LoggedOffCallback>(cb => OnLoggedOff(cb));
            Instance.CallbackManager.Subscribe<SteamUser.UpdateMachineAuthCallback>(cb => OnMachineAuth(cb));
            Instance.CallbackManager.Subscribe<SteamApps.AppOwnershipTicketCallback>(cb => OnAppOwnershipTicketCallback(cb));
            Instance.CallbackManager.Subscribe<SteamApps.GameConnectTokensCallback>(cb => OnGameConnectTokens(cb));
            Instance.CallbackManager.Subscribe<SteamUser.LoginKeyCallback>(cb => OnLoginKeyCallback(cb));
        }

        LogonState logon_state;

        public LogonState GetLogonState()
        {
            return logon_state;
        }

        public bool Connected()
        {
            return Instance.Connected;
        }

        public int GetHandle()
        {
            return ClientId;
        }

        public ulong SteamId { get { return steam_user.SteamID.ConvertToUInt64(); } }
        public ulong InstanceId { get { return steam_user.SteamID.AccountInstance; } }

        public enum LogonNeeds
        {
            SteamGuard,
            TwoFactor,
            None,
        }

        LogonNeeds logon_needs;

        string email;
        string username;
        string password;
        string two_factor_code;
        string steam_guard_code;

        void OnMachineAuth(SteamUser.UpdateMachineAuthCallback cb)
        {
            Log.WriteLine("Updating sentryfile...");

            string sentry_name = String.Format("sentry_{0}.bin", username);

            int fileSize;
            byte[] sentryHash;
            using (var fs = File.Open(sentry_name, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(cb.Offset, SeekOrigin.Begin);
                fs.Write(cb.Data, 0, cb.BytesToWrite);
                fileSize = (int)fs.Length;

                fs.Seek(0, SeekOrigin.Begin);
                using (var sha = SHA1.Create())
                {
                    sentryHash = sha.ComputeHash(fs);
                }
            }

            // inform the steam servers that we're accepting this sentry file
            steam_user.SendMachineAuthResponse(new SteamUser.MachineAuthDetails
            {
                JobID = cb.JobID,

                FileName = cb.FileName,

                BytesWritten = cb.BytesToWrite,
                FileSize = fileSize,
                Offset = cb.Offset,

                Result = EResult.OK,
                LastError = 0,

                OneTimePassword = cb.OneTimePassword,

                SentryFileHash = sentryHash,
            });

            Log.WriteLine("Finished writing SentryFile...");
        }

        void OnAccountLogonDenied(SteamUser.LoggedOnCallback cb)
        {
            logon_state = LogonState.LoggedOff;

            Log.WriteLine("OnAccountLogonDenied: {0}", cb.Result.ExtendedString());

            switch (cb.Result)
            {
                case EResult.AccountLoginDeniedNeedTwoFactor:
                    {
                        Log.WriteLine("Needs twofactor code...");
                        logon_needs = LogonNeeds.TwoFactor;
                        break;
                    }
                case EResult.AccountLogonDenied:
                    {
                        Log.WriteLine("Needs steamguard code...");
                        logon_needs = LogonNeeds.SteamGuard;
                        break;
                    }
            }

            var b = new Core.Util.Buffer();
            b.SetAlignment(4);

            b.Write((uint)cb.Result);
            b.WriteBool(false);

            Instance.PostCallback(102, b);
        }
        void OnAccountLogonSuccess(SteamUser.LoggedOnCallback cb)
        {
            logon_state = LogonState.LoggedOn;
            logon_needs = LogonNeeds.None;

            Log.WriteLine("Logon succeeded!");

            AccountFlags = cb.AccountFlags;
            public_ip = cb.PublicIP;

            Instance.PostCallback(101, new Core.Util.Buffer());

            // Tell steam that we are running the `nEw Ui`
            Instance.SteamClient.Send(new ClientMsgProtobuf<CMsgClientUIMode>(EMsg.ClientCurrentUIMode) { Body = { chat_mode = 2 } });

            GetAppOwnershipTicketAsync(7);
        }

        void OnLoggedOn(SteamUser.LoggedOnCallback cb)
        {
            switch (cb.Result)
            {
                case EResult.AccountLogonDenied:
                case EResult.AccountLoginDeniedNeedTwoFactor:
                case EResult.InvalidPassword:
                    {
                        OnAccountLogonDenied(cb);
                        return;
                    }
                case EResult.OK:
                    {
                        OnAccountLogonSuccess(cb);
                        return;
                    }

                default:
                    {
                        Log.WriteLine("Unable to logon to Steam: {0}", cb.Result.ExtendedString());
                        return;
                    }
            }
        }

        void OnLoggedOff(SteamUser.LoggedOffCallback cb)
        {
            Log.WriteLine("Logged off...");
        }

        public void LogonInternal()
        {
            // TODO: wait for connect!
            if (Connected() == false) Instance.Connect();

            string sentry_name = string.Format("sentry_{0}.bin", username);

            byte[] sentry_hash = null;
            if (File.Exists(sentry_name))
            {
                // if we have a saved sentry file, read and sha-1 hash it
                byte[] sentry_file = File.ReadAllBytes(sentry_name);
                sentry_hash = CryptoHelper.SHAHash(sentry_file);
            }

            steam_user.LogOn(new SteamUser.LogOnDetails
            {
                Username = username,
                Password = password,

                // this value will be null (which is the default) for our first logon attempt
                AuthCode = steam_guard_code,

                // this will also be null on our first logon attempt
                TwoFactorCode = two_factor_code,

                // our subsequent logons use the hash of the sentry file as proof of ownership of the file
                // this will also be null for our first (no authcode) and second (authcode only) logon attempts
                SentryFileHash = sentry_hash,
            });
        }

        public void SetLogonInformation(string new_username, string new_password)
        {
            username = new_username;
            password = new_password;
        }

        public void ClearLogonInformation()
        {
            username = "";
            password = "";
            two_factor_code = "";
            logon_needs = LogonNeeds.None;
        }

        public void LogOnUsernamePassword(string new_username, string new_password)
        {
            logon_needs = LogonNeeds.None;
            SetLogonInformation(new_username, new_password);

            LogonInternal();
        }

        public void SetTwoFactor(string code)
        {
            if (logon_needs == LogonNeeds.TwoFactor)
            {
                // Steam authenticator
                two_factor_code = code;
            }
            else if (logon_needs == LogonNeeds.SteamGuard)
            {
                // Steam guard
                steam_guard_code = code;
            }
            else
            {
                Log.WriteLine("SetTwoFactor called but nothing needed!");
            }
        }

        void OnLoginKeyCallback(SteamUser.LoginKeyCallback cb)
        {
            var login_key_ack = new ClientMsgProtobuf<CMsgClientNewLoginKeyAccepted>(EMsg.ClientNewLoginKeyAccepted);
            login_key_ack.Body.unique_id = cb.UniqueID;

            Instance.SteamClient.Send(login_key_ack);
        }

        public int GetAppIdForPipe(int pipe_id)
        {
            if (Server.Client.PipeAppId.TryGetValue(pipe_id, out var app_id))
            {
                return app_id;
            }

            return 0;
        }

        // Per user store of all the apptickets collected
        private Dictionary<uint, byte[]> ownership_ticket_store = new Dictionary<uint, byte[]>();
        void OnAppOwnershipTicketCallback(SteamApps.AppOwnershipTicketCallback cb)
        {
            switch (cb.Result)
            {
                case EResult.OK:
                    {
                        Log.WriteLine("Got app ticket for {0} successfully", cb.AppID);
                        ownership_ticket_store[cb.AppID] = cb.Ticket;
                        return;
                    }
                default:
                    {
                        Log.WriteLine("GetAppOwnershipTicket for appid {0} failed {1}", cb.AppID, cb.Result.ExtendedString());
                        return;
                    }
            }
        }

        public byte[] GetAppOwnershipTicket(uint app_id)
        {
            if (ownership_ticket_store.TryGetValue(app_id, out var result))
            {
                return result;
            }
            else
            {
                Log.WriteLine("Waiting for app ownership ticket...");

                // Request an app ownership ticket from steam
                var job = steam_apps.GetAppOwnershipTicket(app_id);

                // Get the now stored ticket
                return ownership_ticket_store[app_id];
            }
        }

        public byte[] GetAppOwnershipTicketAsync(uint app_id)
        {
            if (ownership_ticket_store.TryGetValue(app_id, out var result))
            {
                return result;
            }
            else
            {
                // Request an app ownership ticket from steam
                var job = steam_apps.GetAppOwnershipTicket(app_id);

                return null;
            }
        }

        public List<byte[]> game_connect_tokens = new List<byte[]>();
        public void OnGameConnectTokens(SteamApps.GameConnectTokensCallback cb)
        {
            Log.WriteLine("OnGameConnectTokens");
            game_connect_tokens.AddRange(cb.Tokens);

            while (game_connect_tokens.Count > cb.TokensToKeep)
                game_connect_tokens.RemoveAt(0);
        }

        public int RemainingGameConnectTokens()
        {
            return game_connect_tokens.Count;
        }

        public byte[] GetGameConnectToken()
        {
            var token = game_connect_tokens[0];
            game_connect_tokens.RemoveAt(0);
            return token;
        }

        public void WriteGameConnectTokenToStream(StreamWriter s)
        {
            s.Write(GetGameConnectToken());
        }

        // TODO: this is part of the old client authentication api and as such shouldnt really be called anymore...
        public byte[] InitiateGameConnection(int max_buffer, SteamID game_server_id, GameID game_id, uint server_ip, ushort server_port, bool secure)
        {
            Log.WriteLine("InitiateGameConnection should no longer be called...");

            if (!game_server_id.IsValid)
            {
                Log.WriteLine("Invalid game server steam id passed to InitiateGameConnection");
                return null;
            }

            // TODO: check whether server port / ip are valid

            var b = new Core.Util.Buffer();

            // TODO: write a real game connect token in here
            if (game_connect_tokens.Count > 0)
            {
                var token = GetGameConnectToken();
                b.Write(token.Length);
                b.Write(token);
            }
            else
            {
                // Write out the placeholder token
                b.Write(4u);
                b.Write(0u);
            }

            var ownership_ticket = GetAppOwnershipTicket(game_id.AppID);

            b.Write(ownership_ticket.Length);
            b.Write(ownership_ticket);

            // TODO: look at InternalUpdateClientGame and see whether there is anything else important
            // That needs to go here

            return b.GetBuffer();
        }

        List<AuthTicket> auth_ticket_store = new List<AuthTicket>();
        public AuthTicket GetAuthTicket(int handle)
        {
            return auth_ticket_store[handle - 1];
        }

        public uint ticket_request_count = 0;
        public uint auth_sequence = 0;
        public int GetAuthSessionTicket(int app_id, int pipe)
        {
            Log.WriteLine("GetAuthSessionTicket for app_id {0}", app_id);
            var ownership_ticket = GetAppOwnershipTicket((uint)app_id);

            var client_ticket_buffer = new Core.Util.Buffer();

            // Write the token into the ticket
            var token = GetGameConnectToken();
            client_ticket_buffer.Write(token.Length);
            client_ticket_buffer.Write(token);

            // Size of header
            client_ticket_buffer.Write(0x18);

            // This is all copied from what the steamclient method does
            client_ticket_buffer.Write(1);
            client_ticket_buffer.Write(2);

            var ip_bytes = public_ip.GetAddressBytes();
            Array.Reverse(ip_bytes);
            client_ticket_buffer.Write(ip_bytes);

            client_ticket_buffer.Write(Instance.SteamClient.LocalIP.GetAddressBytes());
            client_ticket_buffer.Write(Core.Platform.MilisecondTime());
            client_ticket_buffer.Write(++ticket_request_count);

            var client_ticket_crc = BitConverter.ToUInt32(CryptoHelper.CRCHash(client_ticket_buffer.GetBuffer()), 0);

            auth_ticket_store.Add(new AuthTicket()
            {
                app_id = app_id,
                pipe_id = pipe,
                crc32 = client_ticket_crc,
                handle = auth_ticket_store.Count + 1,
                ticket = client_ticket_buffer.GetBuffer(),
                cancelled = false,
            });

            // Resend the auth list with our new ticket
            SendClientAuthList();


            // Create the ticket that will actually be sent to the server

            var server_ticket_buffer = new Core.Util.Buffer();

            var size = 8 + client_ticket_buffer.GetBuffer().Length + 4 + ownership_ticket.Length;

            server_ticket_buffer.Write((ushort)size);

            server_ticket_buffer.Write(steam_user.SteamID.ConvertToUInt64());

            server_ticket_buffer.Write(client_ticket_buffer.GetBuffer());

            // Write the ownership ticket data in here
            // We are just going to assume that our tickets are 100% correct...
            server_ticket_buffer.Write(ownership_ticket.Length);
            server_ticket_buffer.Write(ownership_ticket);

            var server_ticket_crc = BitConverter.ToUInt32(CryptoHelper.CRCHash(server_ticket_buffer.GetBuffer()), 0);

            auth_ticket_store.Add(new AuthTicket()
            {
                is_server_ticket = true,
                app_id = app_id,
                pipe_id = pipe,
                crc32 = server_ticket_crc,
                handle = auth_ticket_store.Count + 1,
                ticket = server_ticket_buffer.GetBuffer(),
                cancelled = false,
            });

            return auth_ticket_store.Count;
        }

        public void SendClientAuthList()
        {
            var auth_list_msg = new ClientMsgProtobuf<CMsgClientAuthList>(EMsg.ClientAuthList);

            // Add all our non-cancelled tickets to this auth list
            foreach (var ticket in auth_ticket_store)
            {
                if (ticket.cancelled || ticket.is_server_ticket) continue;

                auth_list_msg.Body.tickets.Add(new CMsgAuthTicket()
                {
                    gameid = (uint)ticket.app_id,
                    h_steam_pipe = (uint)ticket.pipe_id,
                    ticket_crc = ticket.crc32,
                });

                auth_list_msg.Body.app_ids.Add((uint)ticket.app_id);
            }

            // Update the authlist and send it to the server

            auth_list_msg.Body.tokens_left = (uint)game_connect_tokens.Count;
            auth_list_msg.Body.message_sequence = ++auth_sequence;

            Instance.SteamClient.Send(auth_list_msg);

            // TODO: register for ClientAuthListAck!
        }
    }
}