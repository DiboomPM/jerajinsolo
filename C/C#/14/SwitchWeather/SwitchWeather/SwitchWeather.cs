using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchWeather
{
    class SwitchWeather
    {
        static void Main(string[] args)
        {
            Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈)");
            String weather = Console.ReadLine();
            String message = "";

            switch (weather)
            {
                case "좋음":
                case "맑음":
                    //Console.WriteLine("오늘 날씨는 맑군요");
                    message = "오늘 날씨는 맑군요";
                    break;
                case "흐림":
                    //Console.WriteLine("오늘 날씨는 흐리군요");
                    message = "오늘 날씨는 흐리군요";
                    break;
                case "비":
                    //Console.WriteLine("오늘 날씨는 비가 옵니다");
                    message = "오늘 날씨는 비가 옵니다";
                    break;
                default:
                    //Console.WriteLine("오늘은 눈이 내립니다.");
                    message = "오늘은 눈이 내립니다.";
                    break;
            }
            Console.WriteLine(message);
        }
    }
}
