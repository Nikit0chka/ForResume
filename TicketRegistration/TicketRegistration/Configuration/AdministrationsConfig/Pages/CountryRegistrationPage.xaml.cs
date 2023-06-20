using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class CountryRegistrationPage : Page
{
    private AllDbContext _dbContext;
    private DataBaseController _dbController;
    private CountryRegistrationPageValidation _validaitor;

    public CountryRegistrationPage()
    {
        _dbContext = new AllDbContext();
        _dbController = new DataBaseController();
        _validaitor = new CountryRegistrationPageValidation();

        InitializeComponent();

        Loaded += InitializeCmbBxOnPageLoad;
        DataContext = _validaitor;
    }

    #region Events
    private void InitializeCmbBxOnPageLoad(object sender, RoutedEventArgs e)
    {
        InitializeCountriesCmbBx();
    }

    private void AddCountryButton_Click(object sender, RoutedEventArgs e)
    {
        AddCountry();
    }

    private void DeleteCountryButton_Click(object sender, RoutedEventArgs e)
    {
        DeleteCountryCascade();
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
        InitializeCountriesCmbBx();
    }
    #endregion

    #region Logic
    private void AddCountry()
    {
        if (IsAnyValidationErrors())
            MessageBox.Show("Check input data!");
        else
            _dbController.AddCountry(CountryCmbBx.Text);
    }

    private void DeleteCountryCascade()
    {
        _dbController.DeleteCountryCascade(CountryCmbBx.Text);
    }

    private void InitializeCountriesCmbBx()
    {
        CountryCmbBx.ItemsSource = _dbContext.AvailableCountries.Select(c => c.Name).OrderBy(c => c).ToList();
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