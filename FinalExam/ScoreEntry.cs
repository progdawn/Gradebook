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
    //gets the scores for each category. Relies heavily on optionChoice from the main menu (OptionsMenu), 
    //and parallel arrays in ScoreDefintions
    class ScoreEntry
    {
        public ScoreEntry()
        {

        }

        ScoreDefinitions categories = new ScoreDefinitions();
        Admin windowSize = new Admin();

        //keeps track of scores entered so far. Kinda like another parallel array for the others in ScoreDefinitions
        //when the user enters a score for option 0, which is Assignments, then increment the scoreCount array element 0 by 1
        //this is then used to add the score to that element of the Assignment arrays over in Student. I'll explain more down below.
        private int[] scoreCount = { 0, 0, 0, 0 };

        //used to enter scores for each category
        public void EnterScores(int optionChoice, Student scores)
        {
            int score = 0; //individual score
            int totalScore = 0; //total score for those entered in so far

            Console.Clear();

            //while the user chose to keep entering scores, and the max number of entries has not been reached
            while (score != 999 && scoreCount[optionChoice] < categories.MaximumEntries[optionChoice])
            {
                //... I think I could take this out. Not sure why it's here. I probably put it in for some good reason or another. Past Dawn tends to know what she was doing. 
                if (scoreCount[optionChoice] == categories.MaximumEntries[optionChoice])
                {
                    Console.WriteLine("\n\tSorry, only {0} {1} can be entered.", categories.MaximumEntries[optionChoice], categories.Categories[optionChoice]);
                    Console.Write("\n\tPress any key to return to main menu");
                    Console.ReadKey();
                    score = 999;
                }

                //else, start entering scores, depending on what option the user chose in OptionsMenu
                else
                {
                    Header(optionChoice, totalScore); //keeps track of total so far, and tells the user how to exit
                    Console.Write("\n\tEnter score {0} (max {1}) >> ", scoreCount[optionChoice] + 1, categories.MaxGrade[optionChoice]);
                    score = int.Parse(Console.ReadLine());

                    //if the user chose not to exit, enter scores
                    if (score != 999)
                    {
                        //if the score entered was too high for the category (determined through optionChoice), make them enter a valid score
                        while (score > categories.MaxGrade[optionChoice])
                        {
                            Console.Write("\tPlease enter a valid score >> ");
                            score = int.Parse(Console.ReadLine());
                        }

                        //assigns the score to one array or another in the student object. I'd love to find a more modular way to do this, especially compared to the rest of my app. 
                        //maybe instead of the array being named "Assignments" or "Exam", make it "category1" and so on.
                        //Then use the parallel arrays in ScoreDefinitions to determine what the category is. 
                        switch (optionChoice)
                        {
                            case 0:
                                scores.Assignments[scoreCount[optionChoice]] += score; //if optionChoice = 0, add score to Assignment element scoreCount[0] (I'll tell you down yonder!)
                                break;
                            case 1:
                                scores.DiscussionTopics[scoreCount[optionChoice]] += score; //option = 1, add score to DiscussionTopics element scoreCount[1]
                                break;
                            case 2:
                                scores.Exams[scoreCount[optionChoice]] += score; //option = 2, add score to Exams element scoreCount[2]
                                break;
                            case 3:
                                scores.IndividualProject[scoreCount[optionChoice]] += score; //option = 3, add score to Projects element scoreCount[3]
                                break;
                            default:
                                Console.WriteLine("Whoops!");
                                break;
                        }
                        totalScore += score; //now that score entered, and add it to the runnning total, which is used in the header

                        //here's a key piece! So the first run through, scoreCount[0] equals 0. The score is added to Assignments[0].
                        //scoreCount[0] is now incremented from 0 to 1. When the next Assignment score is entered, it adds the score to Assignments[scoreCount[0]].
                        //Since the second time around, scoreCount[0] == 1, it will add this round's score to Assignments[1]!
                        //When the 10th Assignments score is entered in, scoreCount[0] will be 9, and so will add the score to Asssignments[9].
                        //OMG PARALLEL ARRAYS ARE AWESOME!!!
                        scoreCount[optionChoice]++;
                    }
                }
                Console.Clear();
            }
        }

        //keeps track of the total score for the chosen category so far. Also tells the user how to return to main menu
        public void Header(int option, int runningTotal)
        {
            //maintains my text color established in Admin
            ConsoleColor originalText = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;

            //fills up my header with a background color. Uses the window width established in Admin
            for (int x = 0; x < windowSize.WindowWidth; x++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, 0);
            Console.Write("Total points for {0}: {1}", categories.Categories[option], runningTotal); //prints total score for the selected category
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Enter \"999\" to return to main menu");
            Console.ResetColor(); //returns background color to normal
            Console.ForegroundColor = originalText; //returns text color to the original
        }

        public int[] ScoreCount
        {
            get { return scoreCount; }
            set { scoreCount = value; }
        }
    }
}
