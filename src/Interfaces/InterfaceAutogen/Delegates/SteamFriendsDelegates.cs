using System;
using System.Runtime.InteropServices;

// Autogenerated @ 10/06/18
namespace InterfaceFriends
{
    /// <summary>
    /// Exports the delegates for all interfaces that implement SteamFriends
    /// </summary>
    [ArgonCore.Interface.Delegate(Name = "SteamFriends")]
    class SteamFriends_Delegates
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetPersonaNameDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetPersonaStateDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetPersonaStateDelegate(IntPtr _, uint state);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool AddFriendDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool RemoveFriendDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool HasFriendDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetFriendRelationshipDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetFriendPersonaStateDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool Deprecated_GetFriendGamePlayedDelegate(IntPtr _, ulong steam_id, ref System.UInt32 app_id, ref System.UInt32 game_ip, ref System.UInt32 game_port);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetFriendPersonaNameDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int AddFriendByNameDelegate(IntPtr _, string name);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendCountDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ulong GetFriendByIndexDelegate(IntPtr _, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SendMsgToFriendDelegate(IntPtr _, ulong dest_steam_id, uint msg_type, string message_body);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetFriendRegValueDelegate(IntPtr _, ulong steam_id, string key, string value);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetFriendRegValueDelegate(IntPtr _, ulong steam_id, string key);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetFriendPersonaNameHistoryDelegate(IntPtr _, ulong steam_id, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetChatMessageDelegate(IntPtr _, ulong steam_id, int msg_index, IntPtr msg_out, int max_msg, ref System.UInt32 msg_type);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetChatIDOfChatHistoryStartDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetChatHistoryStartDelegate(IntPtr _, ulong steam_id, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ClearChatHistoryDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int InviteFriendByEmailDelegate(IntPtr _, string email);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetBlockedFriendCountDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetFriendGamePlayedDelegate(IntPtr _, ulong steam_id, ref System.UInt64 game_id, ref System.UInt32 server_ip, ref System.UInt16 server_port);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetFriendGamePlayed2Delegate(IntPtr _, ulong steam_id, ref System.UInt64 game_id, ref System.UInt32 server_ip, ref System.UInt16 server_port);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int SetPersonaNameDelegate(IntPtr _, string name);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendSteamLevelDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetPlayerNicknameDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendsGroupCountDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate System.UInt16 GetGroupIdByIndexDelegate(IntPtr _, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetFriendsGroupNameDelegate(IntPtr _, System.UInt16 id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendsGroupMembersCountDelegate(IntPtr _, System.UInt16 id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void GetFriendsGroupMembersListDelegate(IntPtr _, System.UInt16 id, ref System.IntPtr steam_id_out, int max_steam_id_out);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetClanCountDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ulong GetClanByIndexDelegate(IntPtr _, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetClanNameDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetClanTagDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetClanActivityCountsDelegate(IntPtr _, ulong steam_id, ref System.Int32 online, ref System.Int32 in_game, ref System.Int32 chatting);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DownloadClanActivityCountsDelegate(IntPtr _, System.UInt64[] clans, int count);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendCountFromSourceDelegate(IntPtr _, ulong source_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ulong GetFriendFromSourceByIndexDelegate(IntPtr _, ulong source_id, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsUserInSourceDelegate(IntPtr _, ulong steam_id, ulong source_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetInGameVoiceSpeakingDelegate(IntPtr _, ulong steam_id, bool speaking);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ActivateGameOverlayDelegate(IntPtr _, string dialog);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ActiveGameOverlayToUserDelegate(IntPtr _, string dialog, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ActiveGameOverlayToWebPageDelegate(IntPtr _, string url);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ActivateGameOverlayToStoreDelegate(IntPtr _, uint app_id, uint flag);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetPlayedWithDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetSmallFriendAvatarDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetMediumFriendAvatarDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetLargeFriendAvatarDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool RequestUserInformationDelegate(IntPtr _, ulong steam_id, bool require_name_only);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int RequestClanOfficerListDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ulong GetClanOwnerDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetClanOfficerCountDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool SetRichPresenceDelegate(IntPtr _, string key, string value);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool ClearRichPresenceDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetFriendRichPresenceDelegate(IntPtr _, ulong steam_id, string key);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendRichPresenceKeyCountDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetFriendRichPresenceKeyByIndexDelegate(IntPtr _, ulong steam_id, int key);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void RequestFriendRichPresenceDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool InviteUserToGameDelegate(IntPtr _, ulong steam_id, string connect);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetCoplayFriendCountDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ulong GetCoplayFriendDelegate(IntPtr _, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendCoplayTimeDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetFriendCoplayGameDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int JoinClanChatRoomDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool LeaveClanChatRoomDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetClanChatMemberCountDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ulong GetChatMemberByIndexDelegate(IntPtr _, ulong steam_id, int index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool SendClanChatMessageDelegate(IntPtr _, ulong steam_id, string msg);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetClanChatMessageDelegate(IntPtr _, ulong steam_id, int index, IntPtr text_out, int max_text, uint chat_type, ref System.UInt64 chater_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsClanChatAdminDelegate(IntPtr _, ulong chat_id, ulong user_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsClanChatWindowOpenInSteamDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool OpenClanChatWindowInSteamDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool CloseClanChatWindowInSteamDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool SetListenForFriendsMessagesDelegate(IntPtr _, bool intercept);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool ReplyToFriendMessageDelegate(IntPtr _, ulong steam_id, string msg);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFriendMessageDelegate(IntPtr _, ulong steam_id, int id, IntPtr data_out, int max_data_out, uint chat_type);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetFollowerCountDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int IsFollowingDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int EnumerateFollowingListDelegate(IntPtr _, uint starting_index);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsClanPublicDelegate(IntPtr _, ulong steam_id);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsClanOfficialGameGroupDelegate(IntPtr _, ulong steam_id);
    }
}
