using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public struct Student
    {
        // These statements declare the struct fields and set the default values.
        public string firstName;
        public string lastName;
        public string major;
        public string GPA;
        // Other methods, fields, properties, and events.
    }

    public struct Teacher
    {
        // These statements declare the struct fields and set the default values.
        public string firstName;
        public string lastName;
        public string department;
        public string phone;
        // Other methods, fields, properties, and events.
    }

    public struct university_program
    {
        // These statements declare the struct fields and set the default values.
        public string department;
        public string college;
        public string headOfDepartment;
        public string phone;
        // Other methods, fields, properties, and events.
    }

    public struct Course
    {
        // These statements declare the struct fields and set the default values.
        public string number;
        public string title;
        public string credits;
        public string location;
        // Other methods, fields, properties, and events.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[5];

            Student student1 = new Student();
            studentArray[0] = student1;
            Student student2 = new Student();
            studentArray[1] = student1;
            Student student3 = new Student();
            studentArray[2] = student1;
            Student student4 = new Student();
            studentArray[3] = student1;
            Student student5 = new Student();
            studentArray[4] = student1;

            Console.WriteLine("Please enter student information.");

            //loop through the array and assign values to each Student
            //set for i < 1 so that we only set values for one Student
            //could be set as i < studentArray.Length to iterate through all of the students. 

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("For student {0}, please enter a first name:", i+1);
                studentArray[i].firstName = Console.ReadLine();
                Console.WriteLine("For student {0}, please enter a last name:", i+1);
                studentArray[i].lastName = Console.ReadLine();
                Console.WriteLine("For student {0}, please enter a students major:", i+1);
                studentArray[i].major = Console.ReadLine();
                Console.WriteLine("For student {0}, please enter a students GPA:", i+1);
                studentArray[i].GPA = Console.ReadLine();

                Console.WriteLine("You have created {0} {1} and assigned them to the major {2} with a GPA of {3}.", studentArray[i].firstName, studentArray[i].lastName, studentArray[i].major, studentArray[i].GPA);
            }
            Console.WriteLine("Thank you for completing the student information.");



        }

    }
}
