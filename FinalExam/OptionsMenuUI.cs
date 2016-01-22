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
    class OptionsMenuUI
    {
        //prints available options for the user. Began with 0, since it tied in incredibly well with my parallel arrays
        public OptionsMenuUI()
        {

        }

        //get the user's option
        public int GetOption()
        {
            int option = 0;

            Console.WriteLine("Please choose an option");
            Console.WriteLine("\t0) Enter Assignment grade");
            Console.WriteLine("\t1) Enter Discussion Topic grade");
            Console.WriteLine("\t2) Enter Exam grade");
            Console.WriteLine("\t3) Enter Individual Project grade");
            Console.WriteLine("\t4) View scores entered so far");
            Console.WriteLine("\t5) Calculate final grade");
            Console.WriteLine("\t6) Exit application");
            Console.Write(">> ");
            option = int.Parse(Console.ReadLine());
            Console.Clear();
            return option;
        }

        //in case the user has entered the maximum entries for a category, print this
        public void NoMoreScores(int max, string category)
        {
            Console.WriteLine("Sorry, only {0} {1} can be entered.", max, category);
            Console.Write("\nPress any key to return to main menu");
            Console.ReadKey();
        }
    }
}
