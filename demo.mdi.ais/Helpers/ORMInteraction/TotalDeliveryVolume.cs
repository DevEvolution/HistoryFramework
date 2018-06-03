using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class TotalDeliveryVolume
    {
        public virtual int DistrictNumber { get; set; }
        public virtual DateTime BorderDeliveryDate { get; set; }
        public virtual double TotalWeight { get; set; }
        public virtual double TotalVolume { get; set; }

        //public virtual District District { get; set; }

        public override bool Equals(object obj)
        {
            var volume = obj as TotalDeliveryVolume;
            return volume != null &&
                   DistrictNumber == volume.DistrictNumber &&
                   BorderDeliveryDate == volume.BorderDeliveryDate &&
                   TotalWeight == volume.TotalWeight &&
                   TotalVolume == volume.TotalVolume;
        }

        public override int GetHashCode()
        {
            var hashCode = -25170783;
            hashCode = hashCode * -1521134295 + DistrictNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + BorderDeliveryDate.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalWeight.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalVolume.GetHashCode();
            return hashCode;
        }
    }
}
