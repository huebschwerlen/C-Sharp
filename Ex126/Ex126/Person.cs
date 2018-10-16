using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex126
{
    public abstract class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() //2. Give it the method SayName().
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        
    }
}
