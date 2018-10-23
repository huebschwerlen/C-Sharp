using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;
            while (!repeat)
            {
                try
                {
                    bool validAnswer = false;
                    int age = 0;
                    while (!validAnswer)
                    {
                        Console.WriteLine("Please enter the age you are, or will be, by the end of this current year:");
                        validAnswer = int.TryParse(Console.ReadLine(), out age);
                        if (!validAnswer) Console.WriteLine("Please enter digits only. No decimals.");
                    }
                    if (age < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    int timeLapse = DateTime.Now.Year - age;
                    repeat = true;
                    Console.WriteLine("Looks like you were born in the year {0}.", timeLapse);
                    Console.ReadLine();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please enter number greater than 0.");
                    repeat = false; 

                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurered. Please try again.");
                    repeat = false;
                }
                Console.ReadLine();
            }


        }
    }
}
