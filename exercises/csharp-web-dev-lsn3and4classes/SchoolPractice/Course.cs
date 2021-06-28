using System;
using System.Collections.Generic;


namespace SchoolPractice
{
    public class Course
    {

        //This class should contain a course id
        public int Id { get; set; }

        //This class should contain a course name.
        public string Name { get; set; }

        //This class should contain a Teacher name.
        public Teacher Teacher { get; set; }

        //Dictionary should be used to store the class roster info
        internal protected Dictionary<int, string> Roster = new Dictionary<int, string>();

        //Method used to print class Roster
        public void PrintRoster()
        {
            foreach(var item in Roster)
            {
                Console.WriteLine($"{item.Value} ID:{item.Key}");
            }
        }

        //Method used to pint class info
        public void ClassInfo()
        {
            Console.WriteLine($"{this.Name} ID:{Id}\n--------\nInsructor: {Teacher.FirstName[0]}.{Teacher.LastName}\nEmail: {Teacher.Email}\n----------\nClass Count:{Roster.Count}");
        }
        //This class should contain a method add students to the course and assign a student id.
        public void AddStudent(Student person)
        {
            this.Roster.Add(person.Id, person.Name);
        }

        

        public Course()
        {

        }
    }
}
