using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex117
{
    class Program
    {
        static void Main(string[] args)
        {
            Class117 Instan117 = new Class117(); //2.instantiate the class
            int Quotient0;
            Console.WriteLine("Enter a number to have it divided by 2: "); //3.have the user enter a number. 
            int UserInput = Convert.ToInt32(Console.ReadLine());
            Instan117.Method117(UserInput, out Quotient0); //call the method on that number. 
            Console.WriteLine(Quotient0); //display the output to the screen. it should be the entered number, divided by two.
            Console.ReadLine();


            Class117.Method117(UserInput);
            Console.ReadLine();
        }
    }
}
