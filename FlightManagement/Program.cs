using System;
using FlightManagement.Airport;
using FlightManagement.Plane;

namespace FlightManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Company.Company company = new()
            {
                CompanyId = 1,
                Name = "Turkish Airlines",
            };

            Pilot.Pilot pilot = new()
            {
                PilotId = 1,
                Name = "Eren Yilmaz",
                ExperienceInYears = 5,
                Age = 24,
                Gender = true,
                IsActive = true
            };
            
            Pilot.Pilot pilot2 = new()
            {
                PilotId = 2,
                Name = "Murat Kandemir",
                ExperienceInYears = 10,
                Age = 40,
                Gender = true,
                IsActive = true
            };

            Airport.Airport airport1 = new CivilAirPort()
            {
                AirPortId = 1,
                Name = "Airport 1"
            };
            
            Airport.Airport airport2 = new CivilAirPort()
            {
                AirPortId = 2,
                Name = "Airport 2"
            };
            
            Airport.Airport airport3 = new MilitaryAirPort()
            {
                AirPortId = 3,
                Name = "Airport 3"
            };
            
            Airport.Airport airport4 = new MilitaryAirPort()
            {
                AirPortId = 4,
                Name = "Airport 4"
            };


            Plane.Plane plane = new PassengerPlane(1);
            Plane.Plane plane2 = new MilitaryPlane(2);


            company.AddPlane(plane);
            company.AddPlane(plane2);
            company.AddPilot(pilot);
            company.AddPilot(pilot2);

            var result = company.CreateFlight(new()
            {
                FlightId = 1,
                DepartureAirport = airport1,
                LandingAirport = airport2,
                Pilot = pilot,
                CoPilot = pilot2,
                Plane = plane,
                DepartureDate = DateTime.Now,
                LandingDate = DateTime.Now.AddHours(5)
            });
            
            var result2 = company.CreateFlight(new()
            {
                FlightId = 2,
                DepartureAirport = airport3,
                LandingAirport = airport4,
                Pilot = pilot,
                CoPilot = pilot2,
                Plane = plane2,
                DepartureDate = DateTime.Now,
                LandingDate = DateTime.Now.AddHours(5)
            });
        }
    }
}