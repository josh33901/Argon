using System;

// Autogenerated @ 21/08/18
namespace InterfaceFriends
{
    /// <summary>
    /// Implements the map for interface SteamFriends001
    /// </summary>
    [Core.Interface.Map(Name = "SteamFriends001")]
    public class SteamFriends001_Map : Core.Interface.IBaseInterfaceMap
    {
        public string GetPersonaName(IntPtr _)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetPersonaName",
                Args = new object[] {},

            });



            return (string)result.Result;
        }
        public uint GetPersonaState(IntPtr _)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetPersonaState",
                Args = new object[] {},

            });



            return (uint)result.Result;
        }
        public void SetPersonaState(IntPtr _, uint state)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "SetPersonaState",
                Args = new object[] {state},

            });



        }
        public bool AddFriend(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "AddFriend",
                Args = new object[] {steam_id},

            });



            return (bool)result.Result;
        }
        public bool RemoveFriend(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "RemoveFriend",
                Args = new object[] {steam_id},

            });



            return (bool)result.Result;
        }
        public bool HasFriend(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "HasFriend",
                Args = new object[] {steam_id},

            });



            return (bool)result.Result;
        }
        public uint GetFriendRelationship(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendRelationship",
                Args = new object[] {steam_id},

            });



            return (uint)result.Result;
        }
        public uint GetFriendPersonaState(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendPersonaState",
                Args = new object[] {steam_id},

            });



            return (uint)result.Result;
        }
        public bool Deprecated_GetFriendGamePlayed(IntPtr _, ulong steam_id, ref uint app_id, ref uint game_ip, ref uint game_port)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "Deprecated_GetFriendGamePlayed",
                Args = new object[] {steam_id, app_id, game_ip, game_port},

            });

            app_id = (uint)result.Args[1];
            game_ip = (uint)result.Args[2];
            game_port = (uint)result.Args[3];


            return (bool)result.Result;
        }
        public string GetFriendPersonaName(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendPersonaName",
                Args = new object[] {steam_id},

            });



            return (string)result.Result;
        }
        public int AddFriendByName(IntPtr _, string name)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "AddFriendByName",
                Args = new object[] {name},

            });



            return (int)result.Result;
        }
        public int GetFriendCount(IntPtr _)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendCount",
                Args = new object[] {},

            });



            return (int)result.Result;
        }
        public ulong GetFriendByIndex(IntPtr _, int index)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendByIndex",
                Args = new object[] {index},

            });



            return (ulong)result.Result;
        }
        public void SendMsgToFriend(IntPtr _, ulong dest_steam_id, uint msg_type, string message_body)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "SendMsgToFriend",
                Args = new object[] {dest_steam_id, msg_type, message_body},

            });



        }
        public void SetFriendRegValue(IntPtr _, ulong steam_id, string key, string value)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "SetFriendRegValue",
                Args = new object[] {steam_id, key, value},

            });



        }
        public string GetFriendRegValue(IntPtr _, ulong steam_id, string key)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendRegValue",
                Args = new object[] {steam_id, key},

            });



            return (string)result.Result;
        }
        public string GetFriendPersonaNameHistory(IntPtr _, ulong steam_id, int index)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendPersonaNameHistory",
                Args = new object[] {steam_id, index},

            });



            return (string)result.Result;
        }
        public int GetChatMessage(IntPtr _, ulong steam_id, int msg_index, IntPtr b_pointer, int b_length, ref uint msg_type)
        {
            var b = new Core.Util.Buffer();
            b.ReadFromPointer(b_pointer, b_length);


            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetChatMessage",
                Args = new object[] {steam_id, msg_index, b, msg_type},

            });

            b = (Core.Util.Buffer)result.Args[2];
            msg_type = (uint)result.Args[3];

            b.WriteToPointer(b_pointer, b_length);

            return (int)result.Result;
        }
        public bool SendMsgToFriend2(IntPtr _, ulong steam_id, uint type, string message, int length)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "SendMsgToFriend2",
                Args = new object[] {steam_id, type, message, length},

            });



            return (bool)result.Result;
        }
        public int GetChatIDOfChatHistoryStart(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetChatIDOfChatHistoryStart",
                Args = new object[] {steam_id},

            });



            return (int)result.Result;
        }
        public void SetChatHistoryStart(IntPtr _, ulong steam_id, int index)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "SetChatHistoryStart",
                Args = new object[] {steam_id, index},

            });



        }
        public void ClearChatHistory(IntPtr _, ulong steam_id)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "ClearChatHistory",
                Args = new object[] {steam_id},

            });



        }
        public int InviteFriendByEmail(IntPtr _, string email)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "InviteFriendByEmail",
                Args = new object[] {email},

            });



            return (int)result.Result;
        }
        public int GetBlockedFriendCount(IntPtr _)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetBlockedFriendCount",
                Args = new object[] {},

            });



            return (int)result.Result;
        }
        public bool GetFriendGamePlayed(IntPtr _, ulong steam_id, ref ulong game_id, ref uint server_ip, ref short server_port)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendGamePlayed",
                Args = new object[] {steam_id, game_id, server_ip, server_port},

            });

            game_id = (ulong)result.Args[1];
            server_ip = (uint)result.Args[2];
            server_port = (short)result.Args[3];


            return (bool)result.Result;
        }
        public bool GetFriendGamePlayed2(IntPtr _, ulong steam_id, ref ulong game_id, ref uint server_ip, ref short server_port)
        {

            var result = Client.ClientPipe.CallSerializedFunction(PipeId, new Core.IPC.SerializedFunction()
            {
                ClientId = ClientId,
                InterfaceId = InterfaceId,
                Name = "GetFriendGamePlayed2",
                Args = new object[] {steam_id, game_id, server_ip, server_port},

            });

            game_id = (ulong)result.Args[1];
            server_ip = (uint)result.Args[2];
            server_port = (short)result.Args[3];


            return (bool)result.Result;
        }
    }
}
