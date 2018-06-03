using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class Request
    {
        public virtual int RequestNumber { get; set; }
        public virtual int SalesPointNumber { get; set; }
        public virtual int ShipmentNumber { get; set; }
        public virtual DateTime BorderDeliveryDate { get; set; }
        public virtual int Count { get; set; }
        public virtual string RequestStatus { get; set; }

        public virtual SalesPoint SalesPoint { get; set; }
        public virtual Goods Goods { get; set; }

        //private ICollection<RequestVolume> _requestVolumes;
        //public virtual ICollection<RequestVolume> RequestVolumes
        //{
        //    get
        //    {
        //        return _requestVolumes ?? (_requestVolumes = new List<RequestVolume>());
        //    }
        //    set { _requestVolumes = value; }
        //}

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Request)
            {
                Request request = obj as Request;
                if (request.RequestNumber == RequestNumber &&
                    request.SalesPointNumber == SalesPointNumber &&
                    request.ShipmentNumber == ShipmentNumber &&
                    BorderDeliveryDate == BorderDeliveryDate &&
                    Count == Count &&
                    RequestStatus == RequestStatus)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (RequestNumber + "|" +
                SalesPointNumber + "|" +
                ShipmentNumber + "|" +
                BorderDeliveryDate).GetHashCode();
        }
    }
}
