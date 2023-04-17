using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While100
{
    class While100
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"1부터 100까지의 합은 : {sum}");
        }
    }
}
