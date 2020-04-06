using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UserLogin
{
    static class UserData
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
                new User("Pesho", "admin", "-", UserRoles.ADMIN),
                new User("Gosho", "Gosho", "1", UserRoles.STUDENT),
                new User("Tosho", "Tosho", "2", UserRoles.STUDENT)
            };
        }
    }
}
