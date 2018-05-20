using System;

// Autogenerated @ 20/05/18
namespace InterfaceSteamUser
{
    /// <summary>
    /// Exports the delegates for all interfaces that implement SteamUser019
    /// </summary>
    [ArgonCore.Interface.Map(Name = "SteamUser019", Implements = "SteamUser")]
    public class SteamUser019_Map : ArgonCore.Interface.IBaseInterfaceMap
    {
        public IntPtr GetHSteamUser()
        {
            var sf = new ArgonCore.IPC.SerializedFunction
            {
               InterfaceId = InterfaceId,
               Name = "GetHSteamUser",
               Args = new object[] {},
            };
            return ArgonCore.IPC.Client.CallSerializedFunction<IntPtr>(sf);
        }
        public void TestMeme()
        {
            var sf = new ArgonCore.IPC.SerializedFunction
            {
               InterfaceId = InterfaceId,
               Name = "TestMeme",
               Args = new object[] {},
            };
            ArgonCore.IPC.Client.CallSerializedFunction(sf);
        }
        public int TestMeme2(Int32[] arg)
        {
            var sf = new ArgonCore.IPC.SerializedFunction
            {
               InterfaceId = InterfaceId,
               Name = "TestMeme2",
               Args = new object[] {arg},
            };
            return ArgonCore.IPC.Client.CallSerializedFunction<int>(sf);
        }
    }
}
