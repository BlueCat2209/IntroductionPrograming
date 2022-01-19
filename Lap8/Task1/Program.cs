using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            Console.Write("Enter character: ");
            string character = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == character)
                {
                    sum++;
                }
            }
            Console.WriteLine($"The number of times the character \"{character}\" has repeated in the string \"{input}\" is {sum}");
        }
    }
}
