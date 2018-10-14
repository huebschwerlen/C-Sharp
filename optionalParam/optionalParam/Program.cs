using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParam
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.In the Main() method of the console app, instantiate the class.
            Class1 math1 = new Class1();

            /*
             3. Ask the user to input two numbers, one at a time. 
             Let them know they need not enter anything for the second number.
            */
            
            Console.WriteLine("Please enter a number: ");
            int intInput1 = Convert.ToInt32(Console.ReadLine());
            int intInput2;
            try
            {
                Console.WriteLine("Optional: Enter a second number: ");
                intInput2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                intInput2 = 0; //5. Try various combinations of numbers on the code, including having no second number.
            }




    //4.Call the method in the class, passing in the one or two numbers entered.
    int intInput = math1.MathOp(intInput1, intInput2);
            Console.WriteLine(intInput);
            Console.ReadKey();
        }
    }
}
