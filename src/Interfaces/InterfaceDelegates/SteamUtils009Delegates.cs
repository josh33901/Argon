using System;
using System.Runtime.InteropServices;

// Autogenerated @ 21/08/18
namespace InterfaceUtils
{
    /// <summary>
    /// Exports the delegates for all interfaces that implement SteamUtils009
    /// </summary>
    [Core.Interface.Delegate(Name = "SteamUtils009")]
    class SteamUtils009_Delegates
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetSecondsSinceAppActive(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetSecondsSinceComputerActive(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetConnectedUniverse(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate long GetServerRealTime(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetIPCountry(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetImageSize(IntPtr _, int image, ref uint width, ref uint height);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetImageRGBA(IntPtr _, int image, IntPtr dest, int total_dest);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetCSERIPPort(IntPtr _, ref uint ip, ref short port);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate System.Byte GetCurrentBatteryPower(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetAppId(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetOverlayNotificationPosition(IntPtr _, uint pos);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsAPICallCompleted(IntPtr _, int handle, ref bool failed);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int GetAPICallFailureReason(IntPtr _, int handle);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetAPICallResult(IntPtr _, int handle, IntPtr callback, int callback_size, int callback_expected, ref bool failed);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void RunFrame(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetIPCCallCount(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetWarningMessageHook(IntPtr _, IntPtr function);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsOverlayEnabled(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool OverlayNeedsPresent(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int CheckFileSignature(IntPtr _, string file_name);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool ShowGamePadTextInput(IntPtr _, uint input_mode, uint input_line_mode, IntPtr description, uint max_description, string existing_text);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate uint GetEnteredGamepadTextLength(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool GetEnteredGamepadTextInput(IntPtr _, string text, int length);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate string GetSteamUILanguage(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsSteamRunningInVR(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetOverlayNotificationInset(IntPtr _, int horizontal, int vertical);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsSteamInBigPictureMode(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void StartVRDashboard(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate bool IsVRHeadsetStreamingEnabled(IntPtr _);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void SetVRHeadsetStreamingEnabled(IntPtr _, bool enabled);
    }
}
