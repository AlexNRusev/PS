using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; }
        public string FacultyNumber { get; set; }
        public int Course { get; set; }
        public int Stream { get; set; }
        public int Group { get; set; }

        public Student() { }

        public Student(string firstName, string middleName, string lastName, string faculty, 
            string speciality, string degree, string status, string facultyNumber, int course,
            int stream, int group)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Speciality = speciality;
            Degree = degree;
            Status = status;
            FacultyNumber = facultyNumber;
            Course = course;
            Stream = stream;
            Group = group;
        }

        public Student _FirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public Student _MiddleName(string middleName)
        {
            MiddleName = middleName;
            return this;
        }

        public Student _LastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public Student _Faculty(string faculty)
        {
            Faculty = faculty;
            return this;
        }

        public Student _Speciality(string speciality)
        {
            Speciality = speciality;
            return this;
        }

        public Student _Degree(string degree)
        {
            Degree = degree;
            return this;
        }

        public Student _Status(string status)
        {
            Status = status;
            return this;
        }

        public Student _FacultyNumber(string facultyNumber)
        {
            FacultyNumber = facultyNumber;
            return this;
        }

        public Student _Course(int course)
        {
            Course = course;
            return this;
        }

        public Student _Stream(int stream)
        {
            Stream = stream;
            return this;
        }

        public Student _Group(int group)
        {
            Group = group;
            return this;
        }

    }
}
