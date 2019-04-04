using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string numEx_1 = Console.ReadLine();
            int numEx_1C = Convert.ToInt32(numEx_1);
            int total_1 = numEx_1C * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + total_1);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string numEx_2 = Console.ReadLine();
            int numEx_2C = Convert.ToInt32(numEx_2);
            int total_2 = numEx_2C + 25;
            Console.WriteLine("Your number plus 25 is: " + total_2);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string numEx_3 = Console.ReadLine();
            int numEx_3C = Convert.ToInt32(numEx_3);
            double total_3 = numEx_3C / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + total_3);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string numEx_4 = Console.ReadLine();
            int numEx_4C = Convert.ToInt32(numEx_4);
            bool trueOrFalse = numEx_4C > 50;
            Console.WriteLine("The number entered is greater than 50: " + trueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Enter a number:");
            string numEx_5 = Console.ReadLine();
            int numEx_5C = Convert.ToInt32(numEx_5);
            int total_5 = numEx_5C % 7;
            Console.WriteLine("Your number, divided by 7, has the remainder of: " + total_5);
            Console.ReadLine();


        }
    }
}
