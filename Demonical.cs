using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Demonical.src.GUI;
using Woyska.Console;

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

            Console.Title("Demonical | Client");

            Console.EncodingUTF8();
            
            Console.Send("darkblue", "██████  ███████ ███    ███  ██████  ███    ██ ██  ██████  █████  ██      ");
            Console.Send("darkblue", "██   ██ ██      ████  ████ ██    ██ ████   ██ ██ ██      ██   ██ ██      ");
            Console.Send("darkblue", "██   ██ █████   ██ ████ ██ ██    ██ ██ ██  ██ ██ ██      ███████ ██      ");
            Console.Send("darkblue", "██   ██ ██      ██  ██  ██ ██    ██ ██  ██ ██ ██ ██      ██   ██ ██      ");
            Console.Send("darkblue", "██████  ███████ ██      ██  ██████  ██   ████ ██  ██████ ██   ██ ███████ ");

            Console.Write("[", "white");
            Console.Write("Информация", "darkblue");
            Console.Write("] Made by", "white");
            Console.Send("darkblue", " Destr1x");
            
            Console.Write("[", "white");
            Console.Write("Информация", "darkblue");
            Console.Write("] Demonical", "white");
            Console.Send("darkblue", " v1.0");
            
            Console.Write("[", "white");
            Console.Write("Информация", "darkblue");
            Console.Write("] Открытие меню на", "white");
            Console.Send("darkblue", " TAB");
            
            Console.Write("[", "white");
            Console.Write("Информация", "darkblue");
            Console.Write("] Закрытие программы на", "white");
            Console.Send("darkblue", " F12");

            Thread.Sleep(5000);

            Process.Start("minecraft://");

            FreeConsole();

            while (true)
            {
                if (GetAsyncKeyState(Keys.F12) != 0)
                {
                    System.Environment.Exit(0);
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
                        menu.Invoke(new System.Action()) => menu.Close()));
                    }
                    Thread.Sleep(300);
                }

                Application.DoEvents();
            }
        }
    }
}           
