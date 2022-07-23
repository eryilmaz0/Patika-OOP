using System;

namespace FlightManagement.Flight
{
    public class Flight
    {
        public int FlightId { get; set; }
        public Airport.Airport DepartureAirport { get; set; }
        public Airport.Airport LandingAirport { get; set; }
        public Pilot.Pilot Pilot { get; set; }
        public Pilot.Pilot CoPilot { get; set; }
        public Plane.Plane Plane { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime LandingDate { get; set; }
        
        
        public void PrintFlightInformations()
        {
        
        }
    }
    
    
    

    
}