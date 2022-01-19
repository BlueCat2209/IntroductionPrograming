using System;

namespace PrintEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Even Position Program!");
            Console.WriteLine("Enter array!");
            // Init data
            string input;
            int[] a = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"a[{i}] = ");
                input = Console.ReadLine();
                a[i] = int.Parse(input);
            }

            // Print answers
            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
            Console.ReadKey();
        }
    }
}
