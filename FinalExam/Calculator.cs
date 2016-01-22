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
    //used to calculate total scores per category, and final letter grade
    class Calculator
    {
        public Calculator()
        {

        }

        CalculatorUI calcUI = new CalculatorUI();
        ScoreDefinitions categories = new ScoreDefinitions();

        //parallel arrays, used to print letter depending on grade percent
        private string[] letterGrades = { "A", "A-", "B+", "B", "B-", "C+", "C", "D", "F" }; 
        private int[] letterPoints = { 95, 90, 85, 80, 75, 70, 65, 60, 0 };
        private int total = 0;

        //find the letter grade
        public void CalculateLetterGrade(string name, int maxTotal)
        {
            bool gotIt = false; //if percent >= scale, flag this
            int letter = 0; //cycles through elements of letterPoints
            double percent = 0; //student's percent 

            percent = ((double)total / (double)maxTotal) * 100; //student's total / max available points = percentage

            //cycle through letterPoints, comparing the student's score with each element. Once a match is found, exit the loop
            //if the student's score is >= letter's element of letterPoints, flip the flag and assign a letter grade
            while(letter < letterPoints.Length && gotIt == false)
            {
                if (percent >= letterPoints[letter])
                {
                    gotIt = true; //get out of the loop
                    calcUI.PrintLetterGrade(letterGrades[letter], name); //print letter's element of letterGrades
                }
                else
                {
                    letter++; //increments to the next element of letterPoints
                }
            }
        }

        //these are hardcoded, and I don't like it. The rest of my app follows OOP stuff pretty well, IMO. I'd like to fix this, if I get the chance someday
        public void AddScores(Student studentScores, int[] maxPerCategory, int maxTotal)
        {
            //add student scores together, to create student total. Feels gross. 
            int assignments = 0;
            int discTopic = 0;
            int exams = 0;
            int project = 0;

            //adds Assignment scores together
            for (int assCount = 0; assCount < studentScores.Assignments.Length; assCount++)
            {
                assignments += studentScores.Assignments[assCount];
            }
            calcUI.PrintCategoryScores(categories.Categories[0], assignments, maxPerCategory[0]); //prints student total out of max total

            //adds Discussion scores
            for (int discCount = 0; discCount < studentScores.DiscussionTopics.Length; discCount++)
            {
                discTopic += studentScores.DiscussionTopics[discCount];
            }
            calcUI.PrintCategoryScores(categories.Categories[1], discTopic, maxPerCategory[1]); //prints student total out of max total

            //adds Exam scores
            for (int examCount = 0; examCount < studentScores.Exams.Length; examCount++)
            {
                exams += studentScores.Exams[examCount];
            }
            calcUI.PrintCategoryScores(categories.Categories[2], exams, maxPerCategory[2]); //prints student total out of max total

            //adds Project scores (just one for now, but if more are available in the future, it won't take much code change
            for (int projectCount = 0; projectCount < studentScores.IndividualProject.Length; projectCount++)
            {
                project += studentScores.IndividualProject[projectCount];
            }
            calcUI.PrintCategoryScores(categories.Categories[3], project, maxPerCategory[3]); //prints student total out of max total

            total = assignments + discTopic + exams + project; //adds those scores together
            calcUI.PrintTotalScore(total, maxTotal); //prints total points out of max total
        }
    }
}
