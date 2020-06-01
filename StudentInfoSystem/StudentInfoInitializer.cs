using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentInfoInitializer : DropCreateDatabaseAlways<StudentInfoContext>
    {
        protected override void Seed(StudentInfoContext context)
        {
            
            if(!context.Users.Any())
            context.Users.AddRange(UserData.TestUsers);

            if(!context.Students.Any())
                context.Students.AddRange(StudentData.TestStudents);

            if(!context.StudentStatuses.Any())
                context.StudentStatuses.AddRange(StudentStatusData.StudentStatuses);

            base.Seed(context);
        }
    }
}
