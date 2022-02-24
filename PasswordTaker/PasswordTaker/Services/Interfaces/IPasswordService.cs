namespace PasswordTaker.Services.Interfaces;

public interface IPasswordService
{
    string SecureWord { get; }

    string TargetString { get; }

    string BuildPassword();
}