using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class DateTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine(DateTime.Now - (new DateTime(2023, 1, 1)));

            Console.WriteLine(Math.Ceiling((DateTime.Now - (new DateTime(2023, 1, 1))));

            var days = Math.Ceiling((DateTime.Now - (new DateTime(2023, 1, 1)));


        }
    }
}
