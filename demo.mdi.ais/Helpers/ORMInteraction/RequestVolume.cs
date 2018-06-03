using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class RequestVolume
    {
        public virtual int RequestNumber { get; set; }
        public virtual int DistrictNumber { get; set; }
        public virtual DateTime BorderDeliveryDate { get; set; }
        public virtual double TotalWeight { get; set; }
        public virtual double TotalVolume { get; set; }

        //public virtual Request Request { get; set; }
    }
}
