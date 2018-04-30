using System;
using System.Collections;
using System.Collections.Generic;
namespace GenericList
{
    class Student{
        
        public Student(string first, string last, int age, string prog)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
            this.Program = prog;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");
            students.Add(stud1);
            students.Add(stud2);
            students.Add(stud3);
            foreach(Student stud in students){
                Console.WriteLine(stud.FirstName);
            }
        }
    }
}
