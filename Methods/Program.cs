﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2 (int number1, int number2)
        { 
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2) 
        {
            return number1 + number2;
        }
    }
}
