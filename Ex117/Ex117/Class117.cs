using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex117
{
    public class Class117
    {
        //1.create void method that outputs an integer.
        public void Method117(int inInt, out int outInt) //4.create a method with output parameters.
        {
            outInt = inInt / 2; //have the method divide the data passed to it by 2.
        }

        //5.overlaod a method
        public static int Method117(int inInt1) //6.declare a class to be static.
        {
            int outInt1 = inInt1 / 2;
            
            Console.WriteLine(outInt1);
            return outInt1;
        }
    }
}
