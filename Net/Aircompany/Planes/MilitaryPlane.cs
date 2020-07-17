using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryPlaneType MilitaryPlaneType { get; }

        public MilitaryPlane(Plane plane, MilitaryPlaneType militaryPlaneType)
            : base(plane.GetModel(), plane.GetMaxSpeed(), plane.GetMaxFlightDistance(), plane.GetMaxFlightDistance())
        {
            MilitaryPlaneType = militaryPlaneType;
        }

        public override bool Equals(object plane)
        {
            return plane is MilitaryPlane &&
                   base.Equals(plane) &&
                   MilitaryPlaneType == ((MilitaryPlane) plane).MilitaryPlaneType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            return hashCode * -1521134295 + MilitaryPlaneType.GetHashCode();
        }
        
        public override string ToString()
        {
            return base.ToString().Replace("}", ", type=" + MilitaryPlaneType + '}');
        }        
    }
}
