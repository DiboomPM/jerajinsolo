using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleReturn
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static (int, int) Tally1()
        {
            var r = (12, 3);
            return r;
        }
        // var t1 = Tally1();
        // t1.Item1
        // t1.Item2

        static (int sum, int Count) Tally()
        {
            var r = (s: 12, c: 3);
            Console.WriteLine($"{r.s}, {r.c}");
            return r;
        }

        /*
        var t = Tally();
        12, 3
        t.sum
        12
        t.Count
        3
        var (sum, count) = Tally();
        12, 3
        sum
        12
        count
        3         
         */


    }
}
