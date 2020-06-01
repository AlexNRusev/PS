using System;
using System.IO;
using System.Text;

namespace UserLogin
{
    class Program
    {
        private const int minOptionSelection = 0;
        private const int adminMaxOptionSelection = 4;

        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write("Въведи потребителско име: ");
            //var username = Console.ReadLine();
            //Console.Write("Въведи парола: ");
            //var password = Console.ReadLine();

            //var login = new LoginValidation(username, password, ActionOnError);

            //User user = null;

            //if (login.ValidateUserInput(ref user))
            //{
            //    Console.WriteLine(user.ToString());
            //    PrintCurrentUserRole();
            //    PrintMenu(user);
            //}
        }

        //        public static void ActionOnError(string s)
        //        {
        //            Console.WriteLine("!!! " + s + " !!!");

        //        }

        //        private static void PrintCurrentUserRole()
        //        {
        //            var format = "Роля: ";

        //            switch (LoginValidation.CurrentUserRole)
        //            {
        //                case UserRoles.ADMIN:
        //                    Console.WriteLine(format + UserRoles.ADMIN.ToString());
        //                    break;
        //                case UserRoles.INSPECTOR:
        //                    Console.WriteLine(format + UserRoles.INSPECTOR.ToString());
        //                    break;
        //                case UserRoles.PROFESSOR:
        //                    Console.WriteLine(format + UserRoles.PROFESSOR.ToString());
        //                    break;
        //                case UserRoles.STUDENT:
        //                    Console.WriteLine(format + UserRoles.STUDENT.ToString());
        //                    break;
        //                default:
        //                    Console.WriteLine(format + UserRoles.ANONYMOUS.ToString());
        //                    break;
        //            }
        //        }

        //        private static void PrintMenu(User user)
        //        {
        //            if (user.Role == UserRoles.ADMIN)
        //            {
        //                Console.WriteLine("0: Изход");
        //                Console.WriteLine("1: Промяна на роля на потребител");
        //                Console.WriteLine("2: Промяна на активност на потребител");
        //                Console.WriteLine("3: Списък на потребителите");
        //                Console.WriteLine("4: Преглед на лог на активност");


        //                var option = 0;
        //                var username = string.Empty;

        //                while (OptionIsInRange(option, minOptionSelection, adminMaxOptionSelection))
        //                {
        //                    Console.Write("Въведете опция: ");
        //                    int.TryParse(Console.ReadLine(), out option);

        //                    switch (option)
        //                    {
        //                        case 0:
        //                            Logger.LogActivity("Logout");
        //                            return;
        //                        case 1:
        //                            username = EnterUsername();
        //                            Console.Write("Въведи нова потребителска роля: ");
        //                            if (Enum.TryParse<UserRoles>(Console.ReadLine(), out var newRole))
        //                            {
        //                                UserData.AssignUserRole(username, newRole);
        //                            }
        //                            break;
        //                        case 2:
        //                            username = EnterUsername();
        //                            Console.Write("Въведи нова дата на активност (във формат yyyy-mm-dd): ");
        //                            if (DateTime.TryParse(Console.ReadLine(), out var newDate))
        //                            {
        //                                UserData.SetUserActiveTo(username, newDate);
        //                            }
        //                            break;
        //                        case 3:
        //                            UserData.TestUsers.ForEach(u => Console.WriteLine(u.ToString()));
        //                            break;
        //                        case 4:
        //                            Console.WriteLine(Logger.GetCurrentSessionActivities());
        //                            break;
        //                        default:
        //                            Console.WriteLine("Грешна команда!\n");
        //                            break;
        //                    }
        //                }
        //            }
        //        }

        //        private static bool OptionIsInRange(int option, int minOptionSelection, int maxOptionSelection)
        //        {
        //            return option >= minOptionSelection && option <= maxOptionSelection;
        //        }

        //        private static string EnterUsername()
        //        {
        //            Console.Write("Въведи потребителско име: ");
        //            return Console.ReadLine();
        //        }
    }
}
