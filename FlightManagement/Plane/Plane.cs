using FlightManagement.Enum;

namespace FlightManagement.Plane
{
    public abstract class Plane
    {
        public int PlaneId { get; protected set; }
        public string PlaneType { get; protected set; }
        public PlaneStatus Status { get; protected set; }
        
    }
}