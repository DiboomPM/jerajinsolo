using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Generic
    {
        static void Main(string[] args)
        {
            List<string> color = new List<string>() { "Red", "Blue" };

            Console.WriteLine(color);
        }

        class Person
        {
            public string Name { get; set; }
        
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동"},
                new Person { Name = "백두산"},
                new Person { Name = "임꺽정"}
            };

        }
    }
}
