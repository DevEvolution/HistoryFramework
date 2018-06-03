using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class Car
    {
        public virtual int CarNumber { get; set; }
        public virtual string CarType { get; set; }
        public virtual string DriverName { get; set; }
        public virtual string ExpeditorName { get; set; }
        public virtual int RecommendedLoadingVolume { get; set; }
        public virtual int RecommendedTonnageOfLoading { get; set; }
        public virtual string CarStatus { get; set; }
        public virtual string Specifications { get; set; }

        private ICollection<Route> _routes;
        public virtual ICollection<Route> Routes
        {
            get
            {
                return _routes ?? (_routes = new List<Route>());
            }
            set { _routes = value; }
        }
    }
}
