using System;

namespace UserLogin
{
    public class User
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public string FacultyNumber { get; set; }

        public UserRoles Role { get; set; }

        public DateTime Created { get; } = DateTime.UtcNow;

        public DateTime ActiveUntil { get; set; } = DateTime.MaxValue;

        /*
        public User()
        { }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        */

        public User(string username, string password, string facultyNumber, UserRoles role)
        {
            Username = username;
            Password = password;
            FacultyNumber = facultyNumber;
            Role = role;
        }


        public override string ToString()
        {
            return string.Format("Потребителско име: {0}\nПарола: {1}\nФакултетен номер: {2}\nРоля: {3}\n",
                Username, Password, FacultyNumber, Role.ToString());
        }


    }
}
