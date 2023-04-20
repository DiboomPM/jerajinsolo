using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTextbook
{
    class EnumerationTextbook
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Magenta & Yellow");
            Console.WriteLine($"Magenta & {nameof(ConsoleColor.Yellow)}");
            Console.ResetColor();

        }
    }
}
