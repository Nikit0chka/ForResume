using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class UserAuthorizationPage : Page
{
    private AllDbContext _dbContext;

    public UserAuthorizationPage()
    {
        _dbContext = new AllDbContext();

        InitializeComponent();
    }
    #region Events
    private void SignInButt_Click(object sender, RoutedEventArgs e)
    {
        if (IsUserInDb())
            if (GetUserRole() == "Administraitor")
                NavigationService.Navigate(new MainAdminPage());
            else
                NavigationService.Navigate(new MainUserPage());
        else
            MessageBox.Show("This user is not registered!");
    }

    private void SignUpButt_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new UserRegistrationPage());
    }
    #endregion

    #region Logic
    private bool IsUserInDb()
    {
        return _dbContext.Users.Any(c => c.Login == LoginTxtBx.Text && c.Password == PasswordPasBx.Password);
    }

    private string GetUserRole()
    {
        return _dbContext.Users.Where(c => c.Login == LoginTxtBx.Text && c.Password == PasswordPasBx.Password).Select(c => c.Role).First();
    }
    #endregion
}