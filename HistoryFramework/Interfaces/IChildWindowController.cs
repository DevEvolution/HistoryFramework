using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryFramework.Helpers.Interfaces
{
    /// <summary>
    /// MDI History window controller interface
    /// </summary>
    public interface IChildWindowController
    {
        /// <summary>
        /// Opens window with adding it to window history
        /// </summary>
        /// <param name="form">Form to open</param>
        void Open(Form form);

        /// <summary>
        /// Step forward in window history
        /// </summary>
        void Forward();

        /// <summary>
        /// Check if can go forward in window history
        /// </summary>
        bool CanGoForward { get; }

        /// <summary>
        /// Step back in window history
        /// </summary>
        void Back();

        /// <summary>
        /// Check if can go back in window history
        /// </summary>
        bool CanGoBack { get; }

        /// <summary>
        /// Closes current window and removes it from window history
        /// </summary>
        void Close();
    }
}
