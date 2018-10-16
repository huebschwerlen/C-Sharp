using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex126
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();

            /*
             3. Use polymorphism to create an object
             of type IQuittable and call the Quit() method on it.
             */

            IQuittable employeeQuit = new Employee();
            employeeQuit.Quit();
            Console.ReadLine();

        }
    }
}
