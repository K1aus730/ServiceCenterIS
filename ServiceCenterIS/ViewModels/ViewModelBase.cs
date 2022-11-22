using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ServiceCenterIS.ViewModels
{
    interface IGettingPassword
    {
        string GetPassword();
    }
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void PropertyChange([CallerMemberName] string PropertyName = "") 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

        protected string _title;

 
        public string Title
        {
            get => _title;
            protected set
            {
                if (_title != value)
                {
                    _title = value;
                    PropertyChange();
                }
            }
        }


    }
}
