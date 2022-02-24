using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUwpApp.Model
{
    internal class Person : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
