using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    static class StudentStatusData
    {
        static private List<StudentStatus> _studentStatuses = new List<StudentStatus>();

        static public List<StudentStatus> StudentStatuses
        {
            get
            {
                ResetStudentStatuses();
                return _studentStatuses;
            }
        }

        private static void ResetStudentStatuses()
        {

            if (_studentStatuses == null || !_studentStatuses.Any())
            {
                FillStudentStatuses();
            }
        }

        private static void FillStudentStatuses()
        {
            _studentStatuses = new List<StudentStatus>()
            {
                new StudentStatus
                {
                    StudentStatusId = 1,
                    StatusDescription = "Редовен",
                    Students = new List<Student>()
                },
                new StudentStatus
                {
                    StudentStatusId = 2,
                    StatusDescription = "Самост. подготовка",
                    Students = new List<Student>()
                },
                new StudentStatus
                {
                    StudentStatusId = 3,
                    StatusDescription = "Задочен",
                    Students = new List<Student>()
                },
                new StudentStatus
                {
                    StudentStatusId = 4,
                    StatusDescription = "Прекъснал по успех",
                    Students = new List<Student>()
                },
                new StudentStatus
                {
                    StudentStatusId = 5,
                    StatusDescription = "Прекъснал по болест",
                    Students = new List<Student>()
                },
                new StudentStatus
                {
                    StudentStatusId = 5,
                    StatusDescription = "Прекъснал по майчинство",
                    Students = new List<Student>()
                }
            };
        }
    }
}
