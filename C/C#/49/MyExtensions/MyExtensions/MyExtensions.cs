using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{   
    static class StringExtension
    {
        public static string Five(this String msg) => msg.Substring(0, 5);
        public static string Ten(this String msg) => msg.Substring(0, 10);
        public static string AddElipsis(this string msg) => msg + "....";
        public static string AddElipsis(this string msg, string elipsis) => $"{msg}{elipsis}";
    }

    class MyExtensions
    {
        static void Main(string[] args)
        {
            string message = "안녕하세요. 반갑습니다. 또 만나요 ";
            Console.WriteLine(message.Five());
            Console.WriteLine(message.Ten());
            Console.WriteLine(message.Five().AddElipsis());
            Console.WriteLine(message.Ten().Five().AddElipsis("___"));
        }
    }
}
