using StudentInfoSystem.Commands;
using StudentInfoSystem.Data;
using StudentInfoSystem.Models;
using StudentInfoSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private ICommand _exitCommand;
        private ICommand _clearCommand;
        //private Student _student;
        //private List<string> _degrees;
        //private List<string> _studentStatusChoices;
        //private List<string> _faculties;
        private MainWindow _mainWindow;
        private StudentRepository _studentRepository;

        public MainWindowViewModel(Student student, MainWindow mainWindow)
        {
            Student = student ?? new Student();
            _mainWindow = mainWindow;

            ExitCommand = new RelayCommand(Exit, param => CanExit);
            ClearCommand = new RelayCommand(Clear, param => true);

            _studentRepository = new StudentRepository();

            StudentStatusChoices = _studentRepository.FillStudStatusChoices().ToList();
            Faculties = FacultyData.TestFaculties.Select(f => f.Name).ToList();
            Degrees = Enum.GetNames(typeof(Degree)).Cast<string>().ToList();
        }

        

        #region UIContent
        public string ClearButtonContent { get => "Clear"; }
        public string ExitButtonContent { get => "Exit"; }

        public string GroupBoxPersonalInfo { get => "Лични данни"; }
        public string GroupBoxStudentInfo { get => "Информация за студента"; }

        public string LabelFirstName { get => "Име:"; }
        public string LabelMiddleName { get => "Презиме:"; }
        public string LabelLastName { get => "Фамилия"; }
        public string LabelFaculty { get => "Факултет:"; }
        public string LabelSpeciality { get => "Специалност:"; }
        public string LabelDegree { get => "ОКС:"; }
        public string LabelStatus { get => "Статус:"; }
        public string LabelFacultyNumber { get => "Фак.номер:"; }
        public string LabelCourse { get => "Курс:"; }
        public string LabelStream { get => "Поток:"; }
        public string LabelGroup { get => "Група:"; }

        #endregion


        //public Student Student
        //{
        //    get => _student;
        //    set
        //    {
        //        _student = value;
        //        OnPropertyChanged("Student");
        //    }
        //}

        //public List<string> StudentStatusChoices
        //{
        //    get { return _studentStatusChoices; }
        //    set
        //    {
        //        _studentStatusChoices = value;
        //        OnPropertyChanged("StudentStatusChoices");
        //    }
        //}

        //public List<string> Faculties
        //{
        //    get { return _faculties; }
        //    set
        //    {
        //        _faculties = value;
        //        OnPropertyChanged("Faculties");
        //    }
        //}

        //public List<string> Degrees
        //{
        //    get { return _degrees; }
        //    set
        //    {
        //        _degrees = value;
        //        OnPropertyChanged("Degrees");
        //    }
        //}

        public Student Student
        {
            get { return (Student)GetValue(StudentProperty); }
            set { SetValue(StudentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Student.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StudentProperty =
            DependencyProperty.Register(nameof(Student), typeof(Student), typeof(MainWindowViewModel), new PropertyMetadata(null));



        public List<string> StudentStatusChoices
        {
            get { return (List<string>)GetValue(StudentStatusChoicesProperty); }
            set { SetValue(StudentStatusChoicesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StudentStatusChoices.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StudentStatusChoicesProperty =
            DependencyProperty.Register(nameof(StudentStatusChoices), typeof(List<string>), typeof(MainWindowViewModel));


        public List<string> Faculties
        {
            get { return (List<string>)GetValue(FacultiesProperty); }
            set { SetValue(FacultiesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Faculties.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FacultiesProperty =
            DependencyProperty.Register(nameof(Faculties), typeof(List<string>), typeof(MainWindowViewModel));



        public List<string> Degrees
        {
            get { return (List<string>)GetValue(DegreesProperty); }
            set { SetValue(DegreesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Degrees.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DegreesProperty =
            DependencyProperty.Register(nameof(Degrees), typeof(List<string>), typeof(MainWindowViewModel));




        #region ClearCommand

        public ICommand ClearCommand
        {
            get { return _clearCommand; }
            set { _clearCommand = value; }
        }

        private void Clear(object parameter)
        {
            Student = new Student().CloneObject<Student>();
        }

        #endregion //ClearCommand


        #region ExitCommand
        public ICommand ExitCommand
        {
            get { return _exitCommand; }
            set { _exitCommand = value; }
        }

        private void Exit(object parameter)
        {
            var messageBoxResult = MessageBox.Show("Наистина ли искате да излезете", "", MessageBoxButton.YesNoCancel);
            if (messageBoxResult == MessageBoxResult.Yes)
                _mainWindow.Close();
        }

        private bool CanExit
        {
            get { return true; }
            set { }
        }
        #endregion // ExitCommand - Action, Predicate

        //#region OnPropertyChanged
        //public event PropertyChangedEventHandler PropertyChanged;

        //private void Student_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    OnPropertyChanged(e.PropertyName);
        //}



        //protected void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
        //#endregion
    }
}
