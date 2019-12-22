using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YourProgram
{
    class HideWindow
    {
        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        public HideWindow(bool type)
        {
            IntPtr hWnd = GetConsoleWindow();
            if (type)
            {
                if (hWnd != IntPtr.Zero)
                {
                    ShowWindow(hWnd, 0);

                }

            }
            else
                if (hWnd != IntPtr.Zero)
                {
                    ShowWindow(hWnd, 1);
                }
        }
        public void ChangeHidden(bool type)
        {
            IntPtr hWnd = GetConsoleWindow();
            if (type)
            {
                if (hWnd != IntPtr.Zero)
                {
                    ShowWindow(hWnd, 0);

                }

            }
            else
                if (hWnd != IntPtr.Zero)
            {
                ShowWindow(hWnd, 1);
            }
        }
    }
}
