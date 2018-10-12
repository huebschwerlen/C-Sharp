using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to add 10 to it.");
            int intInput = Convert.ToInt32(Console.ReadLine());
            
            intInput = mathClass.AddN(intInput);
            Console.WriteLine(intInput);
            Console.ReadKey();

            intInput = mathClass.SubN(intInput);
            Console.WriteLine(intInput);
            Console.ReadKey();

            intInput = mathClass.MultN(intInput);
            Console.WriteLine(intInput);
            Console.ReadKey();

        }
    }
}
