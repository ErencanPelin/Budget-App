using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BudgetApp.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            Console.WriteLine("changed!");
            PropertyChanged?.Invoke(sender:this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
