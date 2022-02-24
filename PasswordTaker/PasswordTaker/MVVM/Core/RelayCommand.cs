using System;
using System.Windows.Input;

namespace PasswordTaker.MVVM.Core;

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool>? _canExecute;


    public RelayCommand(Action<object> execute, Func<object, bool>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }


    public event EventHandler? CanExecuteChanged
    {
        add 
        { 
            CommandManager.RequerySuggested += value; 
        }
        remove
        {
            CommandManager.RequerySuggested -= value;
        }
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute is null || _canExecute(ObjectIsNotNull(parameter));
    }

    public void Execute(object? parameter)
    {
        _execute?.Invoke(ObjectIsNotNull(parameter));
    }

    private static object ObjectIsNotNull(object? parameter)
    {
        return parameter is null ? string.Empty : parameter;
    }
}