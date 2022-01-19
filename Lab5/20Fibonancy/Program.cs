using System;

namespace _20Fibonancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the first 20 fibonancy number!");
            int[] a = new int[20];
            a[0] = 0; a[1] = 1; 
            for (int i = 2; i < 20; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"fibonancy 1: {a[i]}");
            }
        }
    }
}
