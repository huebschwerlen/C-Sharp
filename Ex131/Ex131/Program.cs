using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>();
            things.Things = new List<string> { "thingOne", "thingTwo", "thingThree" };

            Employee<int> thingsInt = new Employee<int>();
            thingsInt.Things = new List<int> { 1, 2, 3 };

            for (int i = 0; i < thingsInt.Things.Count; i++)
            {
                Console.WriteLine(thingsInt.Things[i]);
            }

            foreach(string thing in things.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }
    }
}
