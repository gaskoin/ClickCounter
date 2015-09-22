using System.Runtime.InteropServices;

namespace ClickCounter
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }
}
