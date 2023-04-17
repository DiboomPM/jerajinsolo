using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"{(i+1)}번 반복\t");
            }
            Console.WriteLine();
        }
    }
}
