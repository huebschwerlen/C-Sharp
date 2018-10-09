using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageCon = Console.ReadLine();
            int age = Convert.ToInt32(ageCon);


            Console.WriteLine("Have you ever had a DUI? \n Please Answer True or False");
            string duiCon = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiCon);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketCon = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketCon);

            bool qualified = (age > 15 && dui == false && tickets <= 3);
            Console.WriteLine("Qualified? " + qualified);
            Console.ReadLine();

        }
    }
}
