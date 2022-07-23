using FlightManagement.Enum;

namespace FlightManagement.Plane
{
    public class PassengerPlane : Plane
    {
        public PassengerPlane(int id)
        {
            this.PlaneId = id;
            this.PlaneType = "Passenger";
            this.Status = PlaneStatus.InOperation;
        }
    }
}