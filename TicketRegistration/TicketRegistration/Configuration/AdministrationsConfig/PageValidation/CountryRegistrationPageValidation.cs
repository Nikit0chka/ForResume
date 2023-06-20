using System;
using System.ComponentModel;
using System.Linq;

namespace TicketRegistration;

internal class CountryRegistrationPageValidation : IDataErrorInfo
{
    public string? CountryRegCountry { get; set; }

    public string this[string columnName]
    {
        get
        {
            string error = string.Empty;

            switch (columnName)
            {
                case "CountryRegCountry":
                    if (string.IsNullOrWhiteSpace(CountryRegCountry))
                        error = "Country name must be field!";
                    else if (!CountryRegCountry.All(char.IsLetter))
                        error = "Country name must contain only letters!";
                    break;
            }
            return error;
        }
    }

    public string Error => throw new NotImplementedException();
}