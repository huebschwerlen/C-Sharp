using System;


namespace dailyReports
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("\n");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("What course are you on?");
            string whatCourse = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("\n");

            Console.WriteLine("Do you need help with anything?" + "\n" + "Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool helpStat = bool.Parse(needHelp);

            Console.WriteLine("\n");

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posPerience = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("How many number hours did you study today?");
            string numHours = Console.ReadLine();
            int hrNums = Convert.ToInt32(numHours);

            Console.WriteLine("\n");
            
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly." +
               "\n" + "Have a great day!");
            Console.ReadLine();



            //Console.WriteLine(whatCourse + " " + pgNum + " " + 
            //    helpStat + " " + posPerience + " " + otherFeedback + " " +
            //    hrNums);
            //Console.ReadLine();

         
        }
    }
}
