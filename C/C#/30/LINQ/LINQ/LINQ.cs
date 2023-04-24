using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ : C# 언어에 직접 쿼리 기능을 통합하는 방식으로 하는 기술 집합 이름 
namespace LINQ
{
    class LINQ
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int sum = 0;
            for (int i = 0; i< nums.Length; i++)
            {
                //sum += 1;
                sum += nums[i];

            }
            Console.WriteLine(sum);

            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Average());

            int[] nums2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums2.Count());
            Console.WriteLine(nums2.Average());

            Console.WriteLine(nums2.Where(n => n % 2 == 0).ToList());
            Console.WriteLine(nums2.Select(x => x));

            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");

            Console.WriteLine(techs);
        }
    }
}
