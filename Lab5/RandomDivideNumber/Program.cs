using System;

namespace RandomDivideNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random divide number Program!");
            string input;

            Console.Write("Enter X = ");
            input = Console.ReadLine();
            int x = int.Parse(input);

            Console.Write("Divide to X: ");
            int[] a = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                a[i] = random.Next(1, 1000);
                if (a[i] % x == 0)
                {
                    Console.Write($"{a[i]} ");
                }
            }

        }
    }
}
