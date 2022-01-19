using System;

namespace Task5
{
    class Program
    {
        static bool checkNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra so hoan thien trong mang!");
            Console.WriteLine("Enter A[]: ");
            string input;
            int[] number = new int[10];
            bool[] isNum = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"A[{i}] = ");
                input = Console.ReadLine();
                number[i] = int.Parse(input);
                if (checkNumber(number[i]))
                {
                    isNum[i] = true;
                }
                else isNum[i] = false;
            }

            Console.Write("So nguyen to la: ");
            for (int i = 0; i < 10; i++)
            {
                if (isNum[i])
                {
                    Console.Write($"{number[i]} ");
                }
            }
        }
    }
}
