using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentInfoSystem.ViewModels
{
    public abstract class ViewModelBase : DependencyObject
    {
        //public string this[string columnName] => OnValidate(columnName);

        //public string Error => throw new NotImplementedException();

        //protected virtual string OnValidate(string propertyName)
        //{
        //    var context = new ValidationContext(this)
        //    {
        //        MemberName = propertyName
        //    };

        //    var results = new Collection<ValidationResult>();
        //    var isValid = Validator.TryValidateObject(this, context, results);

        //    return !isValid ? results[0].ErrorMessage : null;
        //}


        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

    }
}
