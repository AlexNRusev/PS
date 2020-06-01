using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;

namespace WpfExample
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private ICommand hiButtonCommand;
        private ICommand toggleExecuteCommand { get; set; }
        private bool canExecute = true;
        private string _message;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }

        public string HiButtonContent
        {
            get { return "Click to Hi"; }
        }

        public bool CanExecute
        {
            get { return this.canExecute; }
            set
            {
                if (this.canExecute == value)
                { return; }
                this.canExecute = value;
            }
        }

        public ICommand ToggleExecuteCommand
        {
            get { return toggleExecuteCommand; }
            set { toggleExecuteCommand = value; }
        }

        public ICommand HiButtonCommand
        {
            get { return hiButtonCommand; }
            set { hiButtonCommand = value; }
        }

        public void ShowMessage(object obj)
        {
            _message = "Hello there...";
            PropertyChanged(this, new PropertyChangedEventArgs("Message"));
        }

        public string Message
        {
            get => _message;
            set { }
        }

        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }
    }
}
