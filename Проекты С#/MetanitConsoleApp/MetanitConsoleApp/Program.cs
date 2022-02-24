using System;

namespace MetanitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Game newGame = new Game();

            while(true)
            {
                Console.WriteLine("Хотите начать новую игру: Y/N?");
                choice = Console.ReadLine();

                if(char.TryParse(choice, out char result))
                {
                    if (result == 'Y' || result == 'y')
                    {
                        newGame.NewGame();
                    }
                    else if (result == 'N' || result == 'n')
                    { 
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            Console.WriteLine("Please, press any key for exit.");

            Console.ReadKey();
        }
    }
}
