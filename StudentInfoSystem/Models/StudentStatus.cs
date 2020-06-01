using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentStatus
    {
        [Key]
        public int StudentStatusId { get; set; }

        public string StatusDescription { get; set; }

        public ICollection<Student> Students { get; set; }

        //public StudentStatus() { }

        //public StudentStatus(string statusDesription)
        //{
        //    StatusDescription = statusDesription;
        //}
    }
}
