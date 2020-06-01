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

namespace StudentInfoSystem.VisualControls
{
    /// <summary>
    /// Interaction logic for MyToggleButton.xaml
    /// </summary>
    public partial class MyToggleButton : UserControl
    {
        public MyToggleButton()
        {
            InitializeComponent();
        }



        public bool Checked
        {
            get { return (bool)GetValue(CheckedProperty); }
            set { SetValue(CheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Checked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckedProperty =
            DependencyProperty.Register(nameof(Checked), typeof(bool), typeof(MyToggleButton), new PropertyMetadata(true));


    }
}
