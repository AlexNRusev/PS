using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace StudentInfoSystem
{
    public class LoginValidation
    {
        private const int _maxUserAttempts = 3;
        private static TimeSpan _dangerousTimePeriod = new TimeSpan(0, 3, 0);
        private static TimeSpan _timeLocked = new TimeSpan(2, 0, 0);
        private static string _username;
        private static string _password;
        //private Logger _logger;

        private static string _errorMessage;

        private static ActionOnError _actionOnErrorFunction;

        public delegate void ActionOnError(string errorMsg);

        public LoginValidation(string username, string password, ActionOnError actionOnErrorFunction)
        {
            _username = username;
            _password = password;
            _actionOnErrorFunction = actionOnErrorFunction;
        }

        private static UserRoles _currentUserRole;
        public static UserRoles CurrentUserRole
        {
            get { return _currentUserRole; }
            private set { }
        }

        public static string CurrentUserUsername => _username;

        public static string CurrentUserPassword => _password;

        public bool ValidateUserInput(ref User user)
        {
            if (UsernameLocked())
            {
                _actionOnErrorFunction(_errorMessage);

                return false;
            }

            if (!IsInputValid())
            {
                // _errorMessage - in method declaration
                return false;
            }

            if (!UserAuthenticationSuccess(ref user))
            {

                _actionOnErrorFunction(_errorMessage);

                Logger.LogToAttempts(_username, LoginStatusCode.TRY);
                if (ShouldBeLocked())
                {
                    Logger.LogToAttempts(_username, LoginStatusCode.LOCKED);
                }

                return false;
            }

            _currentUserRole = user.Role;
            Logger.LogActivity("Успешен Login");
            Logger.LogToAttempts(_username, LoginStatusCode.SUCCESS);
            return true;
        }

        private static bool IsInputValid()
        {
            return ValidateUserinput(_username, string.Format("Потребителско име"))
                && ValidateUserinput(_password, string.Format("Парола"));
        }

        private static bool ValidateUserinput(string field, string errorFieldPlaceholder)
        {
            if (string.IsNullOrEmpty(field))
            {
                _actionOnErrorFunction(string.Format("Полето '{0}' не е въведено", errorFieldPlaceholder));
                return false;
            }

            if (field.Length < 5)
            {
                _actionOnErrorFunction(string.Format("Дължината на полето '{0}' трябва да е повече от 5 символа", errorFieldPlaceholder));
                return false;
            }
            return true;
        }

        private static bool UsernameLocked()
        {
            var attempts = Logger.GetAttempts();

            if (attempts != null && attempts.Where(
                x => x.Username == _username &&
                x.Time > DateTime.Now.Subtract(_timeLocked) &&
                x.StatusCode == LoginStatusCode.LOCKED)
                .ToList().Count() > 0)
            {
                _errorMessage = "Профилът ти е временно заключен!";
                return true;
            }

            return false;
        }

        private static bool UserAuthenticationSuccess(ref User user)
        {
            user = UserData.IsUserPassCorrect(_username, _password);

            if (user == null)
            {
                _errorMessage = "Грешно име или парола!";
                return false;
            }

            return true;
        }

        private static bool ShouldBeLocked()
        {
            var logAttempts = Logger.GetAttempts();
            if (logAttempts == null)
                return false;

            var filtered = logAttempts.Where(x =>
            x.Username == _username &&
            x.Time > DateTime.Now.Subtract(_dangerousTimePeriod));

            if (filtered == null || filtered.Count() < _maxUserAttempts)
                return false;

            return filtered.Skip(filtered.Count() - _maxUserAttempts)
                .Where(x => x.StatusCode == LoginStatusCode.TRY).Count() == _maxUserAttempts;
        }

    }
}
