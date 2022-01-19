using System;

namespace Task1
{
    class Program
    {
        static void GiaiPT2(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem!");
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1 = {x1} \nx2 = {x2}");
            }
            else if (d == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep!");
                double x = -b / 2 * a;
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 2!");
            Console.WriteLine("Nhap tham so!");
            string input;

            Console.Write("a = ");
            input = Console.ReadLine();
            double a = double.Parse(input);

            Console.Write("b = ");
            input = Console.ReadLine();
            double b = double.Parse(input);

            Console.Write("c = ");
            input = Console.ReadLine();
            double c = double.Parse(input);

            GiaiPT2(a, b, c);
        }
    }
}
