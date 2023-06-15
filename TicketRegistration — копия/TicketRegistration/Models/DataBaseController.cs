using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace TicketRegistration;

public class DataBaseController
{
    private AllDbContext _dbContext;

    public DataBaseController()
    {
        _dbContext = new AllDbContext();
    }
    #region AddElemnts
    public void AddCountry(string countryName)
    {
        if (IsCountryInDataBase(countryName))
            MessageBox.Show("This country is already registered!");
        else
        {
            AvailableCountry newCountry = new AvailableCountry { Name = countryName };

            _dbContext.AvailableCountries.Add(newCountry);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("Country registered successfully!");
        }
    }

    public void AddCity(string cityName, string countryName)
    {
        if (IsCityInDataBase(cityName))
            MessageBox.Show("This city is already registered!");
        else if (!IsCountryInDataBase(countryName))
            MessageBox.Show("This country is not registered!");
        else
        {
            AvailableCity newCity = new AvailableCity
            {
                Name = cityName,
                Country = _dbContext.AvailableCountries.Where(c => c.Name == countryName).First()
            };

            _dbContext.AvailableCities.Add(newCity);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("City registered successfully!");
        }
    }

    public void AddPlane(string planeName, string EconomySeatsNumber, string BusinessSeatsNumber)
    {
        if (IsPlaneInDataBase(planeName))
            MessageBox.Show("This plane is already registered!");
        else
        {
            Plane newPlane = new Plane
            {
                Name = planeName,
                EconomySeatsNumber = Convert.ToInt32(EconomySeatsNumber),
                BusinessSeatsNumber = Convert.ToInt32(BusinessSeatsNumber)
            };

            _dbContext.Planes.Add(newPlane);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("Plane registered successfully!");
        }
    }

    public void AddFlight(string departureCity, string arrivalCity, string planeName, DateTime? departureTime, string economySeatsPrice, string businessSeatsPrice)
    {
        if (IsFlightIsDataBase(departureCity, arrivalCity, planeName, departureTime))
            MessageBox.Show("This flight is already registered!");
        else if (!IsCityInDataBase(arrivalCity))
            MessageBox.Show("Arrival city is not registered!");
        else if (!IsCityInDataBase(departureCity))
            MessageBox.Show("Departure city is not registered!");
        else if (!IsPlaneInDataBase(planeName))
            MessageBox.Show("This plane is not registered!");
        else
        {
            Flight newFlight = new Flight
            {
                Plane = _dbContext.Planes.Where(c => c.Name == planeName).First(),
                DepartureCity = _dbContext.AvailableCities.Where(c => c.Name == departureCity).First(),
                ArrivalCity = _dbContext.AvailableCities.Where(c => c.Name == arrivalCity).First(),
                DepartureTime = Convert.ToDateTime(departureTime),
                EconomySeatsPrice = Convert.ToInt32(economySeatsPrice),
                BusinessSeatsPrice = Convert.ToInt32(businessSeatsPrice)
            };

            _dbContext.Flights.Add(newFlight);
            _dbContext.SaveChanges();

            AddTicketsByFlight(newFlight);

            MessageBox.Show("Flight registered successfully!");
        }
    }

    private void AddTicketsByFlight(Flight flight)
    {
        for (int i = 0; i < flight.Plane.EconomySeatsNumber; i++)
        {
            Ticket newTicket = new Ticket
            {
                Flight = flight,
                DepartureCity = flight.DepartureCity,
                ArrivalCity = flight.ArrivalCity,
                DepartureTime = flight.DepartureTime,
                Plane = flight.Plane,
                Type = "Economy",
                Price = flight.EconomySeatsPrice
            };
            _dbContext.Tickets.Add(newTicket);
        }
        for (int i = 0; i < flight.Plane.BusinessSeatsNumber; i++)
        {
            Ticket newTicket = new Ticket
            {
                Flight = flight,
                DepartureCity = flight.DepartureCity,
                ArrivalCity = flight.ArrivalCity,
                DepartureTime = flight.DepartureTime,
                Plane = flight.Plane,
                Type = "Business",
                Price = flight.BusinessSeatsPrice
            };
            _dbContext.Tickets.Add(newTicket);
        }
        _dbContext.SaveChangesAsync();
    }
    #endregion

    #region DeleteElement
    public void DeleteCountryCascade(string countryName)
    {
        if (IsCountryInDataBase(countryName))
        {
            AvailableCountry deletableCountry = _dbContext.AvailableCountries.Where(c => c.Name == countryName).First();
            List<AvailableCity> deletableCities = _dbContext.AvailableCities.Where(c => c.Country.ID == deletableCountry.ID).ToList();

            foreach (AvailableCity city in deletableCities)
            {
                List<Flight> deletableFlightsByCity = _dbContext.Flights.Where(c => c.ArrivalCity.ID == city.ID || c.DepartureCity.ID == city.ID).ToList();

                foreach (Flight flight in deletableFlightsByCity)
                {
                    DeleteTicketsByFlight(flight);
                    _dbContext.Flights.Remove(flight);
                }

                _dbContext.AvailableCities.Remove(city);
            }

            _dbContext.AvailableCountries.Remove(deletableCountry);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("Country deleted successfully!");
        }
        else
            MessageBox.Show("This country is not registered!");
    }

    public void DeleteCityCascade(string cityName)
    {
        if (IsCityInDataBase(cityName))
        {
            AvailableCity deletableCity = _dbContext.AvailableCities.Where(c => c.Name == cityName).First();

            List<Flight> deletableFlights = _dbContext.Flights.Where(c => c.DepartureCity.ID == deletableCity.ID || c.ArrivalCity.ID == deletableCity.ID).ToList();

            foreach (Flight flight in deletableFlights)
            {
                DeleteTicketsByFlight(flight);
                _dbContext.Flights.Remove(flight);
            }

            _dbContext.AvailableCities.Remove(deletableCity);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("City deleted successfully!");
        }
        else
            MessageBox.Show("This city is not registered!");
    }

    public void DeletePlaneCascade(string planeName)
    {
        if (IsPlaneInDataBase(planeName))
        {
            Plane deletablePlane = _dbContext.Planes.Where(c => c.Name == planeName).First();

            List<Flight> deletableFlights = _dbContext.Flights.Where(c => c.Plane.ID == deletablePlane.ID).ToList();

            foreach (Flight flight in deletableFlights)
            {
                DeleteTicketsByFlight(flight);
                _dbContext.Flights.Remove(flight);
            }

            _dbContext.Planes.Remove(deletablePlane);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("Plane deleted successfully!");
        }
        else
            MessageBox.Show("This plane is not registered!");
    }

    public void DeleteFlightCascade(string departureCity, string arrivalCity, string planeName, DateTime? departureTime)
    {
        if (IsFlightIsDataBase(departureCity, arrivalCity, planeName, departureTime))
        {

            Flight deletableFlight = _dbContext.Flights.Where(c => c.Plane.Name == planeName && c.DepartureCity.Name == departureCity &&
                                                              c.ArrivalCity.Name == arrivalCity && c.DepartureTime == departureTime).First();

            DeleteTicketsByFlight(deletableFlight);

            _dbContext.Flights.Remove(deletableFlight);
            _dbContext.SaveChangesAsync();

            MessageBox.Show("Flight deleted successfully!");
        }
        else
            MessageBox.Show("This flight is not registered!");
    }

    private void DeleteTicketsByFlight(Flight deletableFlight)
    {
        List<Ticket> deletableTickets = new List<Ticket>(_dbContext.Tickets.Where(c => c.Flight.ID == deletableFlight.ID).ToList());

        foreach (Ticket ticket in deletableTickets)
            _dbContext.Tickets.Remove(ticket);

        _dbContext.SaveChanges();
    }
    #endregion

    #region IsElementInDb
    public bool IsCountryInDataBase(string countryName)
    {
        return _dbContext.AvailableCountries.Any(c => c.Name == countryName);
    }

    public bool IsCityInDataBase(string cityName)
    {
        return _dbContext.AvailableCities.Any(c => c.Name == cityName);
    }

    public bool IsPlaneInDataBase(string planeName)
    {
        return _dbContext.Planes.Any(c => c.Name == planeName);
    }

    public bool IsFlightIsDataBase(string departureCityName, string arrivalCityName, string planeName, DateTime? departureTime)
    {
        return _dbContext.Flights.Any(c => c.DepartureCity.Name == departureCityName &&
                                     c.ArrivalCity.Name == arrivalCityName &&
                                     c.Plane.Name == planeName &&
                                     c.DepartureTime == departureTime);
    }
    #endregion

    #region GetElemntListOfNamesByElement    
    public List<string> GetCitiesNamesByCountryName(string countryName)
    {
        return _dbContext.AvailableCities.Where(c => c.Country.Name == countryName).Select(c => c.Name).OrderBy(c => c).ToList();
    }
    #endregion
}