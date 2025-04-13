using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddMVVM.Helper
{
    public class Notify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void onproperty(string pname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pname));
        }
    }

}
