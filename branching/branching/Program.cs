using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express" +
                ".\nPlease follow the instructions below.");

            Console.WriteLine("Please enter the weight of your package:");
            string pkwWeightCon = Console.ReadLine();
            decimal pkgWeight = Convert.ToDecimal(pkwWeightCon);

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped " +
                  "via Package Express. Have a good day.");
            }

            else
             {
                Console.WriteLine("Please enter the width of your package:");
                string pkgWidthCon = Console.ReadLine();
                decimal pkgWidth = Convert.ToDecimal(pkgWidthCon);

                Console.WriteLine("Please enter the height of your package:");
                string pkgHeightCon = Console.ReadLine();
                decimal pkgHeight = Convert.ToDecimal(pkgHeightCon);

                Console.WriteLine("Please enter the length of your package:");
                string pkgLengthCon = Console.ReadLine();
                decimal pkgLength = Convert.ToDecimal(pkgLengthCon);

                decimal total = pkgWidth + pkgHeight + pkgLength;


                if(total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else
                {
                    decimal quote = total * pkgWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $"
                        + quote);
                }
             }

            
            Console.ReadLine();
        }
    }
}
