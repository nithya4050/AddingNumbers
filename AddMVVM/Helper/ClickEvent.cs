using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddMVVM.Helper
{
    public class ClickEvent : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public readonly Action _execute;


        public ClickEvent(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute();
        }
    }
}
