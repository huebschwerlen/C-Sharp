using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex126
{
    /*
     2. Have your Employee class from the previous 
     drill inherit that interface and implement 
     the Quit() method in any way you choose.
     */
    public class Employee : Person, IQuittable
    {
        
        public int Id { get; set; }

        void SayName()
        {

        }

        public void Quit()
        {
            Console.WriteLine("I QUIT");
        }

    }
}
