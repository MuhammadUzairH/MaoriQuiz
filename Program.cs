using System.ComponentModel;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char quizDificultly, replay, choiceConfirmation;
            choiceConfirmation = 'N';


            // Welcome page
            displayWelcome("----------------------------");


            // User enters their name which is stored in the string name
            name = inputName();

            // User is asked a question whether he wants to do a quiz
            Console.Write("\nDo You Want To Do A Quiz? (Y/N):" + " ");
            string startQuestion = Console.ReadLine();

            // If the output is not yes
            if (startQuestion != "Y")
            {
                Console.WriteLine("\nOkay");

            }
            // Dsiplaying question and the difficulty the user sets it to be
            else
            {
                // This do loop would let the user to replay the quiz if they want to play again.
                do
                {
                    // if the user is not ensure whether they want to that quiz difficulty. Choice confirmation allows the user that they could undo their choice by going back to quizdifficulty.
                    do
                    {
                        quizDificultly = displayChoice();
                        switch (quizDificultly)
                        {

                            case 'E':
                                {
                                    //the easiest quiz
                                    Console.WriteLine("\nAre You Sure You Want To Do Easy Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());

                                    break;
                                }
                            case 'M':
                                {
                                    // the medium quiz
                                    Console.WriteLine("\nAre You Sure You Want To Do Medium Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());
                                }
                                break;
                            case 'H':
                                {
                                    // the 2nd hardest quiz
                                    Console.WriteLine("\nAre You Sure You Want To Do Hard Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());
                                }
                                break;
                            case 'I':
                                {
                                    // the most most hardest quiz
                                    Console.WriteLine("\nAre You Sure You Want To Do Impossible Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("\nInvalid Option");
                                }
                                break;
                        }

                    } while (choiceConfirmation == 'N');

                    Console.WriteLine("Congrast, You Got ");
                    Console.WriteLine("Do You Want To Play Again? (Y/N)");
                    replay = Console.ReadLine()[0];
                } while (replay == 'Y');
            }
        }
        // This is the welcome page
        static void displayWelcome(string nsg) { Console.WriteLine("Welcome To The Quiz");
                    Console.WriteLine(nsg);
                }
                static string inputName()
                {
                    // This is the code where the user input their first name 
                    Console.Write("\nPlease Enter Your First Name:" + " ");
                    string firstName = Convert.ToString(Console.ReadLine());

                    while ((firstName.Length <= 3) || (firstName.Length >= 20) || (!firstName.All(char.IsLetter)))
                    {
                        Console.WriteLine("\nInvalid First Name\n(You Had Incorrectly Wrote Your First Name Wrong. Name Has To Be More Than 3 Characters And Less Than 20 Characters)");
                        Console.Write("\nPlease Enter Your First Name:" + " ");
                        firstName = Convert.ToString(Console.ReadLine());

                    }

                    // This is the code where the user input their last name
                    Console.WriteLine("\nPlease Enter Your Last Name:" + " ");
                    string lastName = Convert.ToString(Console.ReadLine());
                    while ((lastName.Length <= 3) || (lastName.Length >= 20) || (!lastName.All(char.IsLetter)))
                    {
                        Console.WriteLine("\nInvalid Last Name\n(You Had Incorrectly Wrote Your Last Name Wrong. Name Has To Be More Than 3 Characters And Less Than 20 Characters)");
                        Console.WriteLine("\nPlease Enter Your Last Name:" + " ");
                        lastName = Convert.ToString(Console.ReadLine());

                    }

                    Console.WriteLine($"\nI See, Your Name Is: {firstName + " " + lastName}");
                    Console.WriteLine("----------------------------");

                    return firstName;
                    return lastName;


                }
                static char displayChoice()
                {
                    // This code allows user to choose between the dificulty they want to do
                    Console.WriteLine("\nSelect Dificulty:\nEasy (E)\nMedium (M)\nHard (H)\nImpossible (I)");
                    char quizDificulty = Console.ReadLine().ToUpper()[0];
                    return quizDificulty;
                }
            }
        }
    
