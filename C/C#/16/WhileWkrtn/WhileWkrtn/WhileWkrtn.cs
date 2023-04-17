using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileWkrtn
{
    class WhileWkrtn
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"1부터 100까지 짝수의 합은 : {sum}");
        }
    }
}
