using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 쓰레드 : 작업자 한 사람
namespace ThreadNote
{
    class Restaurant
    {
        public void MakeFood()
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000); Console.WriteLine("달걀 3초");
            }
            Thread t1 = new Thread(new ThreadStart(Egg));

            void Soup()
            {
                Thread.Sleep(5000); Console.WriteLine("국 5초");
            }
            Thread t2 = new Thread(Soup);

            Thread t3 = new Thread(() =>
            {
                Thread.Sleep(7000); Console.WriteLine("밥 7초");
            });
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();

            Console.WriteLine($"요리 종료 : {(DateTime.Now - start).TotalSeconds}");

            Console.WriteLine($"식사 시작");
            SinglePro();
            MultiPro();

            Console.WriteLine($"식사 종료: {(DateTime.Now - start).TotalSeconds}");
        }
    }

    private void SinglePro()
    {
        for(int i = 0; i < 20_000; i++)
        {
            Console.WriteLine("수다");
        }
    }

    private void MultiPro()
    {
        throw new NotImplementedException();
    }

    class ThreadNote
    {
        static void Main() => (new Restaurant()).MakeFood();
    }
}
