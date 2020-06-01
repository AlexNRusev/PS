using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentInfoSystem
{
    public static class UserData
    {
        private static List<User> _testUsers = new List<User>();

        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            private set { }
        }


        public static User IsUserPassCorrect(string username, string password)
        {
            return TestUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public static void SetUserActiveTo(string username, DateTime newDate)
        {
            var user = _testUsers.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                user.ActiveUntil = newDate;
                Logger.LogActivity("Промяна на активност на " + username);
            }
        }

        public static void AssignUserRole(string username, UserRoles newRole)
        {
            var user = _testUsers.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                user.Role = newRole;
                Logger.LogActivity("Промяна на роля на " + username);
            }
        }

        private static void ResetTestUserData()
        {

            if (_testUsers == null || !_testUsers.Any())
            {
                FillUsers();
            }
        }

        private static void FillUsers()
        {
            _testUsers = new List<User>(3)
            {
                new User("pesho", "admin", "0", UserRoles.ADMIN),
                new User("stanimir", "stanimir", "121217057", UserRoles.STUDENT),
                new User("georgi", "georgi", "123217102", UserRoles.STUDENT),
                new User("alexr", "alexr", "121217011", UserRoles.STUDENT)
            };
        }
    }
}
