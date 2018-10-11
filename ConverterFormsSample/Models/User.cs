using System;
using System.ComponentModel;

namespace ConverterFormsSample.Models
{
    public class User: INotifyPropertyChanged
    {
        public string Name { get; set; }

        public UserType Role { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public enum UserType{
        Admin, Employee, Manager, Client
    }
}
