using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionNote
{
    class FunctionNote
    {
        static int Sum(int first, int second) => (first + second);
        }

        static void Main(String[] args)
        {
            int first = Convert.ToInt32(args[0]);
            int second = Convert.ToInt32(args[1]);
            Console.WriteLine(Sum(first, second));
        }
    }
}
