using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreMethods
{
    public class mathOp
    {
        /* 
         1. Create a class. In that class, 
         create a method that will take in an integer, 
         do a math operation to it and then 
         return the answer as an integer.
         */

        public int methOne(int firstNum)
        {
            int intInput;
            intInput = firstNum + 10;
            return intInput;

        }


        /*
        3. Add a second method to the class, 
        with the same name, that will take in a decimal, 
        do a different math operation to it 
        and then return the answer as an integer.
        */

        public int methOne(decimal decNum)
        {
            int decInput;
            decInput = (int)decNum * 20;
            return decInput;

        }


        /*
         5. Add a third method to the class, 
         with the same name, that will take in a string, 
         convert it to an integer if possible, 
         do a different math operation to it and 
         then return the answer as an integer.
         */

        public int methOne(string stringIn)
        {
            int stringNum = System.Convert.ToInt32(stringIn);
            int outStringNum = stringNum - 1;
            return outStringNum;
            
        }

    }
}
