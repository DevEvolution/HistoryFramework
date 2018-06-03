using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction
{
    public class DistanceBetweenSalesPoints
    {
        public virtual int StartSalesPointNumber { get; set; }
        public virtual int EndSalesPointNumber { get; set; }
        public virtual int DistrictNumber { get; set; }
        public virtual int Distance { get; set; }
        public virtual string InformationAboutPath { get; set; }

        public virtual SalesPoint StartSalesPoint { get; set; }
        public virtual SalesPoint EndSalesPoint { get; set; }
        public virtual District District { get; set; }

        public override bool Equals(object obj)
        {
            var points = obj as DistanceBetweenSalesPoints;
            return points != null &&
                   StartSalesPointNumber == points.StartSalesPointNumber &&
                   EndSalesPointNumber == points.EndSalesPointNumber &&
                   DistrictNumber == points.DistrictNumber &&
                   Distance == points.Distance &&
                   InformationAboutPath == points.InformationAboutPath;
        }

        public override int GetHashCode()
        {
            var hashCode = 1885387658;
            hashCode = hashCode * -1521134295 + StartSalesPointNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EndSalesPointNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + DistrictNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + Distance.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InformationAboutPath);
            return hashCode;
        }
    }
}
