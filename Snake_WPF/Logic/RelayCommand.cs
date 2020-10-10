using System;
using System.Windows.Input;

namespace Snake_WPF.Logic
{
    public class RelayCommand : ICommand
    {
        #region Fields

        private readonly Action executeAction;
        private readonly Func<bool> canExecuteFunc;

        #endregion Fields

        #region Constructors

        public RelayCommand(Action executeAction)
        {
            this.executeAction = executeAction ?? throw new ArgumentNullException(nameof(executeAction));
        }

        public RelayCommand(Action executeAction, Func<bool> canExecuteFunc) : this(executeAction)
        {
            this.canExecuteFunc = canExecuteFunc ?? throw new ArgumentNullException(nameof(canExecuteFunc));
        }

        #endregion Constructors

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return canExecuteFunc is null || canExecuteFunc.Invoke();
        }

        public void Execute(object parameter)
        {
            executeAction.Invoke();
        }

        public event EventHandler CanExecuteChanged;

        #endregion ICommand Members
    }
}
