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
    /// Interaction logic for LabelTextBox.xaml
    /// </summary>
    public partial class LabelTextBox : UserControl
    {

        public static readonly DependencyProperty TextContentProperty = DependencyProperty.Register(nameof(TextContent), typeof(string), typeof(LabelTextBox));
        public static readonly DependencyProperty LabelContentProperty = DependencyProperty.Register(nameof(LabelContent), typeof(string), typeof(LabelTextBox));
        public LabelTextBox()
        {
            InitializeComponent();
        }
        public string TextContent
        {
            get { return (string)GetValue(TextContentProperty); }
            set { SetValue(TextContentProperty, value); }
        }
        public string LabelContent
        {
            get { return (string)GetValue(LabelContentProperty); }
            set { SetValue(LabelContentProperty, value); }
        }
    }
}
