using System;

namespace CLProject2022
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.WriteLine("**  Super Trivia Game (Very Fun) **");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***********************************");
            Console.WriteLine("**********     MENU     ***********");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Quit");

            var userSelection = Console.ReadLine();

            

            switch (userSelection)
            {
                case "1":
                    PlayGame();
                    break;
                case "2":
                    QuitApp();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;

            }
            while (userSelection == "2") ;

            Console.WriteLine("Thanks for using the application");
            Console.Read();

        }

        private static void PlayGame()
        {
            throw new NotImplementedException();
        }

        private static void QuitApp()
        {
            throw new NotImplementedException();
        }

    }
   
}
            


        
            
            
    

