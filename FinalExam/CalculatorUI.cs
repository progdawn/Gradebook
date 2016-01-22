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
    //prints the total per category, total points, and letter grade
    class CalculatorUI
    {
        public CalculatorUI()
        {

        }

        //score per category
        public void PrintCategoryScores(string category, int score, int max)
        {
            Console.WriteLine("\tTotal score for {0}: {1} / {2}\n", category, score, max );

        }

        //score total
        public void PrintTotalScore(int total, int max)
        {
            Console.WriteLine("\tTotal score: {0} / {1} \n", total, max);
        }

        //letter grade
        public void PrintLetterGrade(string letter, string name)
        {
            Console.WriteLine("\t{0}'s letter grade: {1}\n", name, letter);
            Console.Write("\tPress any key to return to the main menu ");
            Console.ReadKey();
        }
    }
}
