using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Continue
    {
        // 100까지 3배수를 제외한 수의 합
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("합 : {0}", sum);
        }
    }
}
