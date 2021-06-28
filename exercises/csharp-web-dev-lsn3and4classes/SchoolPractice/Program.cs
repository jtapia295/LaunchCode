using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Jose = new Student();
            Jose.Name = "Jose Tapia";
            Jose.NumberOfCredits = 1;
            Jose.Id = 44678;
            Jose.Gpa = 4.0;

            //Instantiate Teacher
            Teacher inst1 = new Teacher();
            inst1.FirstName = "Jeanette";
            inst1.LastName = "Polinski";
            inst1.Subject = "Algebra";
            inst1.Email = "J.Polinski@hogwarts.com";
            inst1.YearsTeaching = 5;


            //Instantiate Course
            Course algebra2 = new Course();
            algebra2.Name = "Algebra 2";
            algebra2.Id = 34521;
            algebra2.Teacher = inst1;
            algebra2.AddStudent(Jose);

            Console.WriteLine("Class Info:---");
            algebra2.ClassInfo();

            Console.WriteLine("Class Roster------------");
            algebra2.PrintRoster();



        }
    }
}
