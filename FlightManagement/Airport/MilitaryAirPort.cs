using FlightManagement.Company;

namespace FlightManagement.Airport
{
    public class MilitaryAirPort : Airport
    {
        public override OperationResult ValidateFlight(FlightInformations flightInformations)
        {
            if (flightInformations.Plane.PlaneType != "Military")
                return new(false, "Only military planes can fly between military airports.");

            if (flightInformations.Pilot.ExperienceInYears < 3 || flightInformations.CoPilot.ExperienceInYears < 3)
                return new(false, "Pilots in military flight must have experience over 3 years.");

            return new(true, "Flight Validated.");
        }
    }
}