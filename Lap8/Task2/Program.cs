using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string input = Console.ReadLine();

            int wordNum = 0;
            int vowelNum = 0; int consonantNum = 0;
            bool pass = false; bool curr = false;
            for (int i = 0; i < input.Length; i++)
            {
                pass = curr;
                if (input[i] != ' ')
                {
                    curr = true;
                    switch ((int)input[i])
                    {
                        case 65:
                        case 69:
                        case 73:
                        case 79:
                        case 85:
                        case 89:
                        case 97:
                        case 101:
                        case 105:
                        case 111:
                        case 117:
                        case 121:
                            vowelNum++;
                            break;
                        default:
                            consonantNum++;
                            break;
                    }
                }
                else
                {
                    curr = false;
                }
                if ((curr == true)&(pass == false))
                {
                    wordNum++;
                }
            }
            Console.WriteLine($"The number of character in this string is {input.Length}");
            Console.WriteLine($"The number of vowels in this string is {vowelNum}");
            Console.WriteLine($"The number of consonants in this string is {consonantNum}");
            Console.WriteLine($"The number of words in this string is {wordNum}");
        }
    }
}
