﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using NamedPipeWrapper;

using ArgonCore.Client;

namespace InterfaceClient
{
    [ArgonCore.Interface.Impl(Name = "SteamClient017", Implements = "SteamClient", ServerMapped = false)]
    public class SteamClient017 : ArgonCore.Interface.IBaseInterface
    {
        public uint CreateSteamPipe(IntPtr _)
        {
            // In our implementation, the pipe handle is essentially irrelevent
            Console.WriteLine("CreateSteamPipe");
            return 1;
        }

        public bool ReleaseSteamPipe(IntPtr _, uint pipe)
        {
            Console.WriteLine("ReleaseSteamPipe");
            return true;
        }

        // TODO: Deal with global users
        public uint ConnectToGlobalUser(IntPtr _, uint pipe)
        {
            Console.WriteLine("ConnectToGlobalUser");
            return 1;
        }

        public uint CreateLocalUser(IntPtr _, ref uint user, uint account_type)
        {
            Console.WriteLine("CreateLocalUser {0} {1}", user, account_type);

            user = Client.CreateNewClient();

            return user;
        }

        public void ReleaseUser(IntPtr _, uint user, uint pipe)
        {
            // TODO: remove users
            Console.WriteLine("ReleaseUser");
            return;
        }

        IntPtr CreateInterface(uint user, string version)
        {
            try
            {
                return Client.ActiveClients[user].CreateInterface(version);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in CreateInterface \"{0}\"", e.Message);
                return IntPtr.Zero;
            }
        }

        public IntPtr GetSteamUser(IntPtr _, uint user, uint pipe, string version)
        {
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamGameServer(IntPtr _, uint user, uint pipe, string version)
        {
            return CreateInterface(user, version);
        }

        public void SetLocalIPBinding(IntPtr _, uint ip, uint port)
        {
            Console.WriteLine("SetLocalIPBinding");
            return;
        }

        public IntPtr GetSteamFriends(IntPtr _, uint user, uint pipe, string version)
        {
            Console.WriteLine("GetSteamFriends");
            return IntPtr.Zero;
        }

        public IntPtr GetSteamUtils(IntPtr _, uint pipe, string version)
        {
            Console.WriteLine("GetSteamUtils");
            return Client.CreateInterfaceNoUser(version);
        }

        public IntPtr GetSteamMatchmaking(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamMatchmaking");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamMatchmakingServers(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamMatchmakingServers");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamGenericInterface(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamGenericInterface");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamUserStats(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamUserStats");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamGameServerStats(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamGameServerStats");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamApps(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamApps");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamNetworking(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamNetworking");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamRemoteStorage(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamRemoteStorage");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamScreenshots(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamScreenshots");
            return CreateInterface(user, version);
        }

        public void RunFrame(IntPtr _)
        {
            // Pipes automatically run ipc threads so...
            // TODO: is this type of behaviour allowed or do applications EXPECT
            // Callbacks to happen when runframe is called
            Console.WriteLine("RunFrame");
        }

        public uint GetIPCCallCount(IntPtr _)
        {
            // TODO: actually keep track of these in the future
            Console.WriteLine("GetIPCCallCount");
            return 1;
        }

        public void SetWarningMessageHook(IntPtr _, IntPtr function)
        {
            Console.WriteLine("SetWarningMessageHook");
            return;
        }

        public bool ShutdownIfAllPipesClosed(IntPtr _)
        {
            // TODO: what does this actually do?
            Console.WriteLine("ShutdownIfAllPipesClosed");
            return false;
        }

        public IntPtr GetSteamHTTP(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamHTTP");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamUnifiedMessages(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamUnifiedMessages");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamController(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamController");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamUGC(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamUGC");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamAppList(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamAppList");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamMusic(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamMusic");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamMusicRemote(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamMusicRemote");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamHTMLSurface(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamHTMLSurface");
            return CreateInterface(user, version);
        }

        public void Set_SteamAPI_CPostAPIResultInProcess(IntPtr _, IntPtr function)
        {
            Console.WriteLine("Set_SteamAPI_CPostAPIResultInProcess");
        }

        public void Remove_SteamAPI_CPostAPIResultInProcess(IntPtr _, IntPtr function)
        {
            Console.WriteLine("Remove_SteamAPI_CPostAPIResultInProcess");
        }

        public void Set_SteamAPI_CCheckCallbackRegisteredInProcess(IntPtr _, IntPtr function)
        {
            Console.WriteLine("Set_SteamAPI_CCheckCallbackRegisteredInProcess");
        }

        public IntPtr GetSteamInventory(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamInventory");
            return CreateInterface(user, version);
        }

        public IntPtr GetSteamVideo(IntPtr _, uint user, IntPtr pipe, string version)
        {
            Console.WriteLine("GetSteamVideo");
            return CreateInterface(user, version);
        }
    }
}
