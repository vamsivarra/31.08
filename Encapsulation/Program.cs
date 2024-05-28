using System;
namespace AccessSpecifiers
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = "101";
            student.Name = "Mohan Ram";
            student.Email = "mohan@example.com";
            Console.WriteLine("ID = " + student.ID);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);
        }
    }
}