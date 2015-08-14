using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Centered
    {
       
     
        
        
        public static void Section(string[] input)
        {
            foreach (string item in input)
            {
                Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.CursorTop);
                Console.WriteLine(item);
            }
            
          
        }

        public static void LineReturn(string input)
        {
            Console.SetCursorPosition((Console.WindowWidth - input.Length) / 2, Console.CursorTop);
            Console.WriteLine(input);
        }

        public static void Line(string input)
        {
            Console.SetCursorPosition((Console.WindowWidth - input.Length) / 2, Console.CursorTop);
            Console.Write(input);
        }


    }
}
