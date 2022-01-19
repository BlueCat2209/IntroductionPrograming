using System;

namespace Task2
{
    class Program
    {
        static int power(int a, int n)
        {
            int ans = (int) Math.Pow(a, n);
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh a mu n!");
            string input;

            Console.Write("Nhap a = ");
            input = Console.ReadLine();
            int a = int.Parse(input);

            Console.Write("Nhap n = ");
            input = Console.ReadLine();
            int n = int.Parse(input);

            Console.WriteLine($"Ket qua la {power(a, n)}");
        }
    }
}
