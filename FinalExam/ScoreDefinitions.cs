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
    //this class is so crutch and I absolutely love it. By defining categories, grades, and entries here in parallel arrays, 
    //I can use the "option" from the main menu and apply that option to these arrays. Comes in very handy in other classes. 
    //This could probably be a static class. It won't have unique values per class. 
    //unless the app expanded to be used in multiple classes. Real classes. Not the programming ones. 
    class ScoreDefinitions
    {
        public ScoreDefinitions()
        {

        }

        //categories for grades
        private string[] categories = { "Assignments", "Discussion Topics", "Exams", "Individual Project" };

        //the max grade they can receive in those categories
        private int[] maxGrade = { 50, 10, 150, 100 };

        //the max number of entries for each category
        private int[] maximumEntries = { 10, 10, 2, 1 };

        //max points student can get in each category
        private int[] maxTotalPerCategory = { 0, 0, 0, 0 };

        //the total points possible for all scores
        private int maxTotal = 0;

        //calculates max number of points overall, and max number of points per category. 
        //Didn't want to hardcode that, in case more categories/grades/entries were added in the future
        public void CalculateMaxTotal()
        {
            for (int category = 0; category < categories.Length; category++)
            {
                for (int grade = 0; grade < maximumEntries[category]; grade++)
                {
                    maxTotal += maxGrade[category];
                    maxTotalPerCategory[category] += maxGrade[category];
                }
            }
        }

        public string[] Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public int[] MaxGrade
        {
            get { return maxGrade; }
            set { maxGrade = value; }
        }

        public int[] MaximumEntries
        {
            get { return maximumEntries; }
            set { maximumEntries = value; }
        }

        public int MaxTotal
        {
            get { return maxTotal; }
            set { maxTotal = value; }
        }

        public int[] MaxTotalPerCategory
        {
            get { return maxTotalPerCategory; }
            set { maxTotalPerCategory = value; }
        }
    }
}
