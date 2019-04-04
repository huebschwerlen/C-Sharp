using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousIncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string p1_hourlyRate = Console.ReadLine();
            double p1_hrRate = Convert.ToDouble(p1_hourlyRate);
            Console.WriteLine("How many hours did you work this week?");
            string p1_hoursWorked = Console.ReadLine();
            int p1_hrWorked = Convert.ToInt32(p1_hoursWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string p2_hourlyRate = Console.ReadLine();
            double p2_hrRate = Convert.ToDouble(p2_hourlyRate);
            Console.WriteLine("How many hours did you work this week?");
            string p2_hoursWorked = Console.ReadLine();
            int p2_hrWorked = Convert.ToInt32(p2_hoursWorked);
            Console.ReadLine();


            double p1_annualSal = p1_hrRate * p1_hrWorked * 52.18; 
            Console.WriteLine("Annual Salary of Person 1: " + p1_annualSal);
            Console.ReadLine();

            double p2_annualSal = p2_hrRate * p2_hrWorked * 52.18;
            Console.WriteLine("Annual Salary of Person 2: " + p2_annualSal);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = p1_annualSal > p2_annualSal;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();
        }
    }
}
