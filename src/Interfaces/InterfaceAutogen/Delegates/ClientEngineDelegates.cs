using System;
using System.Runtime.InteropServices;

// Autogenerated @ 10/06/18
namespace InterfaceClient
{
    /// <summary>
    /// Exports the delegates for all interfaces that implement ClientEngine
    /// </summary>
    [ArgonCore.Interface.Delegate(Name = "ClientEngine")]
    class ClientEngine_Delegates
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CreateClientPipeDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool ReleaseClientPipeDelegate(IntPtr _, int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CreateGlobalUserDelegate(IntPtr _, ref System.Int32 pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int ConnectToGlobalUserDelegate(IntPtr _, int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CreateLocalUserDelegate(IntPtr _, ref System.Int32 pipe, uint account_type);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ReleaseUserDelegate(IntPtr _, int user, int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUserDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameServerDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetLocalIPBindingDelegate(IntPtr _, uint ip, uint port);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetUniverseNameDelegate(IntPtr _, uint universe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientFriendsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUtilsDelegate(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientBillingDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientMatchmakingDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAppsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientMatchmakingServersDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameSearchDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void RunFrameDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetIPCCallCountDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUserStatsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameServerStatsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientNetworkingDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientRemoteStorageDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientScreenshotsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetWarningMessageHookDelegate(IntPtr _, IntPtr function);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameCoordinatorDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetOverlayNotificationPositionDelegate(IntPtr _, uint position);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetOverlayNotificationInsertDelegate(IntPtr _, uint position);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool HookScreenshotsDelegate(IntPtr _, bool hook);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsOverlayEnabledDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetAPICallResultDelegate(IntPtr _, int pipe, uint handle, ref System.IntPtr callback_buffer, int callback_size, int expected_callback, ref System.Boolean failed);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientProductBuilderDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientDepotBuilderDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientNetworkDeviceManagerDelegate(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ConCommandInitDelegate(IntPtr _, IntPtr __);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAppManagerDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientConfigStoreDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool BOverlayNeedsPresentDelegate();
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameStatsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientHTTPDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool BShutdownIfAllPipesClosedDelegate();
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAudioDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientMusicDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUnifiedMessagesDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientControllerDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientParentalSettingsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientStreamLauncherDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientDeviceAuthDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientRemoteClientManagerDelegate(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientStreamClientDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientShortcutsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUGCDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientInventoryDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientVRDelegate(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameNotificationsDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientHTMLSurfaceDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientVideoDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientControllerSerializedDelegate(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAppDisableUpdateDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int Set_Client_API_CCheckCallbackRegisteredInProcessDelegate(IntPtr _, IntPtr callback);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientBluetoothManagerDelegate(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientSharedConnectionDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientShaderDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientNetworkingSocketsSerializedDelegate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void Destructor_CSteamClient1Delegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void GetIPCServerMapDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void OnDebugTextArrivedDelegate(IntPtr _, string text);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void OnThreadLocalRegistrationDelegate(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void OnThreadBuffersOverLimitDelegate(IntPtr _);
    }
}
