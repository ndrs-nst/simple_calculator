using System;

namespace SimpleCalculator.ViewModels
{
    public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action execute, Func<bool> canExecute = null)
            : base(param => execute(), canExecute == null ? (Func<object, bool>)(_ => true) : (_ => canExecute()))
        {
        }
    }

    public class RelayCommand<T>
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));

            _execute = execute;
            _canExecute = canExecute ?? (_ => true);
        }

        public bool CanExecute(T parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(T parameter)
        {
            if (CanExecute(parameter))
                _execute(parameter);
        }
    }
}