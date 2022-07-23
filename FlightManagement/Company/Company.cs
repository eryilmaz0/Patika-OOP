using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FlightManagement.Enum;

namespace FlightManagement.Company
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        private ICollection<Flight.Flight> Flights { get; set; }
        private ICollection<Plane.Plane> Planes { get; set; }
        private ICollection<EmployeePilot> Pilots { get; set; }


        public Company()
        {
            this.Flights = new List<Flight.Flight>();
            this.Planes = new List<Plane.Plane>();
            this.Pilots = new List<EmployeePilot>();
        }


        public OperationResult CreateFlight(FlightInformations request)
        {
            if (this.Flights.Any(x => x.FlightId.Equals(request.FlightId)))
                return new(false, "There is a flight with the same id.");
            
            if(!this.Pilots.Any(x => x.Pilot.PilotId.Equals(request.Pilot.PilotId) || x.Pilot.PilotId.Equals(request.CoPilot.PilotId)))
                return new(false, "Pilot or Copilot is not an employee for this company.");

            if (!this.Planes.Any(x => x.PlaneId.Equals(request.Plane.PlaneId)))
                return new(false, "Plane not found.");
            
            if (request.Plane.Status != PlaneStatus.InOperation)
                return new(false, "Plane is not in operation.");

            var validateFlightResult = request.DepartureAirport.ValidateFlight(request);

            if (!validateFlightResult.IsSuccess)
                return new(false, validateFlightResult.ResultMessage);
            
            this.Flights.Add(new()
            {
                FlightId = request.FlightId,
                DepartureAirport = request.DepartureAirport,
                LandingAirport = request.LandingAirport,
                Pilot = request.Pilot,
                CoPilot = request.CoPilot,
                Plane = request.Plane,
                DepartureDate = request.DepartureDate,
                LandingDate = request.LandingDate
            });

            return new(true, "Flight Created.");
        }


        public OperationResult AddPlane(Plane.Plane plane)
        {
            if (this.Planes.Any(x => x.PlaneId.Equals(plane.PlaneId)))
                return new(false, "There is a plane with the same id.");
            
            this.Planes.Add(plane);
            return new(true, "Plane Added.");
        }


        public OperationResult AddPilot(Pilot.Pilot pilot)
        {
            if (this.Pilots.Any(x => x.Pilot.PilotId.Equals(pilot.PilotId)))
                return new(false, "There is a pilot with the same id.");
            
            this.Pilots.Add(new(){Pilot = pilot, ExperienceInYears = 0});
            return new(true, "Pilot Added.");
        }


        public ICollection<Flight.Flight> ListFlights()
        {
            return this.Flights;
        }

    }
}