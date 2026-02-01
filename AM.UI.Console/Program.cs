// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, 4ARCTI4!");

AMContext ctx= new AMContext();

//ctx.Flights.Add(TestData.flight2);

//ctx.SaveChanges();
Console.WriteLine("La capacité="
    +ctx.Flights.First().MyPlane.Capacity);




//Plane plane1 = new Plane();
//plane1.PlaneId = 1;
//plane1.Capacity = 200;
//plane1.ManufactureDate = new DateTime(2025, 11, 13);
//plane1.PlaneType=PlaneType.Boeing;

////Plane plane2 = new Plane(PlaneType.Airbus,250,DateTime.Now);
//Plane plane3= new Plane 
//{ 
//    PlaneId=3,
//    Capacity=300
//};
//Console.WriteLine(plane3.ToString());

//Passenger passenger1 = new Passenger
//{
//    FirstName = "naouar",
//    LastName = "nesrine",
//    EmailAddress = "nesrine.naouar@esprit.tn"
//};
//Console.WriteLine("---Afficher passenger1 avant UpperFullName---");
//Console.WriteLine(passenger1.ToString());
//passenger1.UpperFullName();
//Console.WriteLine("---Afficher passenger1 après UpperFullName---");
//Console.WriteLine(passenger1.ToString());
//Console.WriteLine("---CheckProfile avec 2 parametres---");
//Console.WriteLine(passenger1.CheckProfile("naouar", "nesrine"));

//Console.WriteLine("---CheckProfile avec 3 parametres---");
//Console.WriteLine(passenger1.CheckProfile("naouar", "nesrine", "nesrine.naouar@esprit.tn"));

//Staff staff1 = new Staff { };
//Traveller traveller1= new Traveller { };
//Console.WriteLine("---passenger1---");
//passenger1.PassengerType();
//Console.WriteLine("---staff1---");
//staff1.PassengerType();
//Console.WriteLine("---traveller1---");
//traveller1.PassengerType();

//FlightMethods flightMethods 
//    = new FlightMethods 
//    {
//        Flights=TestData.listFlights
//    };

//Console.WriteLine("---La méthode GetFlightDates---");
//foreach (var item in flightMethods.GetFlightDates("Paris"))
//{
//    Console.WriteLine("Date: "+item);
//}

//Console.WriteLine("---La méthode GetFlights---");
//flightMethods.GetFlights("Destination", "Paris");

//Console.WriteLine("---La méthode ShowFlightDetails---");
//flightMethods.ShowFlightDetails(TestData.Airbusplane);

//Console.WriteLine("---Le délegué FlightDetailsDel---");
//flightMethods.FlightDetailsDel(TestData.Airbusplane);

//Console.WriteLine("---La méthode ProgrammedFlightNumber---");
//Console.WriteLine("Number of flights:"
//    + flightMethods.ProgrammedFlightNumber(new DateTime(2022, 01, 01)));

//Console.WriteLine("---La méthode DurationAverage---");
//Console.WriteLine(flightMethods.DurationAverage("Paris"));

//Console.WriteLine("---Le délegué DurationAverageDel---");
//Console.WriteLine(flightMethods.DurationAverageDel("Paris"));

//Console.WriteLine("---La méthode OrderedDurationFlights---");
//foreach (var item in flightMethods.OrderedDurationFlights())
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("---La méthode SeniorTravellers---");
//foreach (var item in flightMethods.SeniorTravellers(TestData.flight1))
//{
//    Console.WriteLine(item+ "Age= "
//        +(DateTime.Now.Year-item.BirthDate.Year));
//}
//Console.WriteLine("---La méthode DestinationGroupedFlights---");
//foreach (var g in flightMethods.DestinationGroupedFlights())
//{
//    Console.WriteLine("Destination "+g.Key);
//    foreach (var f in g)
//    {
//        Console.WriteLine("Décollage :" + f.FlightDate);
//    }
//}