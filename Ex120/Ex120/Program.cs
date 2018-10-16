using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex120
{
    class Program
    {
        /*
         4. Inside of the Main method, instantiate 
         and initialize an Employee object with a first 
         name of "Sample" and a last name of "Student".
         */
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName(); //5. Call the superclass method SayName() on the Employee object.
            Console.ReadLine();
        }
       
    }
    
}
