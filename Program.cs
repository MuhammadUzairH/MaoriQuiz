
namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] easyQuestions = { "ANSWER THESE QUESTION BY ENTERING THE FOLLOWING LETTERS IN THE LIST\n----------------------------\n\n(1.) What Is The Māori Word For \"Hello\"?\n\n(A)Kia Ora\n\n(B)Haere Rā\n\n(C)Whānau\n\n(D)Kai", "\n\n(2.) What Does \"Whānau\" Mean?\n\n(A)School\n\n(B)Family\n\n(C)Food\n\n(D)Friend", "\n\n(3.) What Is The Māori Word For \"Food\"?\n\n(A)Moana\n\n(B)Whare\n\n(C)Kai\n\n(D)Aroha", "\n\n(4.) What Does \"Aroha\" Mean?\n\n(A)Love\n\n(B)Water\n\n(C)Mountain\n\n(D)Bird", "\n\n(5.) What Is The Māori Word For \"House\"?\n\n(A)Whenua\n\n(B)Whare\n\n(C)Waka\n\n(D)Kura"};
            Char[] easyAnswers = { 'A', 'B', 'C', 'A', 'B' };
            String[] mediumQuestions = { "ANSWER THESE QUESTION BY ENTERING THE FOLLOWING LETTERS IN THE LIST\n----------------------------\n\n(1.) What Is The Meaning Of The Māori Word \"Mana\"?\n\n(A)Food\n\n(B)Prestige, Authority, Or Respect\n\n(C)Family\n\n(D)House", "\n\n(2.) What Is Marae Primarily Used For?\n\n(A)Fishing\n\n(B)Farming\n\n(C)Community Gatherings And Cultural Events\n\n(D)Transport", "\n\n(3.) Which Māori Word Means \"Land\"?\n\n(A)Whenua\n\n(B)Moana\n\n(C)Waka\n\n(D)Awa", "\n\n(4.) What Is The Purpose Of A Haka?\n\n(A)To Cook Food\n\n(B)To Welcome Visitors, Show Pride, Or Challenge Opponents\n\n(C)To Build Houses\n\n(D)To Travel Across Water", "\n\n(5.) Which Of These Is A Traditional Māori Canoe?\n\n(A)Marae\n\n(B)Pounamu\n\n(C)Waka\n\n(D)Taonga" };
            Char[] mediumAnswers = { 'B', 'C', 'A', 'B', 'C' };
            String[] hardQuestions = { "ANSWER THESE QUESTION BY ENTERING THE FOLLOWING LETTERS IN THE LIST\n----------------------------\n\n(1.) What Does The Concept Of \"Kaitiakitanga\" Refer To?\n\n(A)Leadership Over A Tribe\n\n(B)Guardianship And Protection Of The Environment\n\n(C)Traditional Māori Weapons\n\n(D)The Study Of Genealogy", "\n\n(2.) Which Of The Following Best Describes \"Whakapapa\"?\n\n(A)A Traditional Dance\n\n(B)A Type Of Meeting House\n\n(C)Genealogy And Connections Between People, Ancestors, And The Natural World\n\n(D)A Māori Fishing Method", "\n\n(3.) Why Is The Wharenui (Meeting House) Considered Important On A Marae?\n\n(A)It Is Mainly Used For Storing Food\n\n(B)It Represents Ancestors And Serves As A Place For Gathering\n\n(C)It Is Where Canoes Are Built\n\n(D)It Is Used Only For Visitors", "\n\n(4.) What Is The Main Purpose Of A Pōwhiri?\n\n(A)To Elect Leaders\n\n(B)To Prepare Food For Guests\n\n(C)To Officially Welcome Visitors Onto A Marae\n\n(D)To Celebrate A Successful Harvest", "\n\n(5.) Which Value Is Most Closely Associated With Showing Care, Hospitality, And Generosity To Others?\n\n(A)Manaakitanga\n\n(B)Rangatiratanga\n\n(C)Whakapapa\n\n(D)Tino Rangatiratanga" };
            Char[] hardAnswers = { 'B','C','B','C','A' };
            String[] impossibleQuestions = { "ANSWER THESE QUESTION BY ENTERING THE FOLLOWING LETTERS IN THE LIST\n----------------------------\n\n(1.) Which Principle Best Reflects The Concept Of \"Tino Rangatiratanga\"?\n\n(A)Shared Ownership Of Resources\n\n(B)The Right Of Māori To Self-Determination And Leadership Over Their Affairs\n\n(C)Respect For Elders\n\n(D)Protection Of Native Wildlife",  "\n\n(2.) What Was The Primary Purpose Of Te Tiriti O Waitangi As Understood By Many Māori Signatories In 1840?\n\n(A)To Transfer Complete Sovereignty To The British Crown\n\n(B)To Establish A New Trading System\n\n(C)To Allow The Crown To Govern While Māori Retained Authority Over Their Own Affairs\n\n(D)To Create A Māori Parliament", "\n\n(3.) Which Of The Following Best Describes The Relationship Between Whakapapa And Identity?\n\n(A)Whakapapa Is Only Used To Trace Family Trees\n\n(B)Whakapapa Connects Individuals To Ancestors, Communities, Land, And The Spiritual World\n\n(C)Whakapapa Refers To Traditional Māori Laws\n\n(D)Whakapapa Is A Form Of Oral Storytelling",  "\n\n(4.) What Is The Significance Of The Carvings Found Within A Wharenui?\n\n(A)They Are Primarily Decorative Features\n\n(B)They Represent Historical Battles Only\n\n(C)They Symbolise Ancestors And Preserve Tribal Histories And Values\n\n(D)They Indicate The Age Of The Marae",  "\n\n(5.) Which Of The Following Is The Best Example Of Kaitiakitanga In Practice?\n\n(A)Selling Tribal Land For Economic Growth\n\n(B)Restricting Access To Natural Resources To Ensure Their Long-Term Sustainability\n\n(C)Expanding Urban Development Into Protected Areas\n\n(D)Importing Foreign Species To Increase Biodiversity" };
            Char[] impossibleAnswers = {'B','C','B','C','B' };

            string names,inputClarification,inputConfirmation;
            char quizDifficultly, replay, choiceConfirmation,startQuestion;
            choiceConfirmation = ' ';


            // Welcome page
            displayWelcome("----------------------------");


            // User enters their name which is stored in the string name
            names = inputName();

            // User is asked a question whether he wants to do a quiz
            do
            {
                Console.Write("\nDo You Want To Do A Quiz? (Y/N):" + " ");
                inputClarification = Console.ReadLine().ToUpper();


                // If the output is not yes
                if (inputClarification == "N")
                {
                    Console.WriteLine("\nOkay");

                }
                else if (inputClarification != "N" && inputClarification != "Y")
                {
                    Console.WriteLine("\nInvalid Input. User Must Only Enter Y/N (Yes/No)");
                }
                else if (inputClarification == "Y")
                {

                startQuestion = inputClarification[0];
                

                    // This do loop would let the user to replay the quiz if they want to play again.
                    do
                    {
                        // if the user is not ensure whether they want to that quiz difficulty. Choice confirmation allows the user that they could undo their choice by going back to quizdifficulty.
                        do
                        {
                            quizDifficultly = displayChoice();
                            // Displaying question and the difficulty the user sets it to be.
                            switch (quizDifficultly)
                            {

                                case 'E':
                                    {
                                        //the easiest quiz
                                        Console.Write("\nAre You Sure You Want To Do Easy Mode? (Y/N):");
                                        // If the user chooses Y, then the method continues, else it stops.
                                       inputConfirmation = Console.ReadLine().ToUpper();

                                       while (inputConfirmation != "Y" && inputConfirmation != "N")
                                       {
                                           Console.WriteLine("\nInvalid Input. User Must Only Enter (Y/N) (Yes/No)");
                                           inputConfirmation = Console.ReadLine().ToUpper();
                                       }

                                       choiceConfirmation = inputConfirmation[0];
                                        if (choiceConfirmation == 'Y')
                                        {
                                            displayQuestions(easyQuestions, easyAnswers, names);
                                        }
                            }
                            break;
                                case 'M':
                                    {
                                        // the medium quiz
                                        Console.Write("\nAre You Sure You Want To Do Medium Mode? (Y/N):");
                                        inputConfirmation = Console.ReadLine().ToUpper();

                                        while (inputConfirmation != "Y" && inputConfirmation != "N")
                                        {
                                            Console.WriteLine("\nInvalid Input. User Must Only Enter (Y/N) (Yes/No)");
                                            inputConfirmation = Console.ReadLine().ToUpper();
                                        }

                                        choiceConfirmation = inputConfirmation[0];
                                        if (choiceConfirmation == 'Y')
                                        {                                                                                                                                                                                                                                                           
                                            displayQuestions(mediumQuestions, mediumAnswers, names);
                                        }
                                    }
                                    break;
                                case 'H':
                                    {
                                        // the 2nd hardest quiz
                                        Console.Write("\nAre You Sure You Want To Do Hard Mode? (Y/N):");
                                        inputConfirmation = Console.ReadLine().ToUpper();

                                        while (inputConfirmation != "Y" && inputConfirmation != "N")
                                        {
                                            Console.WriteLine("\nInvalid Input. User Must Only Enter (Y/N) (Yes/No)");
                                            inputConfirmation = Console.ReadLine().ToUpper();
                                        }

                                        choiceConfirmation = inputConfirmation[0];
                                        if (choiceConfirmation == 'Y')
                                        {
                                            displayQuestions(hardQuestions, hardAnswers, names);
                                        }
                                    }
                                    break;
                                case 'I':
                                    {
                                        // the most most hardest quiz
                                        Console.Write("\nAre You Sure You Want To Do Impossible Mode? (Y/N):");
                                        inputConfirmation = Console.ReadLine().ToUpper();


                                        while (inputConfirmation != "Y" && inputConfirmation != "N")
                                        {
                                            Console.WriteLine("\nInvalid Input. User Must Only Enter (Y/N) (Yes/No)");
                                            inputConfirmation = Console.ReadLine().ToUpper();
                                        }

                                        choiceConfirmation = inputConfirmation[0];
                                        if (choiceConfirmation == 'Y')
                                        {
                                            displayQuestions(impossibleQuestions, impossibleAnswers, names);
                                        }
                                    }
                                    break;
                                default:
                                    {
                                        Console.Write("\nUnexpecred Error");
                                    }
                                    break;
                            }

                        } while (choiceConfirmation == 'N');

                        Console.WriteLine("Do You Want To Play Again? (Y/N)");
                        replay = Console.ReadLine().ToUpper()[0];
                    } while (replay == 'Y');
                }
            } while (inputClarification != "N");
        }
        
        // This is the welcome page
        static void displayWelcome(string msg)
        {
            Console.WriteLine("Welcome To The Quiz");
            Console.WriteLine(msg);
        }
        static string inputName()
        {
            // This is the code where the user input their first name 
            char invalidName;
            do
            {
                Console.Write("\nPlease Enter Your First Name:" + " ");
                string firstName = Console.ReadLine().ToUpper();

                while ((firstName.Length < 3) || (firstName.Length > 20) || (!firstName.All(char.IsLetter)))
                {
                    Console.WriteLine("\nInvalid First Name\n(You Had Incorrectly Wrote Your First Name Wrong. Name Has To Be Atleast 3 Characters And Less Than 20 Characters.\nFirst Name Cannot Contain Any Space Or Any Symbols And Is Required To Just Input Your First Name.)");
                    Console.Write("\nPlease Enter Your First Name:" + " ");
                    firstName = Console.ReadLine().ToUpper();

                }

                // This is the code where the user input their last name
                Console.Write("\nPlease Enter Your Last Name:" + " ");
                string lastName = Console.ReadLine().ToUpper();
                while ((lastName.Length < 3) || (lastName.Length > 20) || (!lastName.All(char.IsLetter)))
                {
                    Console.WriteLine("\nInvalid Last Name\n(You Had Incorrectly Wrote Your Last Name Wrong. Name Has To Be Atleast 3 Characters And Less Than 20 Characters.\nLast Name Cannot Contain Any Space Or Any Symbols And Is Required To Just Input Your Last Name.");
                    Console.Write("\nPlease Enter Your Last Name:" + " ");
                    lastName = Console.ReadLine().ToUpper();

                }
                Console.WriteLine($"Are You Sure Your Name Is {firstName + " " + lastName}? (Y/N)");
                string nameClarification = Console.ReadLine().ToUpper();
                while (nameClarification != "Y" && nameClarification != "N")
                {
                    Console.WriteLine("Invalid Input. The Answer Has To Be Either (Y/N) (Yes/No)");
                    nameClarification = Console.ReadLine().ToUpper();
                }
                invalidName = nameClarification[0];

                if (invalidName == 'Y')
                {
                    Console.WriteLine($"\nI See, Your Name Is: {firstName + " " + lastName}");
                    Console.WriteLine("----------------------------");
                    return firstName + "" + lastName;
                }

            } while (invalidName == 'N');
            return "";

        }
        static char displayChoice()
        {
            // This code allows user to choose between the dificulty they want to do
            Console.WriteLine("\nSelect Difficulty:\n\nEasy (E)\n\nMedium (M)\n\nHard (H)\n\nImpossible (I)\n");
            string inputquizDifficulty = Console.ReadLine().ToUpper();
            while ((inputquizDifficulty.Length != 1) || inputquizDifficulty != "E" && inputquizDifficulty != "M" && inputquizDifficulty != "H" && inputquizDifficulty != "I")
            {
                Console.WriteLine("\nInvalid Option. You Have To Insert (E,M,H,I) Nothing else.");
                inputquizDifficulty = Console.ReadLine().ToUpper();
                
            }
            char quizDifficulty = inputquizDifficulty[0];
            return quizDifficulty;
        }

        static int displayQuestions(String[] inQuestion, Char[] correctAnswer, string userName)
        {
            int totalPoints = 0;
                for (int i = 0; i < inQuestion.Length; i++)
                {
                    // This question displays the question based on the quick dificulty
                    Console.WriteLine(inQuestion[i]);
                    string inputAnswer = Console.ReadLine().ToUpper();

                while (inputAnswer.Length != 1 ||inputAnswer != "A" && inputAnswer != "B" && inputAnswer != "C" && inputAnswer != "D")
                {
                    Console.WriteLine("Invalid Input. The Answer Has To Be Either, A,B,C,D. Any Other Answer Would Be Rejected.");
                    inputAnswer = Console.ReadLine().ToUpper();
                }
                char answer = inputAnswer[0];
                    if (answer == correctAnswer[i])
                    {
                        totalPoints++;
                        Console.WriteLine($"Congrats You Got The Correct Answer; You Have Received 1 Point. Making Your Total {totalPoints} Point");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect, The Correct Answer Was {correctAnswer[i]}");
                    }
                }
            double decimalPoints = (totalPoints / 5.0) * 100;
            Console.WriteLine($"Congrats, {userName} You Got {totalPoints} Points. That Means Out Of The 5 Questions, You Answered {decimalPoints:F1}% Correctly.");
            return totalPoints;
        }
    }
}

        
    


