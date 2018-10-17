using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex129
{
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

        public static bool operator ==(Employee id1, Employee id2)
        {
            bool status = false;
            if (id1.Id == id2.Id)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Employee id1, Employee id2)
        {
            bool status = false;
            if (id1.Id == id2.Id)
            {
                status = true;
            }
            return status;
        }
    }
}