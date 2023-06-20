using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class MainAdminPage : Page
{
    private CountryRegistrationPage _countryRegistrationPage;
    private CityRegistrationPage _cityRegistrationPage;
    private FlightRegistratrionPage _flightRegistrationPage;
    private PlaneRegistrationPage _planeRegistrationPage;
    private AdminManagePage _manageAdminsPage;

    public MainAdminPage()
    {
        _countryRegistrationPage = new CountryRegistrationPage();
        _cityRegistrationPage = new CityRegistrationPage();
        _flightRegistrationPage = new FlightRegistratrionPage();
        _planeRegistrationPage = new PlaneRegistrationPage();
        _manageAdminsPage = new AdminManagePage();

        InitializeComponent();
        MainFrame.Navigate(_countryRegistrationPage);
    }

    private void OpenCountryPageOnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_countryRegistrationPage);
    }

    private void OpenCityPageOnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_cityRegistrationPage);
    }

    private void OpenFlightPageOnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_flightRegistrationPage);
    }

    private void OpenPlanePageOnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_planeRegistrationPage);
    }

    private void OpenAdminManagePageOnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(_manageAdminsPage);
    }

    private void BackButtonClick(object sender, RoutedEventArgs e)
    {
        NavigationService.GoBack();
    }

    private void OpenUserManagePageOnClick(object sender, RoutedEventArgs e)
    {
        //
    }
}