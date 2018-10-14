using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2. In the Main() method of the console app, 
             instantiate the class and call the one method, 
             passing in an integer, such as 12. 
             Then display the result to the screen.
             */
            mathOp math1 = new mathOp();
            int returnVal = 0;
            returnVal = math1.methOne(12);
            
            Console.WriteLine(returnVal);
            


            /*
             4. In the Main() method of the console app, 
             instantiate the class and call the second method, 
             passing in a decimal. Display the result to the screen.
             */

            mathOp math2 = new mathOp();
            int returnVal1 = 0;
            returnVal1 = math2.methOne(13.22m);

            Console.WriteLine(returnVal1);
            



            /*
             6. In the Main() method of the console app, 
             instantiate the class and call the third method, 
             passing in a string that equates to an integer. 
             Display the result to the screen.
             */

            mathOp math3 = new mathOp();
            int returnVal2 = 0;
            returnVal2 = math3.methOne("2");

            Console.WriteLine(returnVal2);
            Console.ReadLine();

        }
    }
}
