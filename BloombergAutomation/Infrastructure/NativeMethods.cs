using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
namespace BloombergAutomation.Infrastructure
{

    /// <summary>
    /// wrapper for User32.dll functions
    /// </summary>
    internal static class NativeMethods
    {
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
                                                     string lpszClass, string lpszWindow);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        
        /*
        [DllImport("user32.dll", EntryPoint = "ClientToScreen")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen([In] IntPtr hWnd, ref NativePoint lpPoint);
        */

        [DllImport("user32.dll", EntryPoint = "ClientToScreen")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen([In] IntPtr hWnd, ref System.Drawing.Point lpPoint);



        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
    }
}