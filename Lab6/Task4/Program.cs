using System;

namespace Task4
{
    class Program
    {
        static char transfer(double n)
        {
            if (n >= 8.5)
            {
                return 'A';
            }
            else if (n >= 7)
            {
                return 'B';
            }
            else if (n >= 5.5)
            {
                return 'C';
            }
            else if (n >= 4)
            {
                return 'D';
            }
            else if (n >= 0)
            {
                return 'F';
            }
            else return 'E';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Chuyen diem so thanh diem chu!");
            string input;

            Console.Write("Nhap diem so: ");
            input = Console.ReadLine();
            double n = double.Parse(input);

            Console.WriteLine($"Diem so chuyen doi: {transfer(n)}");
        }
    }
}
