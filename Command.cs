using System;
using System.Windows.Input;

namespace AStarVisualizer
{
    public class Command<T>: ICommand
    {
        public Action<T> Action { get; set; }

        public void Execute(object obj)
        {
            Console.WriteLine(typeof(T));
            if (Action != null && obj is T parameter)
                Action(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }

        private bool _isEnabled = true;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler CanExecuteChanged;

        public Command(Action<T> action)
        {
            Action = action;
        }
    }
}