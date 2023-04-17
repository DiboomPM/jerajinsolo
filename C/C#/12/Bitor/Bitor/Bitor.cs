using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitor
{
    class BitXor
    {
        static void Main(string[] args)
        {
            byte x = 0b1010; // 10
            byte y = 0b1100; // 12

            // Console.WriteLine(x & y); // 1000 -> 8
            Console.WriteLine($" {Convert.ToString(x, 2)} -> {x}");
            Console.WriteLine($" {Convert.ToString(y, 2)} -> {y}");
            Console.WriteLine($" {Convert.ToString(x | y, 2)} -> {x | y,2}");
        }
    }
}
