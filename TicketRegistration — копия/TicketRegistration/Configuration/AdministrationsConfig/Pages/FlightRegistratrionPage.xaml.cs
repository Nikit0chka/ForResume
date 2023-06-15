using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class FlightRegistratrionPage : Page
{
    private AllDbContext _dbContext;
    private DataBaseController _dbController;
    private FlightRegistratrionPageValidation _validaitor;

    public FlightRegistratrionPage()
    {
        _dbContext = new AllDbContext();
        _dbController = new DataBaseController();
        _validaitor = new FlightRegistratrionPageValidation();

        InitializeComponent();

        Loaded += InitializeCmbBxOnPageLoad;
        DataContext = _validaitor;
    }

    #region Events
    private void InitializeCmbBxOnPageLoad(object sender, RoutedEventArgs e)
    {
        InitializePlanesCmbBx();
        InitializeCountriesCmbBx();
        InitializeCitiesCmbBxByCountry();
    }

    private void AddFlightButton_Click(object sender, RoutedEventArgs e)
    {
        AddFlight();
    }

    private void DeleteFlightButton_Click(object sender, RoutedEventArgs e)
    {
        DeleteFlightCascade();
    }

    private void DepartureCountryCmbBx_SelectionChanged(object sender, System.EventArgs e)
    {
        DepartureCityCmbBx.ItemsSource = _dbController.GetCitiesNamesByCountryName(DepartureCountryCmbBx.Text);
    }

    private void ArrivalCountryCmbBx_SelectionChanged(object sender, System.EventArgs e)
    {
        ArrivalCityCmbBx.ItemsSource = _dbController.GetCitiesNamesByCountryName(ArrivalCountryCmbBx.Text);
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
        InitializePlanesCmbBx();
        InitializeCountriesCmbBx();
        InitializeCitiesCmbBxByCountry();
    }
    #endregion

    #region Logic
    private void AddFlight()
    {
        if (IsAnyValidationErrors())
            MessageBox.Show("Check input data!");
        else
            _dbController.AddFlight(DepartureCityCmbBx.Text, ArrivalCityCmbBx.Text, PlaneCmbBx.Text, DateTimePicker.Value, EconomySeatPriceTxtBx.Text, BusinessSeatPriceTxtBx.Text);
    }

    private void DeleteFlightCascade()
    {
        _dbController.DeleteFlightCascade(DepartureCityCmbBx.Text, ArrivalCityCmbBx.Text, PlaneCmbBx.Text, DateTimePicker.Value);
    }

    private void InitializeCountriesCmbBx()
    {
        ArrivalCountryCmbBx.ItemsSource = _dbContext.AvailableCountries.Select(c => c.Name).OrderBy(c => c).ToList();
        DepartureCountryCmbBx.ItemsSource = _dbContext.AvailableCountries.Select(c => c.Name).OrderBy(c => c).ToList();
    }

    private void InitializePlanesCmbBx()
    {
        PlaneCmbBx.ItemsSource = _dbContext.Planes.Select(c => c.Name).OrderBy(c => c).ToList();
    }

    private void InitializeCitiesCmbBxByCountry()
    {
        DepartureCityCmbBx.ItemsSource = _dbController.GetCitiesNamesByCountryName(DepartureCountryCmbBx.Text);
        ArrivalCityCmbBx.ItemsSource = _dbController.GetCitiesNamesByCountryName(ArrivalCountryCmbBx.Text);
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