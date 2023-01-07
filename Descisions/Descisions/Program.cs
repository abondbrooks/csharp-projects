using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           Console.WriteLine("Bob's Big Giveaway");
                        Console.Write("Choose a door: 1, 2 or 3: ");
                        string userValue= Console.ReadLine();

                        string message;

                        if (userValue == "1")
                            message = "You won a car!";
                        else if(userValue == "2")
                            message = "You won a dog.";
                        else if (userValue == "3")
                            message = "You won a boat.";
                        else
                            message = "Sorry we don't understand. You Lose.";

                        Console.WriteLine(message);
                        Console.ReadLine();*/

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

/*            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");*/

            Console.WriteLine($"You entered {userValue}, therefore you won a {message}.");
            Console.ReadLine();

        }
    }
}
