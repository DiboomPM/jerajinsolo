using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guid
{
    class Guid
    {
        static void Main(string[] args)
        {
            // 전 우주적으로 유니크한 데이터 출력
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.WriteLine(Guid.NewGuid());
        }
    }
}
