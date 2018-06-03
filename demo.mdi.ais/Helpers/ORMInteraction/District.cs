using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class District
    {
        public virtual int DistrictNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual int SalesPointCount { get; set; }

        private ICollection<SalesPoint> _salesPoints;
        public virtual ICollection<SalesPoint> SalesPoints
        {
            get
            {
                return _salesPoints ?? (_salesPoints = new List<SalesPoint>());
            }
            set { _salesPoints = value; }
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

        //private ICollection<TotalDeliveryVolume> _volumes;
        //public virtual ICollection<TotalDeliveryVolume> TotalDeliveryVolumes
        //{
        //    get
        //    {
        //        return _volumes ?? (_volumes = new List<TotalDeliveryVolume>());
        //    }
        //    set { _volumes = value; }
        //}
    }
}
