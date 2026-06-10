using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] easyQuestion = { "ANSWER THESE QUESTION BY ENTERING THE FOLLOWING LETTERS IN THE LIST\n----------------------------\n\n(1.) What Is The Māori Word For \"Hello\"?\n\n(A)Kia Ora\n\n(B)Haere Rā\n\n(C)Whānau\n\n(D)Kai", "\n(2.)What Does \"Whānau\" Mean?\n\n(A)School\n\n(B)Family\n\n(C)Food\n\n(D)Friend", "\n\n(3.)What Is The Māori Word For \"Food\"?\n\n(A)Moana\n\n(B)Whare\n\n(C)Kai\n\n(D)Aroha", "\n\n(4.)What Does \"Aroha\" Mean?\n\n(A)Love\n\n(B)Water\n\n(C)Mountain\n\n(D)Bird", "\n\n(5.) What Is The Māori Word For \"House\"?\n\n(A)Whenua\n\n(B)Whare\n\n(C)Waka\n\n(D)Kura" };
            Char[] easyAnswer = { 'A', 'B', 'C', 'A', 'B' };
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
            // Displaying question and the difficulty the user sets it to be.
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
                                    Console.Write("\nAre You Sure You Want To Do Easy Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());

                                    if (choiceConfirmation == 'Y')
                                    {
                                        displayQuestions(easyQuestion);
                                        
                                    }

                                    break;
                                }
                            case 'M':
                                {
                                    // the medium quiz
                                    Console.Write("\nAre You Sure You Want To Do Medium Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());
                                }
                                break;
                            case 'H':
                                {
                                    // the 2nd hardest quiz
                                    Console.Write("\nAre You Sure You Want To Do Hard Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());
                                }
                                break;
                            case 'I':
                                {
                                    // the most most hardest quiz
                                    Console.Write("\nAre You Sure You Want To Do Impossible Mode? (Y/N):");
                                    choiceConfirmation = Convert.ToChar(Console.ReadLine().ToUpper());
                                }
                                break;
                            default:
                                {
                                    Console.Write("\nInvalid Option");
                                }
                                break;
                        }

                    } while (choiceConfirmation == 'N');

                    Console.WriteLine("Congrats, You Got ");
                    Console.WriteLine("Do You Want To Play Again? (Y/N)");
                    replay = Console.ReadLine()[0];
                } while (replay == 'Y');
            }
        }
        // This is the welcome page
        static void displayWelcome(string nsg)
        {
            Console.WriteLine("Welcome To The Quiz");
            Console.WriteLine(nsg);
        }
        static string inputName()
        {
            // This is the code where the user input their first name 
            Console.Write("\nPlease Enter Your First Name:" + " ");
            string firstName = Convert.ToString(Console.ReadLine());

            while ((firstName.Length < 3) || (firstName.Length > 20) || (!firstName.All(char.IsLetter)))
            {
                Console.WriteLine("\nInvalid First Name\n(You Had Incorrectly Wrote Your First Name Wrong. Name Has To Be Atleast 3 Characters And Less Than 20 Characters.\nFirst Name Cannot Contain Any Space Or Any Symbols And Is Required To Just Input Your First Name.)");
                Console.Write("\nPlease Enter Your First Name:" + " ");
                firstName = Convert.ToString(Console.ReadLine());

            }

            // This is the code where the user input their last name
            Console.Write("\nPlease Enter Your Last Name:" + " ");
            string lastName = Convert.ToString(Console.ReadLine());
            while ((lastName.Length < 3) || (lastName.Length > 20) || (!lastName.All(char.IsLetter)))
            {
                Console.WriteLine("\nInvalid Last Name\n(You Had Incorrectly Wrote Your Last Name Wrong. Name Has To Be Atleast 3 Characters And Less Than 20 Characters.\nLast Name Cannot Contain Any Space Or Any Symbols And Is Required To Just Input Your Last Name.");
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
            Console.WriteLine("\nSelect Dificulty:\n\nEasy (E)\n\nMedium (M)\n\nHard (H)\n\nImpossible (I)\n");
            char quizDificulty = Console.ReadLine().ToUpper()[0];
            return quizDificulty;
        }

        static int displayQuestions(String[] inQuestion, Char[] correctAnswer)
        {
           
            for (int i = 0; i < inQuestion.Length; i++)
            {

                Console.WriteLine(inQuestion[i]);
                char answer = Console.ReadLine().ToUpper()[0];
                int totalpoints = 0;
                if (answer == correctAnswer[i])
                {
                     Console.WriteLine($"Congrats You Got The Correct Answer; {totalpoints + 1} Point");
                     totalpoints = + 1;
                }
                else
                {
                    Console.WriteLine($"Incorrect, The Correct Answer Was {correctAnswer[i]}");
                }
                
            }
            return 0;
        }
    }
}
        
    


