using System;

namespace CountMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // start
            Console.WriteLine("Count_Min_Max Program");
            // take input
            Console.WriteLine("Type input");
            string input;
            int[] a = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"a[{i}] = ");
                input = Console.ReadLine();
                a[i] = int.Parse(input);
            }
            // process data
            int max = a[0]; int cmax = 1;
            int min = a[0]; int cmin = 1;
            for(int i = 1; i< 10; i++)
            {
                // Process max
                if (max < a[i])
                {
                    max = a[i];
                    cmax = 1;
                }
                else if (max == a[i]) cmax++;

                //Process min
                if (min > a[i])
                {
                    min = a[i];
                    cmin = 1;
                }
                else if (min == a[i]) cmin++;
            }

            // Print answers
            Console.WriteLine($"{max} is the max value of the array and it has been repeated {cmax} times");
            Console.WriteLine($"{min} is the min value of the array and it has been repeated {cmin} times");
        }
    }
}
