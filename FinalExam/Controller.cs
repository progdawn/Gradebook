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
    class Controller
    {
        public Controller()
        {

        }

        Student currentStudent = new Student(); //creates a student object, which is used in all the other classes
        OptionsMenu options = new OptionsMenu();
        InformationUI information = new InformationUI();

        //like I said, not really a loop. That just sort of happened over in OptionsMenu
        //I'd like to make this a real loop. Basically, the user could enter in categories here, max scores possible, and a new student each time. 
        //might give it a shot one day
        public void MainLoop()
        {
            currentStudent.Name = information.GetStudentName(); //get student's name
            options.SelectOption(currentStudent); //pass that student over to OptionsMenu, where the real action takes place
        }
    }
}
