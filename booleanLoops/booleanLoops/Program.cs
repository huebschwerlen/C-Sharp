using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 32;

            do
            {
                switch (number)
                {
                    case 32:
                        Console.WriteLine("You guessed the correct number!");
                        isGuessed = true;
                        break;

                    //case (number < 32):
                    //    Console.WriteLine("Number too Low.");
                    //    Console.WriteLine("Guess a number:");
                    //    number = Convert.ToInt32(Console.ReadLine());
                    //    break;

                    default:
                        Console.WriteLine("Wrong Number. Please try again.");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);

            Console.Read();

            bool awesome = false;
            while (!awesome)
            {
                Console.WriteLine("AweSam");
            }
         
        }
    }
}
