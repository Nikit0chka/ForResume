using System;

public class User
{
    public int ID { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
}

public class Plane
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int EconomySeatsNumber { get; set; }
    public int BusinessSeatsNumber { get; set; }
}

public class AvailableCountry
{
    public int ID { get; set; }
    public string Name { get; set; }
}

public class AvailableCity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public AvailableCountry Country { get; set; }
}

public class Flight
{
    public int ID { get; set; }
    public DateTime DepartureTime { get; set; }
    public int EconomySeatsPrice { get; set; }
    public int BusinessSeatsPrice { get; set; }

    public int DepartureCityId { get; set; }
    public int ArrivalCityId { get; set; }
    public int PlaneID { get; set; }
    public AvailableCity DepartureCity { get; set; }
    public AvailableCity ArrivalCity { get; set; }
    public Plane Plane { get; set; }
}

public class Ticket
{
    public int ID { get; set; }
    public DateTime DepartureTime { get; set; }
    public int Price { get; set; }
    public bool? IsBronned { get; set; } = false;
    public string Type { get; set; }
    public AvailableCity DepartureCity { get; set; }
    public AvailableCity ArrivalCity { get; set; }
    public Flight Flight { get; set; }
    public Plane Plane { get; set; }
}