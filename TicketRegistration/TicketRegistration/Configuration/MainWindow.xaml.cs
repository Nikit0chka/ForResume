using System.Windows;

namespace TicketRegistration;

public partial class MainWindow : Window
{
    private UserAuthorizationPage _userAuthorizationPage;

    public MainWindow()
    {
        _userAuthorizationPage = new UserAuthorizationPage();

        InitializeComponent();
        MainFrame.Navigate(_userAuthorizationPage);
    }
}