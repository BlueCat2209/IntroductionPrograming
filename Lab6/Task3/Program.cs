using System;

namespace Task3
{
    class Program
    {
        static int Fibo(int n)
        {
            if (n == 1) { return 0; }
            else if (n == 2) { return 1; }
            else
            {
                int[] Fibo = new int[n + 1];
                Fibo[1] = 0; Fibo[2] = 1;
                for (int i = 3; i <= n; i++)
                {
                    Fibo[i] = Fibo[i - 2] + Fibo[i - 1];
                }
                return Fibo[n];
            }      
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh so Fibonacy thu n"!);
            string input;

            Console.Write("Nhap n = ");
            input = Console.ReadLine();
            int n = int.Parse(input);

            Console.Write($"So Fibonancy thu {n} la {Fibo(n)}");
        }
    }
}
