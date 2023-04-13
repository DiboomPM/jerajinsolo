using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLineNote
{
    class ReadLineNote
    {
        static void Main(string[] args)
        {
            // Console.ReadLine(); // 이 시점에서 대기하는 효과
            // Console.WriteLine(Console.ReadLine());  // 입력된 데이터를 다시 반환함
            /*
            Console.Write("이름:______\b\b\b\b\b\b");
            String name = Console.ReadLine();
            Console.WriteLine($"{name}님 안녕하세요?");
            */

            /*
            int x = Console.Read();
            Console.WriteLine(x);   //아스키 문자
            Console.WriteLine(Convert.ToChar(x)); // 실제 문자

            int i = 1234;
            i.GetType();

            double d = 3.14;
            d.GetType();
            */

            Console.WriteLine("정수 : ");
            string rum = Console.ReadLine();
            int number = Convert.ToInt32(rum);
            Console.WriteLine(number + number);

            int numm = 10;
            // Convert - 숫자로 이진수로 변경
            string numm2 = Convert.ToString(numm, 2);
            Console.WriteLine(numm2);

            // 왼쪽에 빈 정보를 특정 문제로 변경함
            string padLeft = Convert.ToString(numm, 2).PadLeft(8, '0');
            Console.WriteLine(padLeft);
            string padLeft2 = Convert.ToString(numm, 2).PadLeft(8, '_');
            Console.WriteLine(padLeft2);
            string padLeft3 = Convert.ToString(numm, 2).PadLeft(8, '7');
            Console.WriteLine(padLeft3);


            // 2진수 정보를 아스키코드로 변경
            int new1 = Convert.ToInt32("1010", 2);
            Console.WriteLine(new1);
            // 아스키코드를 2진수로 변경 
            string new2 = Convert.ToString(10, 2);
            Console.WriteLine(new2);


            // 0b가 붙을 경우 이진수를 아스키코드로 변경하여 저장함
            int b1 = 0b0010;
            Console.WriteLine(b1);
            int b2 = 0b1010;
            Console.WriteLine(b2);


            // var 키워드 : 암시적으로 형식화된 로컬 변수
            string name1 = "RedPlus";
            Console.WriteLine(name1);
            var name2 = "RedPlus";
            Console.WriteLine(name2);

            var age1 = 29;
            int age2 = 29;
            Console.WriteLine(age1);
            Console.WriteLine(age2);

            Console.WriteLine(age1.GetType());
            // System.Int32 Type

            var version = 8.0;
            Console.WriteLine(version.GetType());
            // System.Double Type
            // var를 사용한다고 속도차이는 없음. JavaScript : var == C# : dynamic 같다.
            // 문자타입과 맞춰서 보여줌.
            dynamic aaa = 1.0;
            Console.WriteLine(aaa);
            aaa = "김지범";
            Console.WriteLine(aaa);
           


        }
    }
}
