using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//해
namespace GotoDemo
{
    class GotoDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시작");
        start:
            Console.WriteLine("0,1,2 중 하나 입력: _ \b");
            int chapter = Convert.ToInt32(Console.ReadLine());

            if (chapter == 1)
            {
                goto Chapter1;
            }else if (chapter == 2)
            {
                goto Chapter2;
            }
            else
            {
                goto end;
            }

            Chapter1:
            Console.WriteLine("1장입니다.");
            Chapter2:
            Console.WriteLine("2장입니다.");
            goto start;

            end:
            Console.WriteLine("종료");
 

        }
    }
}

