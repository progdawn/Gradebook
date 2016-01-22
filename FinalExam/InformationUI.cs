using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    //used for gathering information from the user before the app really begins
    //could be used in the future for entering custom categories, max grades, and max entries
    class InformationUI
    {
        public InformationUI()
        {

        }

        public string GetStudentName()
        {
            string name = "Dawn";

            Console.WriteLine("Enter the student's name");
            Console.Write(">> ");
            name = Console.ReadLine();
            Console.Clear();
            return name;
        }
    }
}
