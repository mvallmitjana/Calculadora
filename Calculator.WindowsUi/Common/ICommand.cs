using System.ComponentModel;

namespace Calculator.WindowsUi.Common
{
    public interface ICommand : INotifyPropertyChanged
    {
        bool CanExecute { get; }
        void Execute();
    }
}
