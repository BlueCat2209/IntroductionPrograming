using System;

namespace FindEqualNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding X position Program!");
            string input; int ans = 0;
            bool isFound = false;
            int[] a = new int[10];
            int countX = 0;

            Console.Write("Enter X = ");
            input = Console.ReadLine();
            int x = int.Parse(input);

            Console.WriteLine("Enter array A[]");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"A[{i}] = ");
                input = Console.ReadLine();
                a[i] = int.Parse(input);
                if ((a[i] == x)&&!(isFound))
                {
                    ans = i;
                    isFound = true;
                }
                if((a[i] == x)&&(isFound))
                {
                    countX++;
                }
            }
            Console.WriteLine($"The first position of {x} in the A[] array is {ans+1} and {x} has been repeated {countX} times");
        }
    }
}
