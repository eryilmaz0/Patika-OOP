using FlightManagement.Enum;

namespace FlightManagement.Plane
{
    public class MilitaryPlane : Plane
    {
        public MilitaryPlane(int id)
        {
            this.PlaneId = id;
            this.PlaneType = "Military";
            this.Status = PlaneStatus.InOperation;
        }
    }
}