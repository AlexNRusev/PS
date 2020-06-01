using StudentInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    static class StudentData
    {
        static private List<Student> _testStudents = new List<Student>();

        static public List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return _testStudents;
            }
            private set { }
        }

        private static void ResetTestStudentData()
        {

            if (_testStudents == null || !_testStudents.Any())
            {
                FillStudents();
            }
        }

        private static void FillStudents()
        {
            _testStudents = new List<Student>()
            {
                //new Student("Tosho", "Tosho", "Tosho", "FKST", "KSI", "Master", StudentStatusData.StudentStatuses.ElementAt(2), "2", 3, 9, 39),
                //new Student("Gosho", "Goshev", "Goshev", "FKSI", "KSI", "Bachelor", StudentStatusData.StudentStatuses.ElementAt(0), "1", 3, 9, 39),
                //new Student("Alexander", "Nikolaev", "Rusev", "FKSI", "KSI", "Bachelor", StudentStatusData.StudentStatuses.ElementAt(0), "121217011", 3, 9, 39)

                //new Student("Tosho", "Tosho", "Tosho", "FKST", "KSI", "Master", "2", 3, 9, 39, 2),
                //new Student("Gosho", "Goshev", "Goshev", "FKSI", "KSI", "Bachelor", "1", 3, 9, 39, 1),
                //new Student("Alexander", "Nikolaev", "Rusev", "FKSI", "KSI", "Bachelor", "121217011", 3, 9, 39, 1) 

                new Student
                {
                    StudentId = 1,
                    FirstName = "Станимир",
                    MiddleName = "Иванов",
                    LastName = "Георгиев",
                    Speciality = "КСИ",
                    Degree = Degree.Bachelor.ToString(),
                    FacultyNumber = "121217057",
                    Course = 3,
                    Stream = 9,
                    Group = 39,
                    FacultyId = 3,
                    StudentStatusId = 1
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Георги",
                    MiddleName = "Спасов",
                    LastName = "Петков",
                    Speciality = "КСИ",
                    Degree = Degree.Master.ToString(),
                    FacultyNumber = "123217102",
                    Course = 3,
                    Stream = 9,
                    Group = 39,
                    FacultyId = 2,
                    StudentStatusId = 2
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Александър",
                    MiddleName = "Николаев",
                    LastName = "Русев",
                    Speciality = "КСИ",
                    Degree = Degree.Bachelor.ToString(),
                    FacultyNumber = "121217011",
                    Course = 3,
                    Stream = 9,
                    Group = 39,
                    FacultyId = 5,
                    StudentStatusId = 1
                },
                //new Student("Gosho", "Goshev", "Goshev", "KSI", "Bachelor", "1", 3, 9, 39, 1, 1),
                //new Student("Alexander", "Nikolaev", "Rusev", "KSI", "Bachelor", "121217011", 3, 9, 39, 1, 3)

            };
        }
    }
}
