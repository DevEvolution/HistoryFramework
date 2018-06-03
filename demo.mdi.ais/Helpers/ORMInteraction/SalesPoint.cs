using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class SalesPoint
    {
        public virtual int SalesPointNumber { get; set; }
        public virtual int DistrictNumber { get; set; }
        public virtual string Address { get; set; }

        public virtual District District { get; set; }

        private ICollection<Request> _requests;
        public virtual ICollection<Request> Requests
        {
            get
            {
                return _requests ?? (_requests = new List<Request>());
            }
            set { _requests = value; }
        }

        private ICollection<DistanceBetweenSalesPoints> _distances;
        public virtual ICollection<DistanceBetweenSalesPoints> DistanceBetweenSalesPoints
        {
            get
            {
                return _distances ?? (_distances = new List<DistanceBetweenSalesPoints>());
            }
            set { _distances = value; }
        }
    }
}