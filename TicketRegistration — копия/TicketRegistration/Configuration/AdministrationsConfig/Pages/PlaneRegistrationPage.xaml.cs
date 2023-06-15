using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TicketRegistration;

public partial class PlaneRegistrationPage : Page
{
    private AllDbContext _dbContext;
    private DataBaseController _dbController;
    private PlaneRegistrationPageValidation _validaitor;

    public PlaneRegistrationPage()
    {
        _dbContext = new AllDbContext();
        _dbController = new DataBaseController();
        _validaitor = new PlaneRegistrationPageValidation();

        InitializeComponent();
        Loaded += InitializeCmbBxOnLoad;
        DataContext = _validaitor;
    }
    #region Events
    private void InitializeCmbBxOnLoad(object sender, RoutedEventArgs e)
    {
        InitializePlanesCmbBx();
    }

    private void AddPlaneButton_Click(object sender, RoutedEventArgs e)
    {
        AddPlane();
    }

    private void DeletePlaneButton_Click(object sender, RoutedEventArgs e)
    {
        DeletePlaneCascade();
    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e)
    {
        InitializePlanesCmbBx();
    }
    #endregion

    #region Logic
    private void DeletePlaneCascade()
    {
        _dbController.DeletePlaneCascade(PlaneCmbBx.Text);
    }

    private void AddPlane()
    {
        if (IsAnyValidationErrors())
            MessageBox.Show("Check input data!");
        else
            _dbController.AddPlane(PlaneCmbBx.Text, EconomySeatsNumberTxtBx.Text, BusinessSeatsNumberTxtBx.Text);
    }

    private void InitializePlanesCmbBx()
    {
        PlaneCmbBx.ItemsSource = _dbContext.Planes.Select(c => c.Name).OrderBy(c => c).ToList();
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