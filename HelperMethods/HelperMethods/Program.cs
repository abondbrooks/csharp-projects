using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("What's city are you from? ");
            string city = Console.ReadLine();


            DisplayResult(firstName, lastName, city);
            Console.ReadLine();
        }

        private static void ReverseString(string message) 
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach(char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
        private static void DisplayResult(string rFirstName, string rLastName, string rCity)
        {
            Console.Write("Results: ");

            ReverseString(rFirstName);
            ReverseString(rLastName);
            ReverseString(rCity);
        }
    }
}
