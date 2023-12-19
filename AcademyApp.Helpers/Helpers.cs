using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Helpers
{
    public class Helpers
    {
        public static void changeTextColor(string word,ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(word);
            Console.ResetColor();
        }
    }
}
