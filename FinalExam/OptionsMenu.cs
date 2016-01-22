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
    //used to manuver between different parts of the application
    class OptionsMenu
    {
        public OptionsMenu()
        {

        }

        OptionsMenuUI optionsUI = new OptionsMenuUI();
        ScoreEntry getScores = new ScoreEntry();
        ScoreDefinitions scoreLimit = new ScoreDefinitions();
        ScoresEntered showScores = new ScoresEntered();
        Calculator scoreCalc = new Calculator();

        public void SelectOption(Student currentStudent)
        {
            bool continueApp = true; //if user wants to exit app
            scoreLimit.CalculateMaxTotal(); //originally did this over in Calculator, but then each time you accessed Calculator,  more scores would be added. Kinda got ugly. 

            //while the user has chosen to not exit the app
            while (continueApp == true)
            {

                int optionChoice = 0; //option that the user chose

                optionChoice = optionsUI.GetOption(); //gets the option from the user through UI class

                //if the max number of entries has been reached, don't let the user enter another
                if (optionChoice < 4 && getScores.ScoreCount[optionChoice] == scoreLimit.MaximumEntries[optionChoice])
                {
                    optionsUI.NoMoreScores(scoreLimit.MaximumEntries[optionChoice], scoreLimit.Categories[optionChoice]);
                }

                //else, get scores entered through another class
                else
                {
                    //I probably could have condensed cases 0 - 3 into one case
                    //0 - 3 pass in the student object and option choice, to use in those parallel arrays (see ScoreDefinitions)
                    switch (optionChoice)
                    {
                        case 0:
                            getScores.EnterScores(optionChoice, currentStudent);
                            break;
                        case 1:
                            getScores.EnterScores(optionChoice, currentStudent);
                            break;
                        case 2:
                            getScores.EnterScores(optionChoice, currentStudent);
                            break;
                        case 3:
                            getScores.EnterScores(optionChoice, currentStudent);
                            break;
                        case 4:
                            showScores.ShowScores(currentStudent); //displays scores entered so far
                            break;
                        case 5:
                            scoreCalc.AddScores(currentStudent, scoreLimit.MaxTotalPerCategory, scoreLimit.MaxTotal); //adds scores together for each category
                            scoreCalc.CalculateLetterGrade(currentStudent.Name, scoreLimit.MaxTotal); //generates a letter grade
                            break;
                        case 6:
                            continueApp = false; //if user chose to exit the application, flag this 
                            break;
                        default:
                            Console.WriteLine("WHOOPS!");
                            break;
                    }
                }
                Console.Clear();
            }
        }
    }
}
