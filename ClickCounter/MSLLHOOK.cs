using System;
using System.Runtime.InteropServices;

namespace ClickCounter
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MSLLHOOK
    {
        public POINT pt;
        public uint mouseData;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }
}
