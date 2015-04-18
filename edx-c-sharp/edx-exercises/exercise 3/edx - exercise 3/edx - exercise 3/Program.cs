using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edx___exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {

            GetStudentInfo();
            GetTeacherInfo();
            GetCourseInfo();
            GetProgramInfo();
            GetDegreeInfo();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday: ");
            string birthday = Console.ReadLine();
            DateTime birthday_datetime = new DateTime();

            try
            {
                birthday_datetime = Convert.ToDateTime(birthday);
            }
            catch
            {
                Console.WriteLine("We're sorry but you did not enter a correct birthday.");
                return;
            }

            if (ValidateBirthday(birthday_datetime).Equals(true))
            {
                PrintStudentDetails(firstName, lastName, birthday_datetime);
            }

            else
                Console.WriteLine("Sorry but you must be 18 to apply to this University.");

        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string teacherFirstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string teacherLastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's department name: ");
            string department = Console.ReadLine();

            PrintTeacherDetails(teacherFirstName, teacherLastName, department);
        }

        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the course number: ");
            string courseNumber = Console.ReadLine();
            Console.WriteLine("Enter the number of credits: ");
            string courseCredits = Console.ReadLine();

            PrintCourseDetails(courseName, courseNumber, courseCredits);
        }

        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the Program name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the Program's Department: ");
            string programDept = Console.ReadLine();
            Console.WriteLine("Enter the Program's number of students: ");
            string numStudents = Console.ReadLine();

            PrintProgramDetails(programName, programDept, numStudents);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("Enter the Degree name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits required: ");
            string degreeCreditsReq = Console.ReadLine();
            Console.WriteLine("Enter the average GPA of students in this degree program: ");
            string degreeAvgGPA = Console.ReadLine();

            PrintDegreeDetails(degreeName, degreeCreditsReq, degreeAvgGPA);
        }

        static Boolean ValidateBirthday(DateTime birthday)
        {
            if (DateTime.Today.Year - birthday.Year >= 18)
                return true;
            else
                return false;
        }



        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {

            if (ValidateBirthday(birthday))
                Console.WriteLine("{0} {1} was born on: {2}.", first, last, birthday);
            else
                Console.WriteLine("We're sorry but you must be 18 to apply to this university.");
        }

        static void PrintTeacherDetails(string first, string last, string department)
        {
            Console.WriteLine("{0} {1} is a part of this department: {2}.", first, last, department);
        }

        static void PrintCourseDetails(string name, string number, string credits)
        {
            Console.WriteLine("{0} has a course number of {1} and requires this many course credits: {2}.", name, number, credits);
        }

        static void PrintProgramDetails(string name, string dept, string numStudents)
        {
            Console.WriteLine("{0} within the {1} department has {2} students.", name, dept, numStudents);
        }

        static void PrintDegreeDetails(string name, string creditsReq, string avgGPA)
        {
            Console.WriteLine("{0} requires {1} number of credits. Current students have a {2} average GPA.", name, creditsReq, avgGPA);
        }

    }
}
