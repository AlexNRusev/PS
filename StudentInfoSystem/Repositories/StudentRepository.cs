using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentRepository : IDisposable
    {
        private StudentInfoContext _context = new StudentInfoContext();

        public StudentRepository()
        {
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        //public bool TestStudentsIfEmpty()
        //{
        //    var count = context.Students.Count();
        //    return count == 0;
        //}

        //public void CopyTestStudents()
        //{
        //    if (TestStudentsIfEmpty())
        //    {
        //        foreach (var st in StudentData.TestStudents)
        //        {
        //            context.Students.Add(st);
        //        }

        //        context.SaveChanges();
        //    }
        //}

        public Student GetStudentDataByFacultyNumber(string facultyNumber)
        {
            var student = _context.Students.FirstOrDefault(s => s.FacultyNumber == facultyNumber);
            student.Status = _context.StudentStatuses.FirstOrDefault(ss => ss.StudentStatusId == student.StudentStatusId);
            student.Faculty = _context.Faculties.FirstOrDefault(f => f.FacultyId == student.FacultyId);
            return student;
        }

        public IList<string> FillStudStatusChoices()
        {
            return _context.StudentStatuses.Select(x => x.StatusDescription).ToList();
        }
    }
}