using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[5]; 
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers[1]);
            Console.ReadLine();*/

            // string [] names = new string[] { "AZanae", "Bob", "Jim", "Alex" };

            /*for (int i = 0; i < names.length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();*/

            /*foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/

            string zig = "You can get what you want out of life if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
             
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
