using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4___classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Course programming = new Course();
            programming.add_Students(student1, student2, student3);
            programming.name = "Programming with C#";
            int num_students = programming.count_students();

            Teacher teacher1 = new Teacher();
            programming.add_Teacher(teacher1);

            Degree Bachelor = new Degree();
            Bachelor.degree_name = "Bachelor of Science";
            Bachelor.course = programming;

            UProgram Program1 = new UProgram();
            Program1.name = "Information Technology";
            Program1.degree = Bachelor;

            Console.WriteLine("The {0} program contains the {1} degree.",Program1.name, Bachelor.degree_name );
            Console.WriteLine("The {0} degree contains the course {1}",Bachelor.degree_name, programming.name);
            Console.WriteLine("The {0} course contains {1} student(s).",programming.name, num_students);

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();   

        }

        #region

        // Defining Class Members
        public class Student
        {
            public static int num_students = 0;

            public Student()
            {
                num_students++;
            }

            ~Student()
            {
                num_students--;
            }


            // The following statements define properties.
            public string firstName { get; set; }
            public string lastName { get; set; }
            DateTime birthDate { get; set; }
            string addressLine1 { get; set; }
            string addressLine2 { get; set; }
            string city { get; set; }
            string state { get; set; }
            int zip { get; set; }
            string country { get; set; }
            double gpa { get; set; }

        }

        public class Teacher
        {
            // The following statements define properties.
            public string firstName { get; set; }
            public string lastName { get; set; }
            DateTime birthDate { get; set; }
            string addressLine1 { get; set; }
            string addressLine2 { get; set; }
            string city { get; set; }
            string state { get; set; }
            int zip { get; set; }
            string country { get; set; }

        }

        public class UProgram
        {
            // The following statements define properties.
            public string name { get; set; }
            public string department { get; set; }
            public Degree degree { get; set; }

        }

        public class Degree
        {
            // The following statements define properties.
            public string degree { get; set; }
            public string degree_name { get; set; }
            public int credits_req { get; set; }
            public Course course { get; set; }


        }
        public class Course
        {
            // The following statements define properties.
            public string name { get; set; }
            public string num_credits { get; set; }
            public Boolean required { get; set; }
            Student[] current_Students = new Student[3];

            public void add_Students(Student student1, Student student2, Student student3)
            {
                current_Students[0] = student1;
                current_Students[1] = student2;
                current_Students[2] = student3;
            }

            public int count_students()
            {
                return current_Students.Length;
            }

            public void add_Teacher(Teacher teacher1)
            {
                Teacher[] current_Teachers = new Teacher[3];
                current_Teachers[0] = teacher1;
            }



        }
    }
}
        #endregion