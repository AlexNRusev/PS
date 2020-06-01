using StudentInfoSystem.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private ICommand _loginCommand;
        private User _user;
        private bool _canLogin = true;
        private Window _loginWindow;
        
        public LoginViewModel(Login login)
        {
            LoginCommand = new RelayCommand(Login, param => _canLogin);
            _loginWindow = login;
        }

        //public string Username
        //{
        //    get { return _username; }
        //    set
        //    {
        //        if (_username != value)
        //        {
        //            _username = value;
        //            OnPropertyChanged(nameof(Username));
        //        }
        //    }
        //}

        //public string Password
        //{
        //    get { return _password; }
        //    set
        //    {
        //        if (_password != value)
        //        {
        //            _password = value;
        //            OnPropertyChanged(nameof(Password));
        //        }
        //    }
        //}

        public string GroupBoxContent { get => "Вход в системата"; }
        public string UsernameLabel { get => "Потребителско име"; }
        public string PasswordLabel { get => "Парола"; }
        public string LoginButtonContent { get => "Влез"; }


        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register(nameof(Username), typeof(string), typeof(LoginViewModel), new PropertyMetadata(""));

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register(nameof(Password), typeof(string), typeof(LoginViewModel), new PropertyMetadata(""));

        public ICommand LoginCommand
        {
            get { return _loginCommand; }
            set { _loginCommand = value; }
        }
        private void Login(object parameter)
        {
            var _loginValidation = new LoginValidation(Username, Password, ActionOnError);
            if (_loginValidation.ValidateUserInput(ref _user))
            {
                var studentValidation = new StudentValidation(ActionOnError);

                if (_user != null)
                {
                    var student = studentValidation.GetStudentDataByUser(_user);

                    var mainWindow = new MainWindow(student);
                    mainWindow.Show();
                    _loginWindow.Close();
                }
            }
        }

        private static void ActionOnError(string s)
        {
            MessageBox.Show(s);
        }

        
    }
}
