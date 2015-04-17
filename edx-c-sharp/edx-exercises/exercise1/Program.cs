using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create variables

            string student_firstName;
            string student_lastName;
            DateTime student_birthDate;
            string student_addressLine1;
            string student_addressLine2;
            string student_city;
            string student_state;
            int student_zip;
            string student_country;
            double gpa;

            string prof_firstName;
            string prof_lastName;
            DateTime prof_birthDate;
            string prof_addressLine1;
            string prof_addressLine2;
            string prof_city;
            string prof_state;
            int prof_zip;
            string prof_country;

            string degree;
            string degree_name;
            int degree_credits_req;

            string univ_program_name;
            string univ_program_name_degree;
            string univ_program_head;

            //assign values

            student_firstName = "Bob";
            student_lastName = "Dylan";
            student_birthDate = new DateTime(1977, 04, 08);
            student_addressLine1 = "1 Student Lane";
            student_addressLine2 = "";
            student_city = "Orlando";
            student_state = "Florida";
            student_zip = 00000;
            student_country = "United States of America";
            gpa = 3.00;

            prof_firstName = "David";
            prof_lastName = "Lynch";
            prof_birthDate = new DateTime(1940, 04, 08);
            prof_addressLine1 = "One Professor Lane";
            prof_addressLine2 = "Mailbox A1A";
            prof_city = "Miami Beach";
            prof_state = "Florida";
            prof_zip = 000000;
            prof_country = "United States of America";

            degree = "Bachelor of Science";
            degree_name = "Computer Science";
            degree_credits_req = 120;

            univ_program_name = "Computer Science";
            univ_program_name_degree = "Information Security";
            univ_program_head = "Dr. Bob Head";

            //write values to console

            Console.WriteLine("First name: " + student_firstName);
            Console.WriteLine("Last name: " + student_lastName);
            Console.WriteLine("Birthdate: " + student_birthDate);
            Console.WriteLine("Address Line: " + student_addressLine1);
            Console.WriteLine("Address Line: " + student_addressLine2);
            Console.WriteLine("City: " + student_city);
            Console.WriteLine("State: " + student_state);
            Console.WriteLine("Zip: " + student_zip);
            Console.WriteLine("Country: " + student_country);
            Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("Professor First Name: " + prof_firstName);
            Console.WriteLine("Professor Last Name: " + prof_lastName);
            Console.WriteLine("Professor Birthdate: " + prof_birthDate);
            Console.WriteLine("Professor Address: " + prof_addressLine1);
            Console.WriteLine("Professor Address: " + prof_addressLine2);
            Console.WriteLine("Professor City: " + prof_city);
            Console.Write("Professor State: " + prof_state);
            Console.WriteLine("Professor Zip: " + prof_zip);
            Console.WriteLine("Professor Country: " + prof_country);
            Console.WriteLine("");

            Console.WriteLine("{0} {1} is applying for a {2} in {3} which requires {4}", student_firstName, student_lastName, degree, degree_name, degree_credits_req);
            Console.WriteLine("The {0} degree is part of the {1} program lead by {2}", univ_program_name_degree, univ_program_name, univ_program_head);
            Console.WriteLine("");

            Console.WriteLine("What is your name?");
            string newStudent = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Good morning, {0}", newStudent);

           

            /*
             Create a C# Console application. Within the Main() method in this application, create variables of the correct data type for the following:

            Student information, such as:
            First Name
            Last Name
            Birthdate
            Address Line 1
            Address Line 2
            City
            State/Province
            Zip/Postal
            Country
            Any other pertinent information you want to add for a student record
            Professor information with pertinent fields
            A university degree with pertinent fields such as Bachelor or Master
            A degree can be Bachelor of Science in Information Technology and include fields such as Degree Name, credits required, etc.  Some of the fields, such as course list and prerequisites will need to wait until you know how to create arrays or collections.
            A university program with pertinent fields such as Computer Science or Arts.  Fields might include:
            Program name
            Degrees offered (Bachelor, Master, Ph.D.)
            Department Head
            Information for a course that would be part of your selected degree and program, with pertinent fields
            NOTE: You can search online for university catalogs to get an idea of the attributes for these objects.

            Once you have the variables created, use assignment statements to assign values to them and use the Console.WriteLine() method to output the values to the console window.

            Again, this assignment is merely intended to check your understanding of how to create variables, assign values to them, and output the information to a console window.  You will build on these concepts and begin to create more functionality in later modules.

            Post your code in the peer review area for feedback from other students.

            Challenge

            Investigate the .NET Framework documenation around Console.ReadLine() and modify your code to use this method for accepting input from a user of your application and assign it to the variables you have created
            */


        }
    }
}
