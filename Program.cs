/* This program is a Te Reo Maori quiz written by Harman Singh.

Start
Ask user if they are a beginner
If they enter Y, go to the easy method
If they enter N, go to the hard method
After finishing the easy set of questions, check whether the user's score is less than or equal to 3
IF so, ask user if they want to try the easy questions again or end the program
WHILE they enter Y, go back to the start of the easy method
ELSE, if the user's score is equal to or more than 4, ask user if they want to try hard questions or end the program
WHILE they enter Y, go to the hard method
After finishing the hard set of questions, check whether the user's score is less than or equal to 9
IF so, ask user if they want to try the easy questions of end the program
WHILE they enter Y, go back to the easy method
ELSE, if the user's score is equal to or more than 10, congratulate the user and end the program
End

*/
using System;

namespace MaoriQuiz
{
    class Program
    {
        static void correctAns() // Contains the message displayed for correct answers.
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongrats, that is correct!");
            Console.ResetColor();
        }
        static void wrongAns() // Contains the message displayed for wrong answers.
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSorry, that is incorrect.");
            Console.ResetColor();
        }
        static void invalidAns()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("\nSorry, that is not a valid input. Please type A, B or C and then press ENTER");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {

            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Changes text colour.
                Console.WriteLine("Hello and welcome to Harman Singh's multiple choice Te Reo Maori quiz! \nWhen asked a question, you must type A, B or C and then press ENTER. \n\nAre you a beginner to Maori? if so, type Y and press ENTER. If not, type N and press ENTER.");
                Console.ResetColor(); // Resets the text colour to white.
                string choice = Console.ReadLine().ToUpper();


                switch (choice)
                {
                    case "Y":
                            easy(); // Goes to easy set of questions.
                            break;
                    case "N":
                            hard(); // Goes to hard set of questions.
                            break;
                    default:
                           Console.WriteLine("\nSorry, that is an invalid input. Please type either Y or N and then press ENTER\n");
                           continue;
                }
                break;
            } 

            static void easy() // Easy questions.
            {
                int score = 0;
                while (true)
            { 
                Console.WriteLine("\nQUESTION 1: \n\nWhat is the Maori word for hello? \n\nA) Ka Pai \nB) Kapa haka \nC) Kia ora\n");
                string ans1 = Console.ReadLine().ToUpper();

                
                switch (ans1)
                {
                    case "A":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                    case "B":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                    case "C":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                    default:
                           invalidAns();
                           continue;
                }
                break;
            }

                while (true)
                {
                    Console.WriteLine("\nQUESTION 2: \n\nWhat is the English phrase for Morena? \n\nA) Good morning \nB) Good afternoon \nC) Good evening\n");
                    string ans2 = Console.ReadLine().ToUpper();


                    switch (ans2)
                    {
                        case "A":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                               invalidAns();
                               continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("\nQUESTION 3: \n\nWhat is the Maori term for performing arts? \n\nA) Kapa haka \nB) Korare \nC) Kaumatua");
                    string ans3 = Console.ReadLine().ToUpper();


                    switch (ans3)
                    {
                        case "A":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                               invalidAns();
                               continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 4: \n\nMatariki can be best described as... \n\nA) The Maori term for the Pleiades star cluster \nB) The beginning of the Maori New Year \nC) A celebration akin to Christmas");
                    string ans4 = Console.ReadLine().ToUpper();


                    switch (ans4)
                    {
                        case "A":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                               invalidAns();
                               continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 5: \n\nWhat is the Maori term for kanoe? \n\nA) Whaka \nB) Raka \nC) Waka");
                    string ans5 = Console.ReadLine().ToUpper();


                    switch (ans5)
                    {
                        case "A":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                               invalidAns();
                               continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 6: \n\nWhat is the English equivalent of Aoteaora? \n\nA) The Pacific Ocean \nB) New Zealand \nC) Atlantis");
                    string ans6 = Console.ReadLine().ToUpper();


                    switch (ans6)
                    {
                        case "A":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 7: \n\nWhat day is rapare? \n\nA) Thursday \nB) Friday \nC) Saturday");
                    string ans7 = Console.ReadLine().ToUpper();


                    switch (ans7)
                    {
                        case "A":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nFINAL QUESTION: \n\nWhat day follows rapare? \n\nA) Mane \nB) Paraire \nC) Ratapu");
                    string ans8 = Console.ReadLine().ToUpper();


                    switch (ans8)
                    {
                        case "A":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            correctAns();
                            score++;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while(score <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSorry, your score of " + score + " does not qualify as a passing score. Do you wish to have another go at this quiz? \nIf so, please type Y and press ENTER. If not, please type N and press ENTER to exit.");
                    Console.ResetColor();
                    string choice2 = Console.ReadLine().ToUpper();

                    switch(choice2)
                    {
                        case "Y":
                                easy();
                                break;
                        case "N":
                                break;
                        default:
                               Console.WriteLine("\nSorry, that is an invalid input. Please type either Y or N and press ENTER");
                               continue;
                    }
                    break;
                }
                while(score >= 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCongratulations! You have passed Harman Singh's multiple choice Te Reo Maori quiz with a score of " + score + "!\nDo you wish to try more advanced questions? \nIf so, please type Y and press ENTER. If not, please type N and press ENTER to leave.");
                    Console.ResetColor();
                    string choice3 = Console.ReadLine().ToUpper();

                    switch(choice3)
                    {
                        case "Y":
                                hard();
                                break;
                        case "N":
                                break;
                        default:
                               Console.WriteLine("\nSorry, that is an invalid input. Please type either Y or N and press ENTER");
                               continue;
                    }
                    break;
                }
                {
                }
                {
                }
            }
            static void hard() // Hard questions.
            {
                int score = 0;
                while (true)
                {
                    Console.WriteLine("\nQUESTION 1: If you wished to congradulate someone, you would say... \n\nA) Mahi tahi \nB) Nga mihi \nC) Tino pai");
                    string ans1 = Console.ReadLine().ToUpper();


                    switch (ans1)
                    {
                        case "A":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 2: If you used the greeting tena koe, how many people would you be referring to? \n\nA) One person \nB) Two people \nC) More than three people.");
                    string ans2 = Console.ReadLine().ToUpper();


                    switch (ans2)
                    {
                        case "A":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nNQUESTION 3: If yesterday was stormy, what word would you use to describe the weather? \n\nA) Wera \nB) Makarir \nC) Marangai");
                    string ans3 = Console.ReadLine().ToUpper();


                    switch (ans3)
                    {
                        case "A":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 4: If I said it was ua outside what would the weather be like? \n\nA) Snowy \nB) Rainy \nC) Hot");
                    string ans4 = Console.ReadLine().ToUpper();


                    switch (ans4)
                    {
                        case "A":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 5: What is the Maori word for bus? \n\nA) Pahi \nB) Mahi \nC) Paki");
                    string ans5 = Console.ReadLine().ToUpper();


                    switch (ans5)
                    {
                        case "A":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 6: If I said I came home via tereina, what did I come home in? \n\nA) Train \nB) Bus \nC) Car");
                    string ans6 = Console.ReadLine().ToUpper();


                    switch (ans6)
                    {
                        case "A":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 7: Which is the correct Maori translation of the sentence: \nHello everyone to Avondale College. \n\nA) Kia ora koutou katoa o Avondale College. \nB) Kia ora ki tetahi o te Kareti o Avondale. \nC) Kia ora ki te tokorua kei Avondale College");
                    string ans7 = Console.ReadLine().ToUpper();


                    switch (ans7)
                    {
                        case "A":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("\nQUESTION 7: Which is the correct Maori translation of the sentence: \nHello everyone to Avondale College. \n\nA) Kia ora koutou katoa o Avondale College. \nB) Kia ora ki tetahi o te Kareti o Avondale. \nC) Kia ora ki te tokorua kei Avondale College");
                    string ans7 = Console.ReadLine().ToUpper();


                    switch (ans7)
                    {
                        case "A":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "B":
                            wrongAns();
                            score = score - 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        case "C":
                            correctAns();
                            score = score + 2;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou have a total of " + score + " points.");
                            Console.ResetColor();
                            break;

                        default:
                            invalidAns();
                            continue;
                    }
                    break;
                }
                while(score <= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSorry, your score of " + score + " does not qualify as a passing score. Do you wish to try an easier set of questions? \nIf so, please type Y and press ENTER. If not, please type N and press ENTER to exit.");
                    Console.ResetColor();
                    string choice4 = Console.ReadLine().ToUpper();

                    switch(choice4)
                    {
                        case "Y":
                            easy();
                            break;
                        case "N":
                            break;
                    }
                    break;
                }

                while(score >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCongratulations! You have passed Harman Singh's multiple choice Te Reo Maori quiz with a score of " + score + "!\nPlease press ENTER to leave.");
                    Console.ResetColor();
                }
            }
        }
    }
}