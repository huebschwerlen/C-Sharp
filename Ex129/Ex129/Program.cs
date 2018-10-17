using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 28 };
            employee.SayName();
            Console.ReadLine();

          
            IQuittable employeeQuit = new Employee();
            employeeQuit.Quit();
            Console.ReadLine();

            Employee employee1 = new Employee() { FirstName = "Jared", LastName = "Junior", Id = 28 };
            
           

            if (employee == employee1)
                Console.WriteLine("IDs are equal.");
            else
                Console.WriteLine("IDs are not equal.");
            Console.ReadLine();



        }
    }
}
