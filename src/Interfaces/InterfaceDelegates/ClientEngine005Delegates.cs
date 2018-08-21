using System;
using System.Runtime.InteropServices;

// Autogenerated @ 21/08/18
namespace InterfaceClient
{
    /// <summary>
    /// Exports the delegates for all interfaces that implement CLIENTENGINE_INTERFACE_VERSION005
    /// </summary>
    [Core.Interface.Delegate(Name = "CLIENTENGINE_INTERFACE_VERSION005")]
    class CLIENTENGINE_INTERFACE_VERSION005_Delegates
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CreateClientPipe(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool ReleaseClientPipe(IntPtr _, int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CreateGlobalUser(IntPtr _, ref int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int ConnectToGlobalUser(IntPtr _, int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CreateLocalUser(IntPtr _, ref int pipe, uint account_type);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void CreatePipeToLocalUser(IntPtr _, int user, ref int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ReleaseUser(IntPtr _, int user, int pipe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsValidHSteamUserPipe(IntPtr _, int pipe, int user);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUser(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameServer(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetLocalIPBinding(IntPtr _, uint ip, uint port);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetUniverseName(IntPtr _, uint universe);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientFriends(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUtils(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientBilling(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientMatchmaking(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientApps(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientMatchmakingServers(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameSearch(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void RunFrame(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetIPCCallCount(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUserStats(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameServerStats(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientNetworking(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientRemoteStorage(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientScreenshots(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetWarningMessageHook(IntPtr _, IntPtr function);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameCoordinator(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetOverlayNotificationPosition(IntPtr _, uint position);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetOverlayNotificationInsert(IntPtr _, uint position);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool HookScreenshots(IntPtr _, bool hook);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsOverlayEnabled(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetAPICallResult(IntPtr _, int pipe, uint handle, ref IntPtr callback_buffer, int callback_size, int expected_callback, ref bool failed);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientProductBuilder(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientDepotBuilder(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientNetworkDeviceManager(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void ConCommandInit(IntPtr _, IntPtr __);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAppManager(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientConfigStore(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool BOverlayNeedsPresent();
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameStats(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientHTTP(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool BShutdownIfAllPipesClosed();
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAudio(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientMusic(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUnifiedMessages(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientController(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientParentalSettings(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientStreamLauncher(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientDeviceAuth(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientRemoteClientManager(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientStreamClient(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientShortcuts(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientUGC(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientInventory(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientVR(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientGameNotifications(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientHTMLSurface(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientVideo(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientControllerSerialized(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientAppDisableUpdate(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int Set_Client_API_CCheckCallbackRegisteredInProcess(IntPtr _, IntPtr callback);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientBluetoothManager(IntPtr _, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientSharedConnection(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientShader(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClientNetworkingSocketsSerialized(IntPtr _, int user, int pipe, string version);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void Destructor_CSteamClient1(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void GetIPCServerMap(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void OnDebugTextArrived(IntPtr _, string text);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void OnThreadLocalRegistration(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void OnThreadBuffersOverLimit(IntPtr _);
    }
}
