using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main()
        {

            const string string1 = "Welcome";
            const string string2 = " to the Thunder Dome!";

            var strings = new MessageBuilder(string1, string2);

            strings.DisplayMessage();
            Console.ReadLine();
        }
    }
    class MessageBuilder
    {
        public MessageBuilder(string newString1) : this(newString1, "") { }
        public MessageBuilder(string newString1, string newString2)
        {
            fullString = newString1 + newString2;
        }
        public string fullString { get; set; }
        public void DisplayMessage()
        {
            Console.WriteLine(fullString);
        }
    }
}
