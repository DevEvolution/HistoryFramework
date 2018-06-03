using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class Goods
    {
        public virtual int GoodsNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual string DeliveryUnit { get; set; }
        public virtual double DeliveryUnitVolume { get; set; }
        public virtual double DeliveryUnitWeight { get; set; }
        public virtual int AvialabilityInStock { get; set; }

        private ICollection<Request> _requests;
        public virtual ICollection<Request> Requests
        {
            get
            {
                return _requests ?? (_requests = new List<Request>());
            }
            set { _requests = value; }
        }

    }
}
