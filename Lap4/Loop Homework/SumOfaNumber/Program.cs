﻿using System;

namespace SumOfaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // init data
            Console.WriteLine("Sum of A Number");
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            // Process data
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case '1':
                        sum += 1;
                        break;
                    case '2':
                        sum += 2;
                        break;
                    case '3':
                        sum += 3;
                        break;
                    case '4':
                        sum += 4;
                        break;
                    case '5':
                        sum += 5;
                        break;
                    case '6':
                        sum += 6;
                        break;
                    case '7':
                        sum += 7;
                        break;
                    case '8':
                        sum += 8;
                        break;
                    case '9':
                        sum += 9;
                        break;             
                }
            }
            //Print answer
            Console.WriteLine($"Sum of {input} number is {sum}");
        }
    }
}
