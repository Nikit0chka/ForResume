using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;
public partial class AdminManagePage : Page
{
    private RegistrateAdminPageValidation _validaitor;
    private AllDbContext _dbContext;

    public AdminManagePage()
    {
        _validaitor = new RegistrateAdminPageValidation();
        _dbContext = new AllDbContext();

        InitializeComponent();
        DataContext = _validaitor;
    }

    #region Events
    private void RegistrateAdminButton_Click(object sender, RoutedEventArgs e)
    {
        User newUser = new()
        {
            Name = NameTxtBx.Text,
            Surname = SurnameTxtBx.Text,
            Email = EmailTxtBx.Text,
            Phone = PhoneTxtBx.Text,
            Login = LoginTxtBx.Text,
            Password = PasswordPasBx.Password,
            Role = "Administraitor"
        };

        _dbContext.Add(newUser);
        _dbContext.SaveChangesAsync();

        MessageBox.Show("Registered successfully!");
    }

    private void DeleteAdminButton_Click(object sender, RoutedEventArgs e)
    {
        //NavigationService.Navigate();
    }
    #endregion

    #region Logic
    private bool IsAllInputCorrect()
    {
        string error = string.Empty;

        if (IsAnyValidationError())
            error += "Check input data!\n";
        if (IsEmailInDb())
            error += "This email is already registered!\n";
        if (IsPhoneInDb())
            error += "This phone is already registered!\n";
        if (IsLoginInDb())
            error += "User with this login is already registered!\n";
        if (!IsPasswordsMatch())
            error += "Passwords is not match!\n";

        if (error != string.Empty)
            MessageBox.Show(error);

        return error == string.Empty;
    }

    private bool IsAnyValidationError()
    {
        foreach (FrameworkElement grid in LogicalTreeHelper.GetChildren(this))
            foreach (var UiObjects in LogicalTreeHelper.GetChildren(grid))
                if (Validation.GetHasError(UiObjects as DependencyObject))
                    return true;

        return false;
    }

    private bool IsPasswordsMatch()
    {
        return PasswordPasBx.Password == CheckPaswPasBx.Password;
    }

    private bool IsLoginInDb()
    {
        return _dbContext.Users.Any(c => c.Login == LoginTxtBx.Text);
    }

    private bool IsPhoneInDb()
    {
        return _dbContext.Users.Any(c => c.Phone == PhoneTxtBx.Text);
    }

    private bool IsEmailInDb()
    {
        return _dbContext.Users.Any(c => c.Email == EmailTxtBx.Text);
    }
    #endregion
}
