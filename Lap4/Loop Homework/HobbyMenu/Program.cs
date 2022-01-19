using System;

namespace HobbyMenu
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Process data and Print answer
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("CHOOSE YOUR HOBBY!");
                Console.WriteLine("==================");
                Console.WriteLine("1. Read Books");
                Console.WriteLine("2. Listen to musics");
                Console.WriteLine("3. Play sports");
                Console.WriteLine("4. Computer");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==================");

                // init data
                string input;
                Console.Write("Choose: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("You like reading books!");
                        break;
                    case "2":
                        Console.WriteLine("You like listenning to musics!");
                        break;
                    case "3":
                        Console.WriteLine("You like playing sports!");
                        break;
                    case "4":
                        Console.WriteLine("You like computer!");
                        break;
                    case "5":
                        Console.WriteLine("The Program will stop after you press any key!");
                        isRunning = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
