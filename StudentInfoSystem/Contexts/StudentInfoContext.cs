
using StudentInfoSystem.Migrations;
using StudentInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentInfoContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<StudentStatus> StudentStatuses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        
        public DbSet<LogAttempt> Logs { get; set; }
        

        public StudentInfoContext() : base("name=MyConnectionString")
        {
            //Database.SetInitializer(new StudentInfoInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentInfoContext, Configuration>());

        }


    }
}
