using System;

namespace MaoriQuiz
{
    class Program
    {
        static void correctanseasy()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongrats, that is correct!");
            Console.ResetColor();
        }
        static void wronganseasy()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSorry, that is incorrect.");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello and welcome to Harman Singh's multiple choice Te Reo Maori quiz! \nWhen asked a question, you must type A, B or C and then press ENTER. \n\nAre you a beginner to Maori? if so, type Y and press ENTER. If not, type N and press ENTER.");
            Console.ResetColor();
            char choice = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Clear();

            if (choice == 'Y')
            {
                easy();
            }

            static void easy()
            {
                int score = 0;
                Console.WriteLine("\nQUESTION 1: \n\nWhat is the Maori word for hello? \n\nA) Ka Pai \nB) Kapa haka \nC) Kia ora\n");
                char ans1 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans1 == 'C')
                {
                    correctanseasy();
                    score = score + 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    wronganseasy();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }

                Console.WriteLine("\nQUESTION 2: \n\nWhat is the Maori word for good morning? \n\nA) Māmāngi \nB) Mōrena \nC) Matariki\n");
                char ans2 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans2 == 'B')
                {
                    correctanseasy();
                    score = score + 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    wronganseasy();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
            }
        }
    }
}