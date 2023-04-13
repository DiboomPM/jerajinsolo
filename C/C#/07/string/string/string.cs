using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class @string
    {
        static void Main(string[] args)
        {
            // char은 한글자만 저장 가능
            char grade = 1234;
            char grade2 = "AAA";
            // 위는 잘못된 형식
            char grade3 = 'a';
            char kor =  '가';
            char es = '\n'; // 문자로 표기 
            Console.WriteLine(grade3);

            string hi = 1234;
            string hi2 = 'hi';
            // 위는 잘못된 형식
            string hi3 = "hi";
            Console.WriteLine(hi3);

            string name = "김지범";
            Console.WriteLine("안녕하세요 {0}입니다.", name);

            string multiLines = @"
                안녕하세요?
                이건 멀티라인입니다.";
            Console.WriteLine(multiLines);

            Console.WriteLine("{0}, {1}", "하이", "안녕");

            Console.WriteLine($"{1234} is {"number"}"); 

            int number = 3;
            string result = "홀수";
            Console.WriteLine($"{number}은(는) {result}입니다.");

            // PlaceHolder
            Console.WriteLine("안녕" + "," + "반가워");

            // String.Format() 메서드 : 문자열 연결 관련 주요 기능 제공
            // 문자열 보관
            String msg = string.Format("{0}님, {1}", "김지범", "안녕하세요");
            Console.WriteLine("msg : {0}", msg);
            Console.WriteLine("msg : " + msg);
            Console.WriteLine(String.Format("msg : {0}", msg));
            Console.WriteLine($"msg : {msg}");


            String name2 = "C#";
            String version = "8.0";

            Console.WriteLine("{0}, {1}", name2, version);

            String result2 = String.Format("{0}, {1}", name2, version);
            Console.WriteLine(result2);

            Console.WriteLine($"{name2}, {version}");


            bool bln = true;
            bool bln2 = false;
            Console.WriteLine(bln);
            Console.WriteLine(bln2);

            // 상수(Constant) : 변하지 않는 변수, 읽기 전용 변수
            const double PIPI = 3.14;
            // 변경 불가
            PIPI = 3.15;


            int number1 = 1234;     //int 키워드 : 기본형식
            Int32 number2 = 1234;   // System.Int32 구조체 : .NET형식(래퍼형식)
            Console.WriteLine($"{number1}, {number2}");

            string str1 = "안녕";     // string 키워드 : 기본형식
            String str2 = "안녕";     // System.String 클래스 : .NET형식(래퍼형식)
            Console.WriteLine($"{str1}, {str2}");

            String day = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";
            Console.WriteLine(day);

        }
    }
}
