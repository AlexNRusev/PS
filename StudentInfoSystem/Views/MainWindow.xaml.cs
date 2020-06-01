using StudentInfoSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(Student student)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(student, this);
            //FillStudentStatusChoices();
            //DataContext = this;
        }

        //public List<string> StudentStatusChoices { get; set; }

        //private void FillStudentStatusChoices()
        //{
        //    StudentStatusChoices = new List<string>();

        //    using(IDbConnection connection = new SqlConnection(StudentInfoSystem.Properties.Settings.Default.DbConnect))
        //    {
        //        string sqlQuery = @"SELECT StatusDescription FROM StudentStatus";

        //        IDbCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        connection.Open();

        //        command.CommandText = sqlQuery;
        //        IDataReader reader = command.ExecuteReader();

        //        bool notEndOfResult;

        //        notEndOfResult = reader.Read();

        //        while(notEndOfResult)
        //        {
        //            string s = reader.GetString(0);
        //            StudentStatusChoices.Add(s);
        //            notEndOfResult = reader.Read();
        //        }
        //    }
        //}


        //public void ClearAllInputs()
        //{
        //    foreach(var item in MainGrid.Children)
        //    {
        //        if(item is TextBox)
        //        {
        //            ((TextBox)item).Clear();
        //        }
        //    }
        //}

        //public void FillInputsWithData(Student student)
        //{
        //    if (student == null)
        //        return;

            
        //    textBox_FirstName.Text = student.FirstName;
        //    textBox_MiddleName.Text = student.MiddleName;
        //    textBox_LastName.Text = student.LastName;
        //    textBox_Faculty.Text = student.Faculty;
        //    textBox_Speciality.Text = student.Speciality;
        //    textBox_Degree.Text = student.Degree;
        //    textBox_Status.Text = student.Status;
        //    textBox_FacultyNumber.Text = student.FacultyNumber;
        //    textBox_Course.Text = student.Course.ToString();
        //    textBox_Stream.Text = student.Stream.ToString();
        //    textBox_Group.Text = student.Group.ToString();
            
        //}

        //public void EnableControls(bool active)
        //{
        //    foreach(var item in MainGrid.Children)
        //    {
        //        if(item is TextBox)
        //        {
        //            if (active == true)
        //                ((TextBox)item).IsEnabled = true;
        //            else
        //                ((TextBox)item).IsEnabled = false;
        //        }
        //    }
        //}

        //private void button_Exit_Click(object sender, RoutedEventArgs e)
        //{
        //    var messageBoxResult = MessageBox.Show("Наистина ли искате да излезете", "", MessageBoxButton.YesNoCancel);
        //    if (messageBoxResult == MessageBoxResult.Yes)
        //        Close();
        //}

    }
}
