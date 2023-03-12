using System;
using System.Collections.Generic;

namespace ClassRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some practice with my classes and objects...");

            Instructor myTeacher1 = new Instructor("Alec", "Engebretson", "alec.engebretson@doane.edu");
            Instructor myTeacher2 = new Instructor();
            myTeacher2.FirstName = "JS";
            myTeacher2.LastName = "Brown";
            myTeacher2.ContactInfo = "TBD";

            Student myStudent1 = new Student("Colin", "Engebretson", "senior");
            Student myStudent2 = new Student();
            myStudent2.FirstName = "Elle";
            myStudent2.LastName = "Hessheimer";
            myStudent2.ClassRank = "junior";

            Console.WriteLine(myTeacher1);
            Console.WriteLine(myTeacher2);
            Console.WriteLine(myStudent1);
            Console.WriteLine(myStudent2);

            Console.WriteLine("Now begin the actual application...");

            // Get the instructor
            Instructor myTeacher = new Instructor();
            Console.Write("Please enter the instructor's first name: ");
            myTeacher.FirstName = Console.ReadLine();
            Console.Write("Please enter the instructor's last name: ");
            myTeacher.LastName = Console.ReadLine();
            Console.Write("Please enter the instructor's contact email: ");
            myTeacher.ContactInfo = Console.ReadLine();

            // Initialize the array of students
            List<Student> myClass = new List<Student>();
            // Initialize the flag for looping
            bool loopFlag=true;
            // Declare the user choice
            string userChoice;

            while (loopFlag)
            {
                // Print the menu
                Console.WriteLine("1. Add a student to the roster.");
                Console.WriteLine("2. Print the roster.");
                Console.WriteLine("3. Quit.");
                Console.WriteLine("Please enter a 1 or 2 or 3: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    // first get a new student and place in an object
                    Student newStudent = new Student();
                    Console.Write("Please enter the students's first name: ");
                    newStudent.FirstName = Console.ReadLine();
                    Console.Write("Please enter the student's last name: ");
                    newStudent.LastName = Console.ReadLine();
                    Console.Write("Please enter the student's class rank: ");
                    newStudent.ClassRank = Console.ReadLine();

                    // now add student to the array
                    myClass.Add(newStudent);
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine(myTeacher);
                    foreach (Student aStudent in myClass)
                        Console.WriteLine(aStudent);
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("Bye bye!");
                    loopFlag = false;
                }
                else Console.WriteLine("Um, I have nothing...");
            }

        }
    }
}
