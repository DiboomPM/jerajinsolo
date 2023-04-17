using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            string[] names = { "C#", "ASP.NET" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            string str = "ABC123";
            foreach(char c in str)
            {
                Console.WriteLine(c);
            }
        }
    }
}
