using System;

namespace Exercise4
{
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explaination begins");
        }
    }
}



namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            bool debug = false;

            // Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();

            // Create a tudent, set his age to 21, and tell him to Greet and display his age.
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            // Create a teacher, 30 years old, and ask him to say hello and then explain
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)
                Console.ReadLine();


        }
    }
}

namespace Exercise4
{
    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }
}



namespace Exercise4
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
