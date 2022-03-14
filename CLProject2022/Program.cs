using System;

namespace CLProject2022
{
    class Program
    {


        static void Main(string[] args)
        {

            bool endLoop = false;
            do
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
                        endLoop = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;

                }


            } while (!endLoop); 


        }

        private static void PlayGame()
        {
            Console.Clear();

            //question 1
            Console.WriteLine(" Question 1: ");
            Console.WriteLine(" 6 / 3(3+1)");
            Console.WriteLine("a: 8");
            Console.WriteLine("b: 4");
            Console.WriteLine("c: 1/2");
            Console.WriteLine("d: 2");
            string answer1 = Console.ReadLine();

            if (answer1 == "a")
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }


            Console.ReadKey();
            Console.Clear();

            //question 2
            Console.WriteLine("Question 2: ");
            Console.WriteLine("The word 'onomatapia' is spelled incorrectly here. Please spell it correctly: ");
            string answer2 = Console.ReadLine();

            if (answer2 == "onomatopoeia")
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadKey();
            Console.Clear();

            //question 3
            Console.WriteLine("Question 3: ");
            Console.WriteLine("Enter the Tempurature (F) where Fahrenheit and Celcius are equal: ");
            
     
            Console.WriteLine("Enter Fahrenheit Temperature:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
            double answer3 = -40;

            if (answer3 == Celsius)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadKey();
            Console.Clear();

            //question 4
            Random rd = new Random();
            int randomNum = rd.Next(1, 9);

            Console.WriteLine("Question 4: ");
            Console.WriteLine("What is the answer to question 1 if you add " + randomNum );
            double answer4 = Convert.ToDouble(Console.ReadLine());
            int correctAnswer4 = 8 + randomNum;

            if (answer4 == correctAnswer4)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }

            Console.ReadKey();
            Console.Clear();

            //question 5
            Console.WriteLine("Question 5: ");
            Console.WriteLine("Name one of the top 10 most popular dog breads");
            



        }

        private static void QuitApp()
        {
            Console.Clear();
            Console.WriteLine("Thanks for Playing");
            Console.ReadKey();
            Console.Clear();
       
            //show score somehow
          
        }

    }

}
            



        
            
            
    

