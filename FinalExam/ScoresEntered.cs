//Dawn Myers
//ITDEV110
//Final Exam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    //used to display scores entered so far
    class ScoresEntered
    {
        public ScoresEntered()
        {

        }

        ScoreDefinitions definitions = new ScoreDefinitions();
        Admin window = new Admin();
        
        //shows scores entered, depending on category chosen
        public void ShowScores(Student enteredScores)
        {
            int option = 0;
            option = ScoresMenu(); //get category the user wants to see the scores of

            Console.Clear();
            Header(option); //displays the category the user chose
            switch (option)
            {
                case 0:
                    PrintAllTheScores(definitions.MaximumEntries[option], enteredScores.Assignments); //if they chose category 0, show assignment scores
                    break;
                case 1:
                    PrintAllTheScores(definitions.MaximumEntries[option], enteredScores.DiscussionTopics); //show Discussion scores
                    break;
                case 2:
                    PrintAllTheScores(definitions.MaximumEntries[option], enteredScores.Exams); //show Exam scores
                    break;
                case 3:
                    PrintAllTheScores(definitions.MaximumEntries[option], enteredScores.IndividualProject); //show Project scores
                    break;
                default:
                    Console.WriteLine("WHOOPS!"); //if something broke, heh
                    break;
            }
            Console.Write("\nPress any key to return to the main menu");
            Console.ReadKey();
        }

        //shows user available categories to choose from
        public int ScoresMenu()
        {
            int optionChoice = 0;

            Console.Clear();
            Console.WriteLine("Pick a category to choose from");

            //prints the categories listed over in ScoreDefintions. 
            //Again, I really, really love parallel arrays!
            for (int category = 0; category < definitions.Categories.Length; category++)
            {
                Console.WriteLine("\t{0}) {1}", category, definitions.Categories[category]);
            }
            Console.Write(">> ");
            optionChoice = int.Parse(Console.ReadLine());
            return optionChoice;
        }

        //prints all scores stored over in the Student class, depending on category they chose
        public void PrintAllTheScores(int max, int[] scores)
        {
            for (int count = 0; count < max; count++)
            {
                Console.WriteLine("\tScore {0}:\t{1}", count + 1, scores[count]); //count + 1 is used to display entries in a human-friendly way. 
            }
        }

        //prints category chosen at the top
        public void Header(int option)
        {
            ConsoleColor originalText = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;

            //fills header with background color
            for (int x = 0; x < window.WindowWidth; x++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Scores for {0}", definitions.Categories[option]);
            Console.ResetColor();
            Console.ForegroundColor = originalText;
            Console.WriteLine();
        }
    }
}
