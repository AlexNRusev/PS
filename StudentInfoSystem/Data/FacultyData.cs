using StudentInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    static public class FacultyData
    {
        static private List<Faculty> _testFaculties = new List<Faculty>();

        static public List<Faculty> TestFaculties
        {
            get
            {
                ResetTestFacultyData();
                return _testFaculties;
            }
            private set { }
        }

        private static void ResetTestFacultyData()
        {

            if (_testFaculties == null || !_testFaculties.Any())
            {
                FillFaculties();
            }
        }

        private static void FillFaculties()
        {
            _testFaculties = new List<Faculty>()
            {

                new Faculty
                {
                    FacultyId = 1,
                    Name = "Автоматика",
                    Students = new List<Student>()
                },
                new Faculty
                {
                    FacultyId = 2,
                    Name = "Електротехнически",
                    Students = new List<Student>()
                },
                new Faculty
                {
                    FacultyId = 3,
                    Name = "Машиностроителен",
                    Students = new List<Student>()
                },
                new Faculty
                {
                    FacultyId = 4,
                    Name = "Телекомуникации",
                    Students = new List<Student>()
                },
                new Faculty
                {
                    FacultyId = 5,
                    Name = "Компютърни системи и технологии",
                    Students = new List<Student>()
                }
            };
        }
    }
}
