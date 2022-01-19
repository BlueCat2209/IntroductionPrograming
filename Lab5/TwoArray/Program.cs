using System;

namespace TwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Two Arrat Program!");
            string input;
            int[] a = new int[10]; float[] b = new float[5];
            // Take a's elements
            Console.WriteLine("=======================");
            Console.WriteLine("Enter an integer array!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"a[{i}] = ");
                input = Console.ReadLine();
                a[i] = int.Parse(input);
            }
            // Take b's elements
            Console.WriteLine("========================");
            Console.WriteLine("Enter a douuble array");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"b[{i}] = ");
                input = Console.ReadLine();
                b[i] = float.Parse(input);
            }
            // Process data
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = 0;
                }
                else
                {
                    int tmp = (int)b[j++];
                    a[i] = tmp;    
                }
            }
            //Print data
            Console.Write($"Array a[]: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            Console.Write($"Array b[]: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{b[i]} ");
            }
        }
    }
}
