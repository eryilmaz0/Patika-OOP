using FlightManagement.Company;

namespace FlightManagement.Airport
{
    public class CivilAirPort : Airport
    {
        public override OperationResult ValidateFlight(FlightInformations flightInformations)
        {
            return new(true, "Flight Validated.");
        }
    }
}