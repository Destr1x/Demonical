using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demonical.src.GUI.Functions
{
    public class AutoClicker
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int a, int b, int c, int d, int well);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public static void AutoClick(int value, int down, int up)
        {
            while (true) {
                if (GetAsyncKeyState(Keys.NumPad0) != 0)
                {
                    break;
                }
                mouse_event(down, 0, 0, 0, 0);
                Thread.Sleep(value * 1);
                mouse_event(up, 0, 0, 0, 0);
                Thread.Sleep(value * 1);
            }
        }
    }
}
