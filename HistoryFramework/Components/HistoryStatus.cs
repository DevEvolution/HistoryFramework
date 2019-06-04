using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryFramework
{
    /// <summary>
    /// History status strip control
    /// </summary>
    public partial class HistoryStatusStrip : UserControl
    {
        /// <summary>
        /// History controller reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        /// <summary>
        /// Status strip
        /// </summary>
        public StatusStrip StatusStrip { get => statusStrip; }

        /// <summary>
        /// Message label at status strip
        /// </summary>
        public ToolStripStatusLabel StatusLabel { get => lblStatus; }

        /// <summary>
        /// Foreground color of status strip
        /// </summary>
        public Color Foreground
        {
            get => statusStrip.ForeColor;
            set
            {
                statusStrip.ForeColor = value;
                lblStatus.ForeColor = value;
            }
        }

        /// <summary>
        /// Background color of status strip
        /// </summary>
        public Color Background
        {
            get => statusStrip.BackColor;
            set
            {
                statusStrip.BackColor = value;
                lblStatus.BackColor = value;
            }
        }

        /// <summary>
        /// Color of showing messages
        /// </summary>
        public Color MessageColor { get; set; } = System.Drawing.Color.Black;

        /// <summary>
        /// Color of showing error messages
        /// </summary>
        public Color ErrorColor { get; set; } = System.Drawing.Color.Red;

        /// <summary>
        /// Default constructor for <see cref="HistoryStatusStrip"/>
        /// </summary>
        public HistoryStatusStrip()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prints the error message at status strip
        /// </summary>
        /// <param name="message">Message to show</param>
        public void Error(string message)
        {
            lblStatus.ForeColor = ErrorColor;
            lblStatus.Text = message;
        }

        /// <summary>
        /// Prints the message at status strip
        /// </summary>
        /// <param name="message">Message to show</param>
        public void Message(string message)
        {
            lblStatus.ForeColor = MessageColor;
            lblStatus.Text = message;
        }
    }
}
