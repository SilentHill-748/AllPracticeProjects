using PasswordTaker.MVVM.Core;

namespace PasswordTaker.MVVM.Model;

public class PasswordModel : ObservableObject
{
    private string _password;
    private string _url;


    public PasswordModel()
    {
        _password = string.Empty;
        _url = string.Empty;
    }


    public string Password
    {
        get { return _password; }
        set
        {
            _password = value;
            OnPropertyChanged("Password");
        }
    }

    public string Url
    {
        get { return _url; }
        set
        {
            _url = value;
            OnPropertyChanged("Url");
        }
    }
}