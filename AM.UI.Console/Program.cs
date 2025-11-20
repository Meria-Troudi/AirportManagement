using AM.ApplicationCore.Domain;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // Plane
        var plane = new Plane
        {
            PlaneId = 3,
            PlaneType = PlaneType.Boeing,
            Capacity = 200,
            ManufactureDate = new DateTime(2020, 1, 1)
        };
        Console.WriteLine(plane);

        // Passenger
        var passenger = new Passenger
        {
            Id = 1,
            FirstName = "Meria",
            LastName = "Troudi",
            EmailAddress = "meriatroudi@esprit.tn"
        };
        Console.WriteLine("Afficher passenger");
        Console.WriteLine(passenger);

        // Tester polymorphisme par héritage
        var staff = new Staff
        {
            Id = 2,
            FirstName = "John",
            LastName = "Doe",
            Function = "Manager",
            Salary = 5000
        };
        staff.PassengerType();

        var traveller = new Traveller
        {
            Id = 3,
            FirstName = "Alice",
            LastName = "Smith",
            Nationality = "French"
        };
        traveller.PassengerType();
        Console.WriteLine(plane);
        Console.WriteLine(passenger);
        Console.WriteLine(staff);
        Console.WriteLine(traveller);
        // Tester polymorphisme par signature
        Console.WriteLine("CheckProfile 2 params: " + passenger.CheckProfile("Troudi", "Meria"));
        Console.WriteLine("CheckProfile 3 params: " + passenger.CheckProfile("Troudi", "Meria", "meriatroudi@esprit.tn"));
    }
}
