using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUE4.Utils.src.ColorConsole
{
    public static class ColorfulConsole
    {
        public static void WriteLine(string message, string name)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("] " + message + "\n");
        }
    }
}
