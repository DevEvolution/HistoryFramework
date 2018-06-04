using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class Route
    {
        public virtual int RouteNumber { get; set; }
        public virtual int CarNumber { get; set; }
        //public virtual Car Car { get; set; }
        public virtual DateTime CarDepartureDate { get; set; }
        public virtual int ConversionsNumber { get; set; }
    }
}
