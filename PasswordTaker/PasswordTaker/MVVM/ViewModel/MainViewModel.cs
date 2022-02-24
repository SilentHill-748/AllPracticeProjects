using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using PasswordTaker.MVVM.Core;
using PasswordTaker.MVVM.Model;
using PasswordTaker.Services.Interfaces;
using PasswordTaker.Services;

namespace PasswordTaker.MVVM.ViewModel;

public class MainViewModel : ObservableObject
{
    private PasswordModel _passwordModel;
    private RelayCommand _generatePasswordCommand;
    private string _urlPattern;


    public MainViewModel()
    {
        _passwordModel = new PasswordModel();
        _generatePasswordCommand = new RelayCommand(GeneratePassword, CanGeneratePassword);
        _urlPattern = @"^((http?|https?|ftp)\:\/\/)?([^wW.]|www\.)([a-z]{1,})((\.[a-z0-9-])|([a-z0-9-]))*\.([a-z]{2,6})(\/?)(.*)$";
    }


    public PasswordModel PasswordModel
    {
        get { return _passwordModel; }
        set 
        {
            _passwordModel = value;
            OnPropertyChanged("PasswordModel");
        }
    }

    public string Url
    {
        get => _passwordModel.Url;
        set
        {
            _passwordModel.Url = value;
            OnPropertyChanged("Url");
        }
    }

    public string Password
    {
        get => _passwordModel.Password;
        set
        {
            _passwordModel.Password = value;
            OnPropertyChanged("Password");
        }
    }

    public RelayCommand GeneratePasswordCommand
    {
        get => _generatePasswordCommand;
    }


    private void GeneratePassword(object parameter)
    {
        string validUrl = Regex.Match(Url, _urlPattern).Value;

        // [www.microsoft.net.com] => [microsoftnet]
        string head = validUrl.Split('.')[^2];

        PasswordService passwordService = new(head);
        Password = passwordService.BuildPassword();
    }

    private bool CanGeneratePassword(object parameter)
    {
        return Regex.IsMatch(Url, _urlPattern);
    }
}