using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char quizDificultly,replay;

            // Welcome page
            displayWelcome("----------------------------");
            
            
            // User enters their name which is stored in the string name
            name = inputName();

            // User is asked a question whether he wants to do a quiz
            Console.Write("Do You Want To Do A Quiz? (Yes Or No):" + " ");
            string startQuestion = Console.ReadLine();

            // If the output is not yes
            if (startQuestion != "Yes")
            {
                Console.WriteLine("Okay");

            }
            // Dsiplaying question and the difficulty the user sets it to be
            else
            {
                do
                {
                    quizDificultly = displayChoice();
                    switch (quizDificultly)
                    {
                        case 'E':
                            {
                                //the easiest quiz

                            }
                            break;
                        case 'M':
                            {
                                // the medium quiz

                            }
                            break;
                        case 'H':
                            {
                                // the 2nd hardest quiz

                            }
                            break;
                        case 'I':
                            {
                                // the most most hardest quiz

                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                            }
                            break;
                    }
                    Console.WriteLine("Congrast, You Got ");
                    Console.WriteLine("Do You Want To Play Again? (Y/N)");
                    replay = Console.ReadLine().ToUpper()[0];
                } while (replay == 'Y');
            }
        }
        // This is the welcome page
        static void displayWelcome(string nsg) { Console.WriteLine("Welcome To The Quiz");
            Console.WriteLine(nsg);
                }
        static string inputName() 
        {
            // This is the code where the user input their name
            Console.Write("Please Enter Your First Name:" + " ");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your First Name:" + " ");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"I See, Your Name Is: {firstName + lastName}");
            string fullName = firstName + lastName;
            return fullName;

        }
        static char displayChoice()
        {
            // This code allows user to choose between the dificulty they want to do
            Console.WriteLine("Select Dificulty:\nEasy (E)\nMedium (M)\nHard (H)\nImpossible (I)");
            char quizDificulty = Console.ReadLine().ToUpper()[0];
            return quizDificulty;
    }
    }
}
