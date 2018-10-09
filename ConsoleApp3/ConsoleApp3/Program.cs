using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray0 = { "Sawyer", "Jack", "Kate", "Hugo", "Locke", "Desmund" };
            Console.WriteLine("Choose an index 0 thru 5 to get a name.");
            int indexStr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nameArray0[indexStr]);
            Console.ReadLine();


            int[] numArray = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Choose an index 0 thru 5 to get a number.");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[index]);
            Console.ReadLine();


            List<string> nameLst = new List<string>();
            nameLst.Add("Sayid");
            nameLst.Add("Ben");
            nameLst.Add("Charlie");
            nameLst.Add("Jacob");
            nameLst.Add("Claire");
            nameLst.Add("Juliet");
            Console.WriteLine("Choose a number 0 thru 5 to get a name.");
            int lstName = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nameLst[lstName]);
            Console.ReadLine();
        }
    }
}
