﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassName
{
    public class ClassName
    {
        // [1][2] 멤버 생성: 메서드 멤버 생성
        public static void MemberName()
        {
            Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
        }
    }

    public class ClassAndMember
    {
        public static void Main()
        {
            // [2][1] 클래스 사용
            ClassName.MemberName(); // 정적(Static) 멤버 접근
        }
    }
}
