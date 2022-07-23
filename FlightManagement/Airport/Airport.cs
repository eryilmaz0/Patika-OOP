using FlightManagement.Company;
using FlightManagement.Enum;

namespace FlightManagement.Airport
{
    public abstract class Airport
    {
        public int AirPortId { get; set; }
        public string Name { get; set; }

        public abstract OperationResult ValidateFlight(FlightInformations flightInformations);
    }
}