using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers
{
    public class SettingsTableRowFilter
    {
        public (int more, int less) Range = (int.MinValue, int.MaxValue);
        public bool NotNull = false;
    }
}
