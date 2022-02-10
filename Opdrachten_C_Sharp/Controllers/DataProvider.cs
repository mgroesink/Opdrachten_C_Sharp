using Opdrachten_C_Sharp.Models;
using System.Collections.Generic;

namespace Opdrachten_C_Sharp.Controllers
{
    internal static class DataProvider
    {
        public static List<Student> CreateStudents()
        {
            var students = new List<Student>();
            var student = new Student("0123456");
            student.Voornaam = "Jacob";
            student.Achternaam = "Meulenbroek";
            student.Klas = "I9AOy";
            student.Geboortedatum = new System.DateTime(1999, 10, 10);
            students.Add(student);
            student = new Student("0234567", "Truus", "Boerkamp");
            students.Add(student);
            student = new Student("0345678", "Yasar", "Yilmaz", "I9AOy", new System.DateTime(2001, 1 , 10));
            students.Add(student);
            students.Add(new Student("0987654")
            {
                Geboortedatum = new System.DateTime(2002, 12, 12),
                Achternaam = "Jacobs",
                Voornaam = "Bob",
                Klas = "I9AOa"
            });
            students.Add(new Student("0987655")
            {
                Geboortedatum = new System.DateTime(2002, 12, 25),
                Achternaam = "Waanders",
                Voornaam = "Goedele",
                Klas = "I9AOy"
            });
            return students;
        }
    }
}