using System;
using System.ComponentModel;
using System.Linq;

namespace TicketRegistration;

internal class RegistrateAdminPageValidation : IDataErrorInfo
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
    public string? PasswordChecker { get; set; }

    public string this[string columnName]
    {
        get
        {
            string ErrorInfo = string.Empty;

            switch (columnName)
            {
                case "Name":
                    if (string.IsNullOrWhiteSpace(Name))
                        ErrorInfo = "Name must be field!";
                    else if (!Name.All(char.IsLetter))
                        ErrorInfo = "Name must contain only letters!";
                    break;
                case "Surname":
                    if (string.IsNullOrWhiteSpace(Surname))
                        ErrorInfo = "Surname must be field!";
                    else if (!Surname.All(char.IsLetter))
                        ErrorInfo = "Surname must contain only letters!";
                    break;
                case "Email":
                    if (string.IsNullOrWhiteSpace(Email))
                        ErrorInfo = "Email must be field!";
                    break;
                case "Phone":
                    if (string.IsNullOrWhiteSpace(Phone))
                        ErrorInfo = "Phone must be field!";
                    else if (!Phone.Skip(1).All(char.IsNumber))
                        ErrorInfo = "Phone must contain only letters!";
                    break;
                case "Login":
                    if (string.IsNullOrWhiteSpace(Login))
                        ErrorInfo = "Login must be field!";
                    break;
                case "Password":
                    if (string.IsNullOrWhiteSpace(Password))
                        ErrorInfo = "Password must be field!";
                    break;
                case "PasswordChecker":
                    if (string.IsNullOrWhiteSpace(PasswordChecker))
                        ErrorInfo = "Password checker must be field!";
                    break;
            }
            return ErrorInfo;
        }
    }

    public string Error => throw new NotImplementedException();
}