using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        //public Faculty() { }

        //public Faculty(string name)
        //{
        //    Name = name;
        //}

    }
}
