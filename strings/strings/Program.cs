using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string my = "My name is ";
            string feeling = " and I'm feeling good.";
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(my + name + feeling);
            Console.ReadLine();

            Console.WriteLine("Type in your favorite expression of exclamation!");
            string exp = Console.ReadLine();
            exp = exp.ToUpper();
            Console.WriteLine(exp + "!" + "\n That's cool!");
            Console.ReadLine();

            StringBuilder para = new StringBuilder();
            para.Append("It was the best of times, it was the worst of times,\n");
            para.Append("it was the age of wisdom, it was the age of foolishness,\n");
            para.Append("it was the epoch of belief, it was the epoch of incredulity,\n");
            para.Append("it was the season of Light, it was the season of Darkness,\n");
            para.Append("it was the spring of hope, it was the winter of despair, \n");
            para.Append("we had everything before us, we had nothing before us,\n");
            para.Append("we were all going direct to Heaven, we were all going direct the other way –\n");
            para.Append("in short, the period was so far like the present period, that some of its noisiest " +
                "\nauthorities insisted on its being received, for good or for evil, in the superlative degree of comparison only.");

            Console.WriteLine(para);
            Console.ReadLine();


        }

   
    }
}
