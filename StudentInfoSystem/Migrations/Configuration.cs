namespace StudentInfoSystem.Migrations
{
    using StudentInfoSystem.Data;
    using StudentInfoSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserLogin;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentInfoSystem.StudentInfoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StudentInfoSystem.StudentInfoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            FacultyData.TestFaculties.ForEach(faculty => context.Faculties.AddOrUpdate(faculty));
            StudentStatusData.StudentStatuses.ForEach(studentStatus => context.StudentStatuses.AddOrUpdate(studentStatus));
            //StudentData.TestStudents.ForEach(student => context.Students.AddOrUpdate(s => new { s.FacultyNumber }, student));
            StudentData.TestStudents.ForEach(student => context.Students.AddOrUpdate(student));

            //UserData.TestUsers.ForEach(user => context.Users.AddOrUpdate(u => new { u.Username }, user));

        }
    }
}
