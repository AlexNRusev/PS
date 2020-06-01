using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        private StudentRepository _studentRepository;
        private static ActionOnError _actionOnErrorFunction; 

        public delegate void ActionOnError(string s);

        public StudentValidation(ActionOnError actionOnErrorFunction)
        {
            _studentRepository = new StudentRepository();
            _actionOnErrorFunction = actionOnErrorFunction;
        }

        public Student GetStudentDataByUser(User user)
        {
            if (user.Role != UserRoles.STUDENT)
            {
                _actionOnErrorFunction("Твоята роля в системата е " + user.Role);
                return null;
            }

            if (user.FacultyNumber == null)
            {
                _actionOnErrorFunction("Няма вписан факултетен номер на твое име!");
                return null;
            }

            if(_studentRepository.GetStudentDataByFacultyNumber(user.FacultyNumber) == null)
            {
                _actionOnErrorFunction("Не си вписан в студентската система с факултетен номер " + user.FacultyNumber);
                return null;
            }
            


            return _studentRepository.GetStudentDataByFacultyNumber(user.FacultyNumber);
        }
    }
}
