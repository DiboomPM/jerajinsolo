using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerDemo2
{
    class integerDemo2
    {
        static void Main(string[] args)
        {
            int number = 1_234;
            Console.WriteLine("{0}", number);

            // 타입의 가장 작은값
            int min = Int32.MinValue;
            // 타입의 가장 큰 값
            int max = Int32.MaxValue;
            Console.WriteLine("{0}", min);
            Console.WriteLine("{0}", max);
        }
    }
}
