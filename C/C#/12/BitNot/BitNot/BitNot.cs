using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitNot
{
    class BitNot
    {
        static void Main(string[] args)
        {
            byte x = 0b00001010; // 10

            Console.WriteLine($" {Convert.ToString(x, 2)} -> {x}");
            Console.WriteLine($" {Convert.ToString((byte)~x, 2).PadLeft(8, '0')} -> {~x}");
        }
    }
}
