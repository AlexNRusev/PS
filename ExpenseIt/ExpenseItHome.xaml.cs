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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window, INotifyPropertyChanged
    {
        private DateTime _lastChecked;
        public ObservableCollection<string> PersonsChecked { get; set; }
        public DateTime LastChecked
        {
            get { return _lastChecked; }
            set
            {
                _lastChecked = value;

                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
                }

            }
        }

        public ExpenseItHome()
        {
            InitializeComponent();

            LastChecked = DateTime.Now;
            this.DataContext = this;
            PersonsChecked = new ObservableCollection<string>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            
            expenseReport.Show();

        }

        private void button_Greeting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void peopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            PersonsChecked.Add((peopleListBox.SelectedItem as System.Xml.XmlElement).Attributes["Name"].Value);
        }
    }
}
