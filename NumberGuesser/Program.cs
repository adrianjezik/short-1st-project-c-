using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
          
            GetAppInfo();
            string userName = GetUserName();
            GreetUser(userName);

            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            bool correctAnswer = false;
            Console.WriteLine("Guess the number from 1 to 10");

            while(!correctAnswer)
            {
                string input = Console.ReadLine();

                int guess;
                bool isNumber = int.TryParse(input, out guess);

                if(!isNumber)
                {
                    PrintColorMessage(ConsoleColor.Green, "Please, type your number(1 - 10)");
                    continue;

                }
                if(guess <1 || guess>10)
                {
                    PrintColorMessage(ConsoleColor.Red, "Bad number, please typu number from 1 to 10");
                    continue;
                }
                if(guess < correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Bad answear, the following number is bigger");
                }
                else if(guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Blue, "Bad answear, the following number is smaller");
                }
                else 
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Congratulations!, Your number is correct!");
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = " Guess which number ";
            int appVersion = 1;
            string appAuthor = " Adriano Jezik";

            string info = ($"{appName} Version -  0.{appVersion } Credits :{appAuthor}");

            PrintColorMessage(ConsoleColor.Yellow,info);
        }
        static void GreetUser(string userName)
        {
            
            
            string greet = ($"Good luck {userName} and score fast as it is possible! :D");
            PrintColorMessage(ConsoleColor.Blue, greet);
        }


        static string GetUserName()
        {
            Console.WriteLine(" What is your name?");

            string inputUserName = Console.ReadLine();

            return inputUserName;

        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
