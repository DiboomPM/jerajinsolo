using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpNine
{
    class SeeSharpNine
    {
        static void Main(){

            static int Fib(int i)
            {
                if (i <= 2)
                {
                    return 1;
                }
                return Fib(i - 2) + Fib(i - 1);
            }

            Console.WriteLine($"20번째: {Fib(20)}");
            Console.WriteLine($"3번째: {Fib(3)}");

        }
    }
}
