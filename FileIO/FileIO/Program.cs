using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number: ");// 1.Ask a user for a number.
            string response = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Student\logs\log.txt", response);//2. Log that number to a text file.
            //@ symbol says to read file path literally,not using '\' as escape chars, if we omitted the '@' we'd need to double up on '\\'

            response = File.ReadAllText(@"C:\Users\Student\logs\log.txt");//3. Print the text file back to the user.
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
