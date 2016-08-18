using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySimpleMvcProject.Models
{
    public class StudentList
    {
        public static List<Student> studentList = new List<Student>();
        public static bool isDeleted;
        //public static string message = "";

        public static void AddStudentToList(string name, string surname)
        {
            Student s = new Student();
            s.Name = name;
            s.Surname = surname;
            s.RegisterDate = DateTime.Now;
            studentList.Add(s);
        }

        public static void DeleteStudentFromList(Student std)
        {
            var index = studentList.FindIndex(w => w.Name == std.Name && w.Surname == std.Surname); // if condition is not matched, returns -1
            if (index == -1)
            {
                isDeleted = false;
            }
            else
            {
                isDeleted = true;
                studentList.RemoveAt(index);
            }
        }

        public static void SortStudentList()
        {
            var sortedList = studentList.OrderByDescending(d => d.RegisterDate);
            studentList = sortedList.ToList();
        }
    }
}