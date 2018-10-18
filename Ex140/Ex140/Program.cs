using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex140
{
    class Program
    {
        /*
         1. In the Main() method, create a list of 
         at least 10 employees. Each employee should 
         have a first and last name, as well as an Id. 
         At least two employees should have the first name "Joe".
         */

        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Employee employee1 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Walsh",
                Id = 1
            };
            employeeList.Add(employee1);

            Employee employee2 = new Employee()
            {
                FirstName = "Misty",
                LastName = "Waters",
                Id = 2
            };
            employeeList.Add(employee2);

            Employee employee3 = new Employee()
            {
                FirstName = "Michelle",
                LastName = "Branch",
                Id = 3
            };
            employeeList.Add(employee3);

            Employee employee4 = new Employee()
            {
                FirstName = "Nancy",
                LastName = "Drew",
                Id = 4
            };
            employeeList.Add(employee4);

            Employee employee5 = new Employee()
            {
                FirstName = "Nina",
                LastName = "Simone",
                Id = 5
            };
            employeeList.Add(employee5);

            Employee employee6 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Macintosh",
                Id = 6
            };
            employeeList.Add(employee6);

            Employee employee7 = new Employee()
            {
                FirstName = "Mazzy",
                LastName = "Star",
                Id = 7
            };
            employeeList.Add(employee7);

            Employee employee8 = new Employee()
            {
                FirstName = "Tye",
                LastName = "Noon",
                Id = 8
            };
            employeeList.Add(employee8);

            Employee employee9 = new Employee()
            {
                FirstName = "Jame",
                LastName = "Walsh",
                Id = 9
              
            };
            employeeList.Add(employee9);

            Employee employee10 = new Employee()
            {
                FirstName = "Joe",
                LastName = "Young",
                Id = 10
            };
            employeeList.Add(employee10);

            //3. Do the same thing again, but this time with a lambda expression.
            List<Employee> joeList = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".
            //List<Employee> joeList = new List<Employee>();

            //foreach (Employee employee in employeeList)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        joeList.Add(employee);
            //    }
            //}


            foreach (Employee joe in joeList)
            {
                Console.WriteLine(joe.LastName);
            }
            
            Console.ReadLine();

            //4. Using a lambda expression, make a list of 
            //all employees with an Id number greater than 5.
            List<Employee> big5 = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee id in big5)
            {
                Console.WriteLine(id.Id);
            }

            Console.ReadLine();
        }
    }
}
