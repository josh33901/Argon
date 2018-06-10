using System;

// Autogenerated @ 10/06/18
namespace InterfaceFriends
{
    /// <summary>
    /// Implements the map for interface SteamFriends001
    /// </summary>
    [ArgonCore.Interface.Map(Name = "SteamFriends001", Implements = "SteamFriends")]
    public class SteamFriends001_Map : ArgonCore.Interface.IBaseInterfaceMap
    {
        public string GetPersonaName(IntPtr _)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetPersonaName",
               Args = new object[] {},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<string>(PipeId, f);
        }
        public uint GetPersonaState(IntPtr _)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetPersonaState",
               Args = new object[] {},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<uint>(PipeId, f);
        }
        public void SetPersonaState(IntPtr _, uint state)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "SetPersonaState",
               Args = new object[] {state},
            };
            ArgonCore.IPC.ClientPipe.CallSerializedFunction(PipeId, f);
        }
        public bool AddFriend(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "AddFriend",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
        public bool RemoveFriend(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "RemoveFriend",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
        public bool HasFriend(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "HasFriend",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
        public uint GetFriendRelationship(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendRelationship",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<uint>(PipeId, f);
        }
        public uint GetFriendPersonaState(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendPersonaState",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<uint>(PipeId, f);
        }
        public bool Deprecated_GetFriendGamePlayed(IntPtr _, ulong steam_id, ref System.UInt32 app_id, ref System.UInt32 game_ip, ref System.UInt32 game_port)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "Deprecated_GetFriendGamePlayed",
               Args = new object[] {steam_id, app_id, game_ip, game_port},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
        public string GetFriendPersonaName(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendPersonaName",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<string>(PipeId, f);
        }
        public int AddFriendByName(IntPtr _, string name)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "AddFriendByName",
               Args = new object[] {name},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<int>(PipeId, f);
        }
        public int GetFriendCount(IntPtr _)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendCount",
               Args = new object[] {},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<int>(PipeId, f);
        }
        public ulong GetFriendByIndex(IntPtr _, int index)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendByIndex",
               Args = new object[] {index},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<ulong>(PipeId, f);
        }
        public void SendMsgToFriend(IntPtr _, ulong dest_steam_id, uint msg_type, string message_body)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "SendMsgToFriend",
               Args = new object[] {dest_steam_id, msg_type, message_body},
            };
            ArgonCore.IPC.ClientPipe.CallSerializedFunction(PipeId, f);
        }
        public void SetFriendRegValue(IntPtr _, ulong steam_id, string key, string value)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "SetFriendRegValue",
               Args = new object[] {steam_id, key, value},
            };
            ArgonCore.IPC.ClientPipe.CallSerializedFunction(PipeId, f);
        }
        public string GetFriendRegValue(IntPtr _, ulong steam_id, string key)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendRegValue",
               Args = new object[] {steam_id, key},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<string>(PipeId, f);
        }
        public string GetFriendPersonaNameHistory(IntPtr _, ulong steam_id, int index)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendPersonaNameHistory",
               Args = new object[] {steam_id, index},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<string>(PipeId, f);
        }
        public int GetChatMessage(IntPtr _, ulong steam_id, int msg_index, IntPtr msg_out, int max_msg, ref System.UInt32 msg_type)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetChatMessage",
               Args = new object[] {steam_id, msg_index, msg_out, max_msg, msg_type},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<int>(PipeId, f);
        }
        public bool SendMsgToFriend(IntPtr _, ulong steam_id, uint type, string message, int length)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "SendMsgToFriend",
               Args = new object[] {steam_id, type, message, length},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
        public int GetChatIDOfChatHistoryStart(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetChatIDOfChatHistoryStart",
               Args = new object[] {steam_id},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<int>(PipeId, f);
        }
        public void SetChatHistoryStart(IntPtr _, ulong steam_id, int index)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "SetChatHistoryStart",
               Args = new object[] {steam_id, index},
            };
            ArgonCore.IPC.ClientPipe.CallSerializedFunction(PipeId, f);
        }
        public void ClearChatHistory(IntPtr _, ulong steam_id)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "ClearChatHistory",
               Args = new object[] {steam_id},
            };
            ArgonCore.IPC.ClientPipe.CallSerializedFunction(PipeId, f);
        }
        public int InviteFriendByEmail(IntPtr _, string email)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "InviteFriendByEmail",
               Args = new object[] {email},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<int>(PipeId, f);
        }
        public int GetBlockedFriendCount(IntPtr _)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetBlockedFriendCount",
               Args = new object[] {},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<int>(PipeId, f);
        }
        public bool GetFriendGamePlayed(IntPtr _, ulong steam_id, ref System.UInt64 game_id, ref System.UInt32 server_ip, ref System.UInt16 server_port)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendGamePlayed",
               Args = new object[] {steam_id, game_id, server_ip, server_port},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
        public bool GetFriendGamePlayed2(IntPtr _, ulong steam_id, ref System.UInt64 game_id, ref System.UInt32 server_ip, ref System.UInt16 server_port)
        {
            var f = new ArgonCore.IPC.SerializedFunction
            {
               ClientId = ClientId,
               InterfaceId = InterfaceId,
               Name = "GetFriendGamePlayed2",
               Args = new object[] {steam_id, game_id, server_ip, server_port},
            };
            return ArgonCore.IPC.ClientPipe.CallSerializedFunction<bool>(PipeId, f);
        }
    }
}
