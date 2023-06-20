using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TicketRegistration;

public partial class UserRegistrationPage : Page
{
    private AllDbContext _dbContext;
    private RegistrationValidation _validaitor;

    public UserRegistrationPage()
    {
        _validaitor = new RegistrationValidation();
        _dbContext = new AllDbContext();

        DataContext = _validaitor;
        InitializeComponent();
    }

    #region Events
    private void SignInButt_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new UserAuthorizationPage());
    }

    private void SignUpButt_Click(object sender, RoutedEventArgs e)
    {
        OpenVeriifyWindow();
    }
    #endregion

    #region Logic
    private void OpenVeriifyWindow()
    {
        if (IsAllInputCorrect())
        {
            VerifyPhonePagexaml verifyPhonePage = new VerifyPhonePagexaml(EmailTxtBx.Text);
            NavigationService.Navigate(verifyPhonePage);
            verifyPhonePage.Unloaded += RegistrateUserAfterVerify;
        }
    }

    public void RegistrateUserAfterVerify(object sender, RoutedEventArgs e)
    {
        VerifyPhonePagexaml page = sender as VerifyPhonePagexaml;

        if (page.IsCodeVerified)
        {
            User newUser = new()
            {
                Name = NameTxtBx.Text,
                Surname = SurnameTxtBx.Text,
                Email = EmailTxtBx.Text,
                Phone = PhoneTxtBx.Text,
                Login = LoginTxtBx.Text,
                Password = PasswordPasBx.Password,
                Role = "User"
            };

            _dbContext.Add(newUser);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("Registered successfully!");
        }
    }

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