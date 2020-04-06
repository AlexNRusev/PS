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
            _testStudents = new List<Student>(1)
            {
                new Student("Tosho", "Tosho", "Tosho", "FKST", "KSI", "bakalavur", "redoven", "2", 3, 9, 39),

                new Student()._FirstName("Gosho")._MiddleName("Goshev")._LastName("Goshev")._Faculty("FKSI")._Speciality("KSI")
                ._Degree("bachelor")._Status("redoven")._FacultyNumber("1")._Course(3)._Stream(9)._Group(39)
            };
        }
    }
}
