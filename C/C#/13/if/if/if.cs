using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 40;
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
