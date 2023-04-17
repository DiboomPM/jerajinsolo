using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class While
    {
        static void Main(string[] args)
        {
            var count = 0; 
            while (count < 3)
            {
                Console.WriteLine("안녕 나는 {0} 이야", count);
                count++;
            }
        }
    }
}
