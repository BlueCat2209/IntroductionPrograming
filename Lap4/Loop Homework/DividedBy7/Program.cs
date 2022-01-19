using System;

namespace DividedBy7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int m; int n;
            do
            {
                Console.Clear();
                Console.WriteLine("Divided By 7!");

                Console.Write("Enter m = ");
                input = Console.ReadLine();
                m = int.Parse(input);

                Console.Write("Enter n = ");
                input = Console.ReadLine();
                n = int.Parse(input);
            } while ((n <= 0) || (m <= 0));
            if(n < m)
            {
                int t = n;
                n = m;
                m = t;
            }
            Console.WriteLine($"Trong khoang {m}, {n} co nhung so chia het cho 7 sau!");
            for(var i = m; i <= n; i++)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine($"{i} chia het cho 7!");
                }
            }
            Console.ReadKey();
        }
    }
}
