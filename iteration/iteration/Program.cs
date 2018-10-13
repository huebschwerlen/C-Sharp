using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //create one dimensional array of strings
            string[] names = { "rosencrantz", "guildenstern", "vladimir", "estragon"};

            //prompt user to input a name
            Console.WriteLine("Please enter some text: ");

            //prompt user to input 'some text'
            string someTxt = Console.ReadLine();

            
            //loop through array and add 'some text' to the end of each string
            //loop through array and print out each string on a separate line
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + " " + someTxt;

                Console.WriteLine(names[i]);

            }
            Console.ReadLine();


            //infinite loop
            //bool awesome = false;
            //while (!awesome)
            //{
            //    Console.WriteLine("AweSam");
            //}


            //infinite loop fixed
            bool awesome = false;
            while (!awesome)
            {
                Console.WriteLine("AweSam");
                awesome = true;
                break;
            }
            Console.ReadLine();


            //create one dimensional array of strings
            string[] names1 = { "cindy", "bobby", "jan", "peter", "marcia", "greg" };

            //iterate thru loop using "<" operator
            for (int j = 0; j < names1.Length; j++)
            {
                Console.WriteLine(names1[j]);
            }
            Console.ReadLine();


            //create one dimensional array 
            int[] testscores = { 60, 70, 80, 90, 100, 95, 85, 75, 65 };

            //iterate thru loop using "<=" operator
            for (int k = 0; k <= 8; k++)
            {
                if (testscores[k] <= 70)
                {
                    Console.WriteLine("Failing scores: " + testscores[k]);
                }

                else if (testscores[k] > 70)
                {
                    Console.WriteLine("Passing scores: " + testscores[k]);
                }
            }
            Console.ReadLine();
            
            
            //create a list of strings where each item is unique
            List<string> names3 = new List<string>() { "lynne", "orbison", "petty", "harrison", "dylan" };



            //ask user to select text to search for in the list
            Console.WriteLine("Please type one of the following names: \nlynne, orbison, petty, harrison, dylan");

            //create loop that iterates thru loop and displays index of array that contains matching input text
            bool running = true;
            do
            {
                
                string nameInput = Console.ReadLine();
                

                foreach (string name3 in names3)
                {
                    if (nameInput == name3)
                    {
                        Console.WriteLine(names3.IndexOf(name3));
                        
                        running = false;
                        break;
                    }
                    
                }
                if (running)
                {
                    Console.WriteLine("Name not found in list. Please try again.");
                    
                }
            } 
            while (running); //add code that stops loop from executing once a match has been found
            Console.ReadLine();



            

            //create a list of strings where there are duplicate strings
            List<string> robLowe = new List<string>() { "how", "many", "lowes", "would", "rob", "lowe", "rob", "if", "rob", "lowe", "could", "rob", "lowes"};

            //ask user to select text to search for in the list
            Console.WriteLine("Please type the name rob or lowe");
            string loweInput = Console.ReadLine();

            //create loop that iterates thru loop and displays index of array that contains matching input text

            // StringBuilder tempFound = new StringBuilder();
            string tempFound = ("");
            
                for (int n = 0; n < robLowe.Count; n++)
                    
                {

              


                if (robLowe[n] == loweInput)
                {
                    //Console.WriteLine(loweInput + " Was found at index: " + n);
                    tempFound = tempFound + n + ", ";
                    //tempFound.Append(n + ", ");
                }

                //else
                //{
                //    Console.WriteLine(loweInput + " Was not found at index: " + n);
                //}
                    
                }
                Console.WriteLine("Matches found at " + tempFound);
                Console.ReadLine();
          
    


            //create a list of strings where there are duplicate strings
            List<string> stringList = new List<string>() { "how", "many", "lowes", "would", "rob", "lowe", "rob", "if", "rob", "lowe", "could", "rob", "lowes" };
           
            //creat loop to iterate thru stringList
            foreach (string value in stringList)
            {

                Console.WriteLine(value);

                //create new list to add duplicate strings to
                List<string> newList = new List<string>();

                //create for loop to iterate thru stringList and add a duplicate value from stringList to newList
                for (int p = 0; p < stringList.Count; p++)
                {
                    if (stringList[p] == value)
                    {
                        newList.Add(value);
                    }

                }

                //create if statement to check to see if a value has been adde to the new list
                if (newList.Count > 1)
                {
                    Console.WriteLine("This is a duplicate.");
                }

                Console.ReadLine();
            }
           
        }


    }
}
