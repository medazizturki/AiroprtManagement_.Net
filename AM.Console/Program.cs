// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");

Flight f1 = new ()
{
    FlightId = 1,
    FlightDate = DateTime.Now,
    EstimatedDuration = 120,
    EffectiveArrival = DateTime.Now.AddHours(2),
    Departure = "Paris",
    Destination = "New York"
};