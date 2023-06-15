using System;
using System.ComponentModel;
using System.Linq;

namespace TicketRegistration;

internal class PlaneRegistrationPageValidation : IDataErrorInfo
{
    public string? PlaneRegPlaneName { get; set; }
    public string? PlaneRegNumberEcoSeats { get; set; }
    public string? PlaneRegNumberBusSeats { get; set; }

    public string this[string columnName]
    {
        get
        {
            string error = string.Empty;

            switch (columnName)
            {
                case "PlaneRegPlaneName":
                    if (string.IsNullOrWhiteSpace(PlaneRegPlaneName))
                        error = "Plane name must be field!";
                    break;

                case "PlaneRegNumberEcoSeats":
                    if (string.IsNullOrWhiteSpace(PlaneRegNumberEcoSeats))
                        error = "Number of seats must be field!";
                    else if (!PlaneRegNumberEcoSeats.All(char.IsNumber))
                        error = "Number of seats must contain only letters!";
                    break;

                case "PlaneRegNumberBusSeats":
                    if (string.IsNullOrWhiteSpace(PlaneRegNumberBusSeats))
                        error = "Number of seats must be field!";
                    else if (!PlaneRegNumberBusSeats.All(char.IsNumber))
                        error = "Number of seats must contain only letters!";
                    break;
            }
            return error;
        }
    }

    public string Error => throw new NotImplementedException();
}