using System;
using System.Runtime.InteropServices;

// Autogenerated @ 06/08/18
namespace InterfaceArgonCore
{
    /// <summary>
    /// Exports the delegates for all interfaces that implement MappedTest001
    /// </summary>
    [ArgonCore.Interface.Delegate(Name = "MappedTest001")]
    class MappedTest001_Delegates
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int PointerTest(IntPtr _, ref int a, ref int b, ref int c);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int BufferTest(IntPtr _, IntPtr b_pointer, int b_length);
    }
}
