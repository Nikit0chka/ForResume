using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TicketRegistration;

public partial class MainUserPage : Page
{
    public ObservableCollection<StackPanel> Panels { get; set; } = new ObservableCollection<StackPanel>();
    private AllDbContext _dbContext;

    public MainUserPage()
    {
        _dbContext = new AllDbContext();

        DataContext = this;
        InitializeComponent();
        InitializeCitiesCmbBx();
    }

    #region Events
    private void DepartureCityCmbBx_MouseEnter(object sender, MouseEventArgs e)
    {
        InitializeCitiesCmbBx();
    }

    private void ArrivalCityCmbBx_MouseEnter(object sender, MouseEventArgs e)
    {
        InitializeCitiesCmbBx();
    }

    private void InitializeFightsButt_Click(object sender, RoutedEventArgs e)
    {
        InitializeFlights();
    }

    private void OpenTicketChoosingWindow(object sender, RoutedEventArgs e)
    {
        TicketChoosingWindow window = new TicketChoosingWindow();
        window.Show();
    }
    #endregion

    #region Logic
    private void InitializeCitiesCmbBx()
    {
        ArrivalCityCmbBx.ItemsSource = _dbContext.AvailableCities.Select(c => c.Name).ToList();
        DepartureCityCmbBx.ItemsSource = _dbContext.AvailableCities.Select(c => c.Name).ToList();
    }

    private void InitializeFlights()
    {
        List<Flight> FlightsByCities = _dbContext.Flights.Where(c => c.DepartureCity.Name == DepartureCityCmbBx.Text && c.ArrivalCity.Name == ArrivalCityCmbBx.Text && c.DepartureTime.Date == DepartureDate.SelectedDate).ToList();

        foreach (Flight flight in FlightsByCities)
        {
            StackPanel newFlight = new StackPanel { Orientation = Orientation.Vertical };

            TextBlock FlightDirectionTxtBlc = new TextBlock { Text = DepartureCityCmbBx.Text + " " + ArrivalCityCmbBx.Text, HorizontalAlignment = HorizontalAlignment.Left, Style = (Style) Application.Current.Resources["TextBlockStyle"] };
            TextBlock AvailableEconomySitsNumberTxtBlc = new TextBlock { Text = "Number of available economy seats : " + _dbContext.Tickets.Where(c => c.DepartureCity == flight.DepartureCity && c.ArrivalCity == flight.ArrivalCity && c.Type == "Economy").Count().ToString(), Style = (Style) Application.Current.Resources["TextBlockStyle"] };
            TextBlock AvailableBusinessSitsNumberTxtBlc = new TextBlock { Text = "Number of available business seats : " + _dbContext.Tickets.Where(c => c.DepartureCity == flight.DepartureCity && c.ArrivalCity == flight.ArrivalCity && c.Type == "Business").Count().ToString(), Style = (Style) Application.Current.Resources["TextBlockStyle"] };
            Button SelectFlightButt = new Button { HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Bottom, Style = (Style) Application.Current.Resources["ButtonStyle"] };
            SelectFlightButt.Click += OpenTicketChoosingWindow;

            newFlight.Children.Add(FlightDirectionTxtBlc);
            newFlight.Children.Add(AvailableBusinessSitsNumberTxtBlc);
            newFlight.Children.Add(AvailableEconomySitsNumberTxtBlc);
            newFlight.Children.Add(SelectFlightButt);

            if (!Panels.Contains(newFlight))
                Panels.Add(newFlight);
        }
    }
    #endregion
}