using System;

public class TravelAgency { 
  public static void Main(string[] args) {
    
    string passengerName = "Franco";
    int passengerAge = 33;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);

    // Add 1 to passanger age
    passengerAge++;
    Console.WriteLine(passengerAge);

    // Explicit conversion
    double passengerAgeDouble = (double) passengerAge;
    Console.WriteLine(passengerAgeDouble);

    // Implicit conversion
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine(passengerAgeDouble2);

    // Conversion to a string
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);

  }
}