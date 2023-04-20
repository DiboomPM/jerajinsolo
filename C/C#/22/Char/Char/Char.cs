using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Char
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Char.ToUpper('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsWhiteSpace('A'));
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsDigit('b'));
            Console.WriteLine(Char.IsLetterOrDigit(' '));
        }
    }
}
