using System;
using System.ComponentModel;
using System.Linq;

namespace TicketRegistration;

internal class FlightRegistratrionPageValidation : IDataErrorInfo
{
    public string? DepartureCountry { get; set; }
    public string? ArrivalCountry { get; set; }
    public string? DepartureCity { get; set; }
    public string? ArrivalCity { get; set; }
    public string? PlaneName { get; set; }
    public string? DepartureTime { get; set; }
    public string? EconomySeatsPrice { get; set; }
    public string? BusinessSeatsPrice { get; set; }

    public string this[string columnName]
    {
        get
        {
            string error = string.Empty;

            switch (columnName)
            {
                case "DepartureCountry":
                    if (string.IsNullOrWhiteSpace(DepartureCountry))
                        error = "Departure country must be field!";
                    else if (!DepartureCountry.All(char.IsLetter))
                        error = "Departure country must contain only letters!";
                    break;

                case "ArrivalCountry":
                    if (string.IsNullOrWhiteSpace(ArrivalCountry))
                        error = "Arrival country must be field!";
                    else if (!ArrivalCountry.All(char.IsLetter))
                        error = "Arrival country must contain only letters!";
                    break;

                case "DepartureCity":
                    if (string.IsNullOrWhiteSpace(DepartureCity))
                        error = "Departure city must be field!";
                    else if (!DepartureCity.All(char.IsLetter))
                        error = "Departure city must contain only letters!";
                    break;

                case "ArrivalCity":
                    if (string.IsNullOrWhiteSpace(ArrivalCity))
                        error = "Arrival city must be field!";
                    else if (!ArrivalCity.All(char.IsLetter))
                        error = "Arrival city must contain only letters!";
                    break;

                case "DepartureTime":
                    if (string.IsNullOrWhiteSpace(DepartureTime))
                        error = "Departure time must be field!";
                    else if (!DateTime.TryParse(DepartureTime, out var result))
                        error = "Departure time must be inputted by calendar!";
                    break;

                case "EconomySeatsPrice":
                    if (string.IsNullOrWhiteSpace(EconomySeatsPrice))
                        error = "Economy seats price must be field!";
                    else if (!EconomySeatsPrice.All(char.IsNumber))
                        error = "Economy seats must contain only numbers!";
                    break;

                case "PlaneName":
                    if (string.IsNullOrWhiteSpace(PlaneName))
                        error = "Plane name must be field!";
                    break;

                case "BusinessSeatsPrice":
                    if (string.IsNullOrWhiteSpace(BusinessSeatsPrice))
                        error = "Business seats price must be field!";
                    else if (!BusinessSeatsPrice.All(char.IsNumber))
                        error = "Business seats price must contain only numbers!";
                    break;
            }
            return error;
        }
    }

    public string Error => throw new NotImplementedException();
}