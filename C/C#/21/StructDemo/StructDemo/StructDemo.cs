using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 구조체 : 하나 이상의 변수 또는 배열을 묶어서 관리
namespace StructDemo
{
    struct Point
    {
        // public : 공용
        public int x;
        public int y;
        // private : 전용
        private int z;
    }

    class StructDemo
    {
        static void Main(string[] args)
        {
            Point point;
            point.x = 100;
            point.y = 200;
            Console.WriteLine($"X : {point.x}, Y : {point.y}");
        }
    }
}
