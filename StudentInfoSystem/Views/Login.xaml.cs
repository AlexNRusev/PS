using StudentInfoSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(this);
        }

        //private void button_Login_Click(object sender, RoutedEventArgs e)
        //{
        //    var username = textBox_Username.Text;
        //    var password = passwordBox.Text;

        //    var login = new LoginValidation(username, password, ActionOnError);

        //    User user = null;

        //    if(login.ValidateUserInput(ref user))
        //    {
        //        var mainWindow = new MainWindow();
        //        mainWindow.Show();
        //        Close();

        //        var studentValidation = new StudentValidation(ActionOnError);
        //        var student = studentValidation.GetStudentDataByUser(user);

        //        if(student is Student)
        //        {
        //            mainWindow.FillInputsWithData(student);
        //        }
        //        else
        //        {
        //            mainWindow.EnableControls(false);
        //        }
        //    }
        //}

        //public static void ActionOnError(string s)
        //{
        //    MessageBox.Show(s);
        //}
    }
}
