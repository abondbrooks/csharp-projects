﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
