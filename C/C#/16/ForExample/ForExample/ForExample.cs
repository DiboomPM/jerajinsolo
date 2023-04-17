using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExample
{
    class ForExample
    {
        static void Main(string[] args)
        {
            // 1~100까지의 3의 배수이고 4의 배수의 정수의 합
            int num = 1;
            int sum = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 ==0 && i % 4 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
