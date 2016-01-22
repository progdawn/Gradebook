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
    //contains student name and scores
    class Student
    {
        public Student()
        {

        }

        private string name = "Dawn";
        private int[] assignments = new int[10];
        private int[] discussionTopics = new int[10];
        private int[] exams = new int[2];
        private int[] individualProject = new int[1];

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int[] Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }

        public int[] DiscussionTopics
        {
            get { return discussionTopics; }
            set { discussionTopics = value; }
        }

        public int[] Exams
        {
            get { return exams; }
            set { exams = value; }
        }

        public int[] IndividualProject
        {
            get { return individualProject; }
            set { individualProject = value; }
        }
    }
}
