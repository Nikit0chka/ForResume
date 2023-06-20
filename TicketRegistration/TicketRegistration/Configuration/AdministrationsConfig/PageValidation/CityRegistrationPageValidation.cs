using System;
using System.ComponentModel;
using System.Linq;

namespace TicketRegistration;

internal class CityRegistrationPageValidation : IDataErrorInfo
{
    public string? CityRegCountry { get; set; }
    public string? CityRegCity { get; set; }

    public string this[string columnName]
    {
        get
        {
            string error = string.Empty;

            switch (columnName)
            {
                case "CityRegCountry":
                    if (string.IsNullOrWhiteSpace(CityRegCountry))
                        error = "City name must be field!";
                    else if (!CityRegCountry.All(char.IsLetter))
                        error = "City name must contain only letters!";
                    break;

                case "CityRegCity":
                    if (string.IsNullOrWhiteSpace(CityRegCity))
                        error = "City name must be field!";
                    else if (!CityRegCity.All(char.IsLetter))
                        error = "City name must contain only letters!";
                    break;
            }
            return error;
        }
    }

    public string Error => throw new NotImplementedException();
}