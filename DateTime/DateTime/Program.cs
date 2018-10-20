using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine(dateTimeNow);//1. Prints the current date and time to the console.
            Console.WriteLine("Enter a number: ");//2. Asks the user for a number.
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime timeLapse = dateTimeNow.AddHours(number);
            //3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("It will be {0} in {1} hours.", timeLapse, number);
            Console.ReadLine();
            


        }
    }
}
