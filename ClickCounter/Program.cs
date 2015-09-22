using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClickCounter
{
    static class Program
    {
        public static void Main()
        {
            MouseHook.Initialize();
            Application.Run(new Tray());
            MouseHook.Dispose();
        }
    }
}
