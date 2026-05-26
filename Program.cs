using System.ComponentModel;

namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User enters their name which is stored in the string name
            Console.Write("Please Enter Your Name:" + " ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"I See, Your Name Is: {name}");

            // User is asked a question whether he wants to do a quiz
            Console.Write("Do You Want To Do A Quiz? (Yes Or No):" + " ");
            string startQuestion = Console.ReadLine();

            // If the output is not yes
            if (startQuestion != "Yes")
            {
                Console.WriteLine("Okay");

            }
            else
            {

                Console.WriteLine("Select Dificulty:\nEasy\nMedium\nHard\nImpossible");
                string asuvdkfauksfd = Console.ReadLine();
            }
        }
    }
}
