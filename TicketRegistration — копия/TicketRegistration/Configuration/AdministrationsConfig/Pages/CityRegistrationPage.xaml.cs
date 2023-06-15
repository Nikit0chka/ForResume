using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class CityRegistrationPage : Page
{
    private AllDbContext _dbContext;
    private DataBaseController _dbController;
    private CityRegistrationPageValidation _validaitor;

    public CityRegistrationPage()
    {
        _dbContext = new AllDbContext();
        _dbController = new DataBaseController();
        _validaitor = new CityRegistrationPageValidation();

        InitializeComponent();

        Loaded += InitializeCmbBxOnPageLoad;
        DataContext = _validaitor;
    }

    #region Events
    private void InitializeCmbBxOnPageLoad(object sender, RoutedEventArgs e)
    {
        InitializeCountriesCmbBx();
        InitializeCitiesCmbBxByCountry();
    }

    private void AddCityButton_Click(object sender, RoutedEventArgs e)
    {
        AddCity();
    }

    private void DeleteCityButton_Click(object sender, RoutedEventArgs e)
    {
        DeleteCityCascade();
    }

    private void CountryCombBx_SelectionChanged(object sender, System.EventArgs e)
    {
        InitializeCitiesCmbBxByCountry();
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
        InitializeCountriesCmbBx();
        InitializeCitiesCmbBxByCountry();
    }
    #endregion

    #region Logic
    private void DeleteCityCascade()
    {
        _dbController.DeleteCityCascade(CityCombBx.Text);
    }

    private void AddCity()
    {
        if (IsAnyValidationErrors())
            MessageBox.Show("Check input data!");
        else
            _dbController.AddCity(CityCombBx.Text, CountryCombBx.Text);
    }

    private void InitializeCountriesCmbBx()
    {
        CountryCombBx.ItemsSource = _dbContext.AvailableCountries.Select(c => c.Name).OrderBy(c => c).ToList();
    }

    private void InitializeCitiesCmbBxByCountry()
    {
        CityCombBx.ItemsSource = _dbController.GetCitiesNamesByCountryName(CountryCombBx.Text);
    }

    private bool IsAnyValidationErrors()
    {
        foreach (FrameworkElement grid in LogicalTreeHelper.GetChildren(this))
            foreach (var UiObjects in LogicalTreeHelper.GetChildren(grid))
                if (Validation.GetHasError(UiObjects as DependencyObject))
                    return true;

        return false;
    }
    #endregion
}