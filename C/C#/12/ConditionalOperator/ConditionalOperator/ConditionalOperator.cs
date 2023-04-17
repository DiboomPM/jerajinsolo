using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            int number = 3;

            // 식 ? "참" / "거짓"
            string result = (number % 2 == 0) ? "짝수" : "홀수";

            Console.WriteLine($"{number}는 {result}입니다.");
        }
    }
}
