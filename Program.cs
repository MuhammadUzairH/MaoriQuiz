using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            char quizDificultly,replay,choiceConfirmation;

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
                do
                {
                    quizDificultly = displayChoice();
                    switch (quizDificultly)
                    {
                        case 'E':
                            {
                                //the easiest quiz
                                Console.WriteLine("\nAre You Sure You Want To Do Easy Mode? (Y/N):");
                                choiceConfirmation = Convert.ToChar(Console.ReadLine());
                                if (choiceConfirmation != 'Y')
                                {


                                }
                            }
                            break;
                        case 'M':
                            {
                                // the medium quiz
                                Console.WriteLine("\nAre You Sure You Want To Do Medium Mode? (Y/N):");
                                choiceConfirmation = Convert.ToChar(Console.ReadLine());
                                if (choiceConfirmation != 'Y')
                                {
                                    switch (quizDificultly)
                                    {
                                       
                                    }

                                }
                            }
                            break;
                        case 'H':
                            {
                                // the 2nd hardest quiz
                                Console.WriteLine("\nAre You Sure You Want To Do Hard Mode? (Y/N):");
                                choiceConfirmation = Convert.ToChar(Console.ReadLine());
                                if (choiceConfirmation != 'Y')
                                {
                                    switch (quizDificultly)
                                    {

                                    }

                                }
                            }
                            break;
                        case 'I':
                            {
                                // the most most hardest quiz
                                Console.WriteLine("\nAre You Sure You Want To Do Impossible Mode? (Y/N):");
                                choiceConfirmation = Convert.ToChar(Console.ReadLine());
                                if (choiceConfirmation != 'Y')
                                {
                                    switch (quizDificultly)
                                    {

                                    }

                                }
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("\nInvalid Option");
                            }
                            break;
                    }
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
            // This is the code where the user input their name
            Console.Write("\nPlease Enter Your First Name:" + " ");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.Write("\nPlease Enter Your Last Name:" + " ");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"\nI See, Your Name Is: {firstName + lastName}");
            Console.WriteLine("----------------------------");
            string fullName = firstName + lastName;
            return fullName;

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
