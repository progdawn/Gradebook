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
    class FinalExamApp
    {
        static void Main(string[] args)
        {
            Controller stuff = new Controller();
            Admin wizardry = new Admin();

            wizardry.ConsoleSetup(); //sets console size
            wizardry.Intro(); //intro to app
            stuff.MainLoop(); //not really a loop. That function just sort of migrated over to OptionsMenu
            wizardry.Goodbye(); //exit screen
        }
    }
}
