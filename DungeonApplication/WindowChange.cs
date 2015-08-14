using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DungeonApplication
{
    class WindowChange
    {
        const int SWP_NOSIZE = 0x0001;


        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);



        public static void WinPos()
        {
            int width, height;
            int origWidth = Console.WindowWidth;
            int origHeight = Console.WindowHeight;

            width = origWidth + 20;
            height = origHeight + 20;
            Console.SetWindowSize(width, height);

            int xpos = 250;
            int ypos = 100;
            SetWindowPos(MyConsole, 0, xpos, ypos, 0, 0, SWP_NOSIZE);
        }
        
        public static void WinSize()
        {
            int Width = Console.WindowWidth;
            int Height = Console.WindowHeight;
            Console.WriteLine("Window height:  " + Height);
            Console.WriteLine("Window width:   " + Width);

        }

    }
}
