using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulAlgorithm.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. input
            int[] data = { 1, 3, 5, 2, 4 };

            // 2. process
            int[] numbers = DulAlgorithm.Algorithm.SelectionSort(data);

            // 3 output
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }


        }
    }
}
