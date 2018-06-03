using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class RouteScheme
    {
        public virtual int RouteNumber { get; set; }
        public virtual int RouteSectorNumber { get; set; }
        public virtual int StartPointNumber { get; set; }
        public virtual int EndPointNumber { get; set; }

        public override bool Equals(object obj)
        {
            var scheme = obj as RouteScheme;
            return scheme != null &&
                   RouteNumber == scheme.RouteNumber &&
                   RouteSectorNumber == scheme.RouteSectorNumber &&
                   StartPointNumber == scheme.StartPointNumber &&
                   EndPointNumber == scheme.EndPointNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = 1011442127;
            hashCode = hashCode * -1521134295 + RouteNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + RouteSectorNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + StartPointNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EndPointNumber.GetHashCode();
            return hashCode;
        }
    }
}
