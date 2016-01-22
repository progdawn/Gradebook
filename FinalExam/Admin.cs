//Dawn Myers
//ITDEV110
//Final Exam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FinalExam
{
    class Admin
    {
        public Admin()
        {

        }

        private int windowWidth = 90;
        private int windowHeight = 25;

        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "Gradebook"; //window title
            Console.SetWindowSize(windowWidth, windowHeight); //window size
            Console.BackgroundColor = ConsoleColor.Black; //background color of console
            Console.ForegroundColor = ConsoleColor.Green; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("Welcome to Gradebook!");
            Sleep();
            Console.WriteLine("Select a category to enter the student's grades.");
            Sleep();
            Console.WriteLine("You may also view all grades entered so far.");
            Sleep();
            Console.WriteLine("You may also calculate the student's current grade at any time.");
            Sleep();
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Beep(330, 200);
            Console.WriteLine("Thanks for using Gradebook!");
            Sleep();
            Console.Write("Shutting down");
            Sleep();
            Console.Write(".");
            Sleep();
            Console.Write(".");
            Sleep();
            Console.Write(".");
        }

        //shortcute for thread.sleep
        public void Sleep()
        {
            Thread.Sleep(500);
        }

        public int WindowWidth
        {
            get { return windowWidth; }
            set { windowWidth = value; }
        }

        public int WindowHeight
        {
            get { return windowHeight; }
            set { windowHeight = value; }
        }
    }
}
