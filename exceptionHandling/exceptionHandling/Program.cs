using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> intNums = new List<int>() { 11, 100, 3, 2, 1 };
            intNums.ForEach(Console.WriteLine);

            bool run = false;
            do
            {

                

                try
                {

                   
                    Console.WriteLine("Enter a number to divide each number in the list by: ");
                    int inputNum = Convert.ToInt32(Console.ReadLine());

                    foreach (int num in intNums)
                    {
                        Console.WriteLine(num / inputNum);

                    }
                    Console.ReadLine();
                    run = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a whole number.");

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't enter a zero.");

                }
                finally
                {
                    Console.WriteLine("Program has emerged from the try/catch block and continued on with program execution.\nPress Enter to continue.");
                    Console.ReadLine();
                }

            }
            while (!run);

            Console.WriteLine("Reached end of Program. Goodbye.");
            Console.ReadLine();
        }
        
    }
    
}         
