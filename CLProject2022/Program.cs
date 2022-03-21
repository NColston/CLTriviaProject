using System;
using System.Collections.Generic;

namespace CLProject2022
{
    class Program
    {


        static void Main(string[] args)
        {
            Score userScore = new Score();
            initialize(userScore);
            
            


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
                        PlayGame(userScore);
                        break;
                    case "2":
                        QuitApp();
                        endLoop = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.Clear();
                        break;

                }


            } while (!endLoop); 


        }
        private static void initialize(Score userScore)
        {
            userScore.question1 = " Question 1: \n6 / 3(3+1) \na: 8 \nb: 4 \nc: 1/2 \nd: 2";
            userScore.question2 = " Question 2: \nThe word 'onomatapia' is spelled incorrectly here. Please spell it correctly: ";
            userScore.question3 = " Question 3: \nEnter the Tempurature (F) where Fahrenheit and Celcius are equal: ";
            userScore.question4 = " Question 4: ";
            userScore.question5 = " Question 5: \nName one of the top 10 most popular dog breads;";



        }
        private static double convertTemp(double temp)
        {
           return (temp - 32) * 5 / 9;
        }

        private static void PlayGame(Score userScore)
        {
            Console.Clear();

            //question 1
           
            Console.WriteLine(userScore.question1);
            string answer1 = Console.ReadLine();

            if (answer1 == "a")
            {
                Console.WriteLine("correct!");
                userScore.score ++;
            }
            else
            {
                Console.WriteLine("Wrong!");
               
            }


            Console.ReadKey();
            Console.Clear();

            //question 2
            Console.WriteLine(userScore.question2);
            string answer2 = Console.ReadLine();

            if (answer2 == "onomatopoeia")
            {
                Console.WriteLine("correct!");
                userScore.score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadKey();
            Console.Clear();

            //question 3
            Console.WriteLine(userScore.question3);
            Console.WriteLine("Enter Fahrenheit Temperature:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            double Celsius = convertTemp(Fahrenheit);
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
            double answer3 = -40;

            if (answer3 == Celsius)
            {
                Console.WriteLine("Correct!");
                userScore.score++;
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

            Console.WriteLine(userScore.question4);
            Console.WriteLine("What is the answer to question 1 if you add " + randomNum );
            double answer4 = Convert.ToDouble(Console.ReadLine());
            int correctAnswer4 = 8 + randomNum;

            if (answer4 == correctAnswer4)
            {
                Console.WriteLine("Correct!");
                userScore.score++;
            }
            else
            {
                Console.WriteLine("wrong!");
            }

            Console.ReadKey();
            Console.Clear();

            //question 5
            Dictionary<string, string> dogBreeds = new Dictionary<string, string>();

            dogBreeds.Add("Lab", "#1");
            dogBreeds.Add("Bulldog", "#2");
            dogBreeds.Add("Golden Retriever", "#3");
            dogBreeds.Add("French Bulldog", "#4");
            dogBreeds.Add("German Shepherd", "#5");
            dogBreeds.Add("Poodle", "#6");
            dogBreeds.Add("Beagle", "#7");
            dogBreeds.Add("Yorkshire Terrier", "#8");
            dogBreeds.Add("Rottweiler", "#9");
            dogBreeds.Add("Boxer", "#10");

            Console.WriteLine(userScore.question5);
            string answer5 = Console.ReadLine();

           

            bool keyExists = dogBreeds.ContainsKey(answer5);
            if (keyExists)
            {
                Console.WriteLine("Correct!", answer5);
                userScore.score++;
            }
            else
            {
                Console.WriteLine("Wrong!", answer5);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("your score is " + userScore.score);
            Console.WriteLine("Press any key to return to the Menu");
            Console.ReadKey();
            Console.Clear();
        }

        private static void QuitApp()
        {
            Console.Clear();
            Console.WriteLine("Thanks for Playing");
            Console.ReadKey();
            Console.Clear();
       
            
          
        }

    }

}
            



        
            
            
    

