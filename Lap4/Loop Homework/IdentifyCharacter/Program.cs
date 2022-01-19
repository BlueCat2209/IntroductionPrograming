using System;

namespace IdentifyCharacter
{
    class MyFunction
    {
        internal static bool IsNumber(int charCode)
        {
            if((charCode <= 57)&&(charCode >= 48))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static bool IsAlphabet(int charCode)
        {
            if(((charCode >= 65)&&(charCode <= 90))||((charCode >= 97)&&(charCode <= 122)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input;  
            do
            {
                Console.WriteLine("Indentify Character Program!");
                Console.WriteLine("Enter Space key to end the program!");
                Console.Write("Enter a character: ");
                input = Console.Read(); Console.ReadLine();
                if (MyFunction.IsAlphabet(input))
                {
                    Console.WriteLine("The character you have entered is a Alphabet!");
                }
                else if(MyFunction.IsNumber(input))
                {
                    Console.WriteLine("The character you have entered is a Number!");
                }
                else if(input != 32)
                {
                    Console.WriteLine("The character you have entered is a Special character!");
                }    
                else
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
