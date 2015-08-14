using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonApplication
{
    public class BossFight
    {

        public static void Fight()
        {

            string[] BossFight = {
            "                      ██████╗  ██████╗ ███████╗███████╗                          ",                         
            "                      ██╔══██╗██╔═══██╗██╔════╝██╔════╝                          ",                         
            "                      ██████╔╝██║   ██║███████╗███████╗                          ",                         
            "                      ██╔══██╗██║   ██║╚════██║╚════██║                          ",                         
            "                      ██████╔╝╚██████╔╝███████║███████║                          ",                         
            "                      ╚═════╝  ╚═════╝ ╚══════╝╚══════╝                          ",                         
           "███████╗██╗ ██████╗ ██╗  ██╗████████╗    ██╗██╗ ██╗ ██╗ ██████╗ ███╗   ██╗███████╗",
           "██╔════╝██║██╔════╝ ██║  ██║╚══██╔══╝    ██║██║███║███║██╔═══██╗████╗  ██║██╔════╝",
           "█████╗  ██║██║  ███╗███████║   ██║       ██║██║╚██║╚██║██║   ██║██╔██╗ ██║█████╗  ",
           "██╔══╝  ██║██║   ██║██╔══██║   ██║       ╚═╝╚═╝ ██║ ██║██║   ██║██║╚██╗██║██╔══╝  ",
           "██║     ██║╚██████╔╝██║  ██║   ██║       ██╗██╗ ██║ ██║╚██████╔╝██║ ╚████║███████╗",
           "╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═╝╚═╝ ╚═╝ ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝"
                                };   

            for (int i = 0; i <= 200; i++)
            {
                //Console.WriteLine("\n\n\n");
                Console.Clear();
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Centered.Section(BossFight);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Centered.Section(BossFight);
                }
            }
        }
    }
}
