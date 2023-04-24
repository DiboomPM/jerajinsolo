using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Tuple
    {
        static void Main(string[] args)
        {
            var r = (12, 34, 56);
            Console.WriteLine(r.Item1);
            Console.WriteLine(r.Item2);
            Console.WriteLine(r.Item3);

            var fhd = (1920, 1080);
            Console.WriteLine(fhd.Item1);
            Console.WriteLine(fhd.Item2);

            var uhd = (Width: 3840, Height: 2160);
            Console.WriteLine(uhd.Width);
            Console.WriteLine(uhd.Height);

            (ushort Width, ushort Height) hd = (1366, 768);
            Console.WriteLine($"{hd.Width}, {hd.Height}, {hd.Width.GetType()}");

        }
    }
}
