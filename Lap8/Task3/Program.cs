using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            
            int i = 0; int j = input.Length - 1;
            switch ((int)input[j])
            {
                case 33:
                case 44:
                case 46:
                case 59:
                case 63:
                    input = input.Remove(j, 1);
                    j--;
                    break;
            }

            bool isPalindrome = true;
            while (i < j)
            {
                if (input[i] != input[j])
                {
                    isPalindrome = false;
                    break;
                }
                i++; j--;
            }
            if (isPalindrome)
            {
                Console.WriteLine("This string is a Palindrome string!");
            }
            else
            {
                Console.WriteLine("This string is not a Palindrome string!");
            }            
        }
    }
}
