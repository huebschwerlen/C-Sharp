using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoIntParamMethod
{
    public class voidMeth
    {
        public static void mathMeth(int int1 = 2, int int2 = 4)
        {
            int1 = int1 + 50;
            Console.WriteLine(int2);
        }
    }
}
