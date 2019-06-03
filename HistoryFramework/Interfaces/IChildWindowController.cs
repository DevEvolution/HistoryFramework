using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryFramework.Helpers.Interfaces
{
    public interface IChildWindowController
    {
        void Open(Form form);

        void Forward();
        bool CanGoForward { get; }

        void Back();
        bool CanGoBack { get; }

        void Close();
    }
}
