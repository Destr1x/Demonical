using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Demonical.src.GUI;

namespace Demonical
{
    public class Demonical
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        static Form menu = null;

        static void Main()
        {
            AllocConsole();

            Console.Title = "Demonical | Client";

            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("██████  ███████ ███    ███  ██████  ███    ██ ██  ██████  █████  ██      ");
            Console.WriteLine("██   ██ ██      ████  ████ ██    ██ ████   ██ ██ ██      ██   ██ ██      ");
            Console.WriteLine("██   ██ █████   ██ ████ ██ ██    ██ ██ ██  ██ ██ ██      ███████ ██      ");
            Console.WriteLine("██   ██ ██      ██  ██  ██ ██    ██ ██  ██ ██ ██ ██      ██   ██ ██      ");
            Console.WriteLine("██████  ███████ ██      ██  ██████  ██   ████ ██  ██████ ██   ██ ███████ ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Информация");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] Made by");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Destr1x");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Информация");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] Demonical");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" v1.0");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Информация");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] Открытие меню на");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" TAB");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Информация");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] Закрытие программы на");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" F12 ");

            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(5000);

            Process.Start("minecraft://");

            FreeConsole();

            while (true)
            {
                if (GetAsyncKeyState(Keys.F12) != 0)
                {
                    Environment.Exit(0);
                }

                if (GetAsyncKeyState(Keys.Tab) != 0)
                {
                    if (menu == null)
                    {
                        menu = new src.GUI.Menu();
                        menu.FormClosed += (s, e) => menu = null;
                        menu.Show();
                    }
                    else
                    {
                        menu.Invoke(new Action(() => menu.Close()));
                    }
                    Thread.Sleep(300);
                }

                Application.DoEvents();
            }
        }
    }
}           
