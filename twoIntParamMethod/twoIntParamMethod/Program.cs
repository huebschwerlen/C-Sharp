using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoIntParamMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMeth math1 = new voidMeth();
            {
                voidMeth.mathMeth(int1: 2, int2: 3);
            }
            Console.WriteLine();
            Console.ReadLine();


            //voidMeth math2 = new voidMeth(int int1 = 2, int int2 = 3);
            //{
            //    voidMeth.mathMeth("int1 = {0}, int2 = {1}", int1, int2);
            //}
            //Console.WriteLine();
            //Console.ReadLine();



        }
    }
}
