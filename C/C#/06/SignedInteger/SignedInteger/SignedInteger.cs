using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedInteger
{
    class SignedInteger
    {
        static void Main(string[] args)
        {
            sbyte sb = 127;
            short st = 32767;
            int i = Int32.MaxValue;
            long l = Int64.MaxValue;

            Console.WriteLine("{0} {1} {2} {3}", sb, st, i, l);

            double PI = 3.141592;
            Console.WriteLine(PI);

            double PI2 = 3.141592D;
            Console.WriteLine(PI2);

            //float f = 3.14;
            float f = 3.14f;
            float f2 = (float)3.14;
            Console.WriteLine(f);
            Console.WriteLine(f2);

            //decimal money = 12.34;
            decimal money = 12.34m;
            Console.WriteLine(money);

            // 숫자데이터는 null을 넣을수 없음 
            int x = null;
            Console.WriteLine(x);
            // 이렇게 하면 가능
            // int? , long?, float?, double?, decimal? 
            int? x2 = null;
            Console.WriteLine(x2);
        }
    }
}
