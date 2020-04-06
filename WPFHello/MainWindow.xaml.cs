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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            var s = new StringBuilder();

            foreach(var item in MainGrid.Children)
            {
                if(item is TextBox)
                {
                    s.Append(((TextBox)item).Text);
                    s.Append(" ");
                }
            }

            MessageBox.Show("Здрасти " + s.ToString());

            MyMessage myMessage = new MyMessage();
            myMessage.Show();
        }

        

        private int Factorial(int n)
        {
            int res = 1;
            for(int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Наистина ли искате да излезете?", "нещо", MessageBoxButton.YesNoCancel);
            if (res == MessageBoxResult.No)
                e.Cancel = true;
            if (res == MessageBoxResult.Cancel)
                e.Cancel = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            peopleListBox.Items.Add("Gosho");
            peopleListBox.Items.Add("Tosho");

            //peopleListBox.SelectedItem = Mary;

            //MessageBox.Show((peopleListBox.SelectedItem as ListBoxItem).Content.ToString());

        }

    }
}
