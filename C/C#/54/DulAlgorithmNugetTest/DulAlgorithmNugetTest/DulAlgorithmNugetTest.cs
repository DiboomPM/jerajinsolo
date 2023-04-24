using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulAlgorithmNugetTest
{
    class DulAlgorithmNugetTest
    {
        static void Main(string[] args)
        {
            int[] numbers = { 334, 123, 745, 532, 957 };

            int[] results = DulAlgorithm.Algorithm.SelectionSort(numbers);

            foreach (var r in results)
            {
                Console.WriteLine(r);
            }

        }
    }
}
