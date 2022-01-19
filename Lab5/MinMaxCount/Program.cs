using System;

namespace MinMaxCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Min Max Program!");

            string input;
            int[] a = new int[10];
            Console.WriteLine("Enter array A[]!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"A[{i}] = ");
                input = Console.ReadLine();
                a[i] = int.Parse(input);
            }

            int min = a[0]; int cMin = 1;
            int max = a[0]; int cMax = 1;
            for (int i = 1; i < 10; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    cMin = 1;
                } else if (a[i] == min) cMin++;
                if (a[i] > max)
                {
                    max = a[i];
                    cMax = 1;
                }
                else if (a[i] == max) cMax++;
            }

            Console.WriteLine("===============");
            Console.WriteLine($"The max value is {max} that has been repeated {cMax} times");
            Console.WriteLine($"The min value is {min} that has been repeated {cMin} times");
        }
    }
}
