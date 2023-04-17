using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftLeft
{
    class ShiftLeft
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 시프트 연산자");

            byte x = 0b0000_0010; //2 

            Console.WriteLine($"{nameof(x),10} : {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x,3}");
            Console.WriteLine($"x = x << 1 : {Convert.ToString(x << 1, 2).PadLeft(8, '0')} -> {x << 1,3}");
            Console.WriteLine($"x = x << 2 : {Convert.ToString(x << 2, 2).PadLeft(8, '0')} -> {x << 2,3}");
            Console.WriteLine($"x = x << 3 : {Convert.ToString(x << 3, 2).PadLeft(8, '0')} -> {x << 3,3}");

            x = 0b0001_1000; //24
            Console.WriteLine($"{nameof(x),10} : {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x,3}");
            Console.WriteLine($"x = x >> 1 : {Convert.ToString(x >> 1, 2).PadLeft(8, '0')} -> {x >> 1,3}");
            Console.WriteLine($"x = x >> 2 : {Convert.ToString(x >> 2, 2).PadLeft(8, '0')} -> {x >> 2,3}");
            Console.WriteLine($"x = x >> 3 : {Convert.ToString(x >> 3, 2).PadLeft(8, '0')} -> {x >> 3,3}");
        }
    }
}
