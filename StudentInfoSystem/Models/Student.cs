using StudentInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        //[Required]
        //[MaxLength(30)]
        public string FirstName { get; set; }

        //[Required]
        //[MaxLength(30)]
        public string MiddleName { get; set; }

        //[Required]
        //[MaxLength(30)]
        public string LastName { get; set; }

        //[Required]
        public Faculty Faculty { get; set; }

        //[Required]
        //[MaxLength(30)]
        public string Speciality { get; set; }

        ////[Required]
        ////[MaxLength(30)]
        public string Degree { get; set; }

        ////[Required]
        public StudentStatus Status { get; set; }

        ////[Required]
        ////[MaxLength(20)]
        public string FacultyNumber { get; set; }

        ////[Required]
        public int Course { get; set; }

        ////[Required]
        public int Stream { get; set; }

        ////[Required]
        public int Group { get; set; }

        public byte[] Photo { get; set; }

        ////[ForeignKey("Status")]
        public int StudentStatusId { get; set; }

        ////[ForeignKey("Faculty")]
        public int FacultyId { get; set; }

        //public Student() { }

        //public Student(string firstName, string middleName, string lastName,
        //    string speciality, string degree, string facultyNumber, int course,
        //    int stream, int group, int studentStatusId, int facultyId)
        //{
        //    FirstName = firstName;
        //    MiddleName = middleName;
        //    LastName = lastName;
        //    //Faculty = faculty;
        //    Speciality = speciality;
        //    Degree = degree;
        //    //Status = status;
        //    FacultyNumber = facultyNumber;
        //    Course = course;
        //    Stream = stream;
        //    Group = group;
        //    StudentStatusId = studentStatusId;
        //    FacultyId = facultyId;
        //}
    }
}
