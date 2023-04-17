using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            String arr = "C#8";
            Console.WriteLine(arr);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            int[] numbers = new int[3];
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            int[] numbers2 = new int[] {10, 20, 30 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers3 = { 10, 20, 30 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            String[] names = { "김지범", "김지우", "노윤서" };
            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
