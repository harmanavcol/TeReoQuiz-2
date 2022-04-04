using System;

namespace MaoriQuiz
{
    class Program
    {
        static void correctans()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongrats, that is correct!");
            Console.ResetColor();
        }
        static void wrongans()
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

            switch(choice)
            {
                case 'Y': easy();
                    break;
                case 'N': hard();
                    break;
                default: easy();
                    break;
            }

            static void easy()
            {
                int score = 0;
                Console.WriteLine("\nQUESTION 1: \n\nWhat is the Maori word for hello? \n\nA) Ka Pai \nB) Kapa haka \nC) Kia ora\n");
                char ans1 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans1 == 'C')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }

                Console.WriteLine("\nQUESTION 2: \n\nWhat is the English phrase for Morena? \n\nA) Good morning \nB) Good afternoon \nC) Good evening\n");
                char ans2 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans2 == 'A')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }

                Console.WriteLine("\nQUESTION 3: \n\nWhat is the Maori term for performing arts? \n\nA) Kapa haka \nB) Korare \nC) Kaumatua");
                char ans3 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans3 == 'A')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                Console.WriteLine("\nQUESTION 4: \n\nMatariki can be best described as... \n\nA) The Maori term for the Pleiades star cluster \nB) The beginning of the Maori New Year \nC) A celebration akin to Christmas");
                char ans4 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans4 == 'C')
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                Console.WriteLine("\nQUESTION 5: \n\nWhat is the Maori term for kanoe? \n\nA) Whaka \nB) Raka \nC) Waka");
                char ans5 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans5 == 'C')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                } else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                Console.WriteLine("\nQUESTION 6: \n\nWhat is the English equivalent of Aoteaora? \n\nA) The Pacific Ocean \nB) New Zealand \nC) Atlantis");
                char ans6 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans6 == 'B')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                } else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                Console.WriteLine("\nQUESTION 7: \n\nWhat day is rapare? \n\nA) Thursday \nB) Friday \nC) Saturday");
                char ans7 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans7 == 'A')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                } else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                // Trick question:
                Console.WriteLine("\nFINAL QUESTION: \n\nWhat day follows rapare? \n\nA) Mane \nB) Paraire \nC) Ratapu");
                char ans8 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans8 == 'B')
                {
                    correctans();
                    score++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                } else
                {
                    wrongans();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                if (score <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSorry, your score of " + score + " does not qualify as a passing score. Do you wish to have another go at this quiz? \nIf so, please type Y and press ENTER. If not, please type N and press ENTER to exit.");
                    Console.ResetColor();
                    char choice2 = Convert.ToChar(Console.ReadLine().ToUpper());
                    Console.Clear();
                    while (choice2 == 'Y')
                    {
                        easy();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCongratulations! You have passed Harman Singh's multiple choice Te Reo Maori quiz with a score of " + score + "!\nDo you wish to try more advanced questions? \nIf so, please type Y and press ENTER. If not, please type N and press ENTER to leave.");
                    Console.ResetColor();
                    char choice3 = Convert.ToChar(Console.ReadLine().ToUpper());
                    Console.Clear();
                    while (choice3 == 'Y')
                    {
                        hard();
                    }
                }
                {
                }
                {
                }
            }
            static void hard()
            {
                int score = 0;
                Console.WriteLine("\nQUESTION 1: \n\nA) ... \nB) ... \nC) ...");
                char ans1 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans1 == 'B')
                {
                    correctans();
                    score = score + 5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                } else
                {
                    wrongans();
                    score = score - 5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                Console.WriteLine("\nQUESTION 2: \n\nA) ... \nB) ... \nC) ...");
                char ans2 = Convert.ToChar(Console.ReadLine().ToUpper());
                if (ans2 == 'A')
                {
                    correctans();
                    score = score + 5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
                else
                {
                    wrongans();
                    score = score - 5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have a total of " + score + " points.");
                    Console.ResetColor();
                }
            }
        }
    }
}