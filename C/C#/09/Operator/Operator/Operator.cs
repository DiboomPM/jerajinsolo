using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Operator
    {
        static void Main(string[] args)
        {
            var num = 1000;
            var number = num + 1234;
            Console.WriteLine(number);
            // + - * / 다 가능 

            var value = 8;
            value = -value; // 앞에 -붙이면 음수로 변경됨
            Console.WriteLine(value); // -8

            var numnum = 3.14;
            var numnum2 = parseInt(3.14); // 실수에서 정수로 변경
            var numnum3 = parseFloat(3); // 정수에서 실수로 변경


        }
    }
}
