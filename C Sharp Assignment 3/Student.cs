using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment_3
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }
        public static void StudentList()
        {
            Student student1 = new Student(1, "name1");
            Student student2 = new Student(2, "name2");
            Student student3 = new Student(3, "name3");
            Student student4 = new Student(4, "name4");
            Student student5 = new Student(5, "name5");

            List<Student> studentsList = new List<Student>();

            studentsList.Add(student1);
            studentsList.Add(student2);
            studentsList.Add(student3);
            studentsList.Add(student4);
            studentsList.Add(student5);

            foreach(var student in studentsList)
            {
                Console.WriteLine("From Student List No."+student.StudentID+" Student name : "+student.StudentName);
            }
        }

        public static void StudentArrayList()
        {
            Student student6 = new Student(6, "name6");
            Student student7 = new Student(7, "name2");
            Student student8 = new Student(8, "name3");
            Student student9 = new Student(9, "name4");
            Student student10 = new Student(10, "name5");

            ArrayList studentsArrayList = new ArrayList();

            studentsArrayList.Add(student6);
            studentsArrayList.Add(student7);
            studentsArrayList.Add(student8);
            studentsArrayList.Add(student9);
            studentsArrayList.Add(student10);


            foreach (var stu in studentsArrayList)
            {
                Student student = (Student)stu;
                Console.WriteLine("From Student ArrayList No." + student.StudentID + " Student name : " + student.StudentName);
            }
        }
    }
}
