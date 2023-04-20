using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Enum
    {
        enum Animal { Mouse, Cow, Tiger }


        static void Main(string[] args)
        {
            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);
            Console.WriteLine(Animal.Mouse);
            Console.WriteLine(nameof(Animal.Mouse));
        }
    }
}
