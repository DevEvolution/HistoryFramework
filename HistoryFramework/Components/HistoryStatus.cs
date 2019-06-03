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
    public partial class HistoryStatusStrip : UserControl
    {
        public HistoryController HistoryController { get; set; }

        public StatusStrip StatusStrip { get => statusStrip; }

        public ToolStripStatusLabel StatusLabel { get => lblStatus; }

        public Color Foreground
        {
            get => statusStrip.ForeColor;
            set
            {
                statusStrip.ForeColor = value;
                lblStatus.ForeColor = value;
            }
        }

        public Color Background
        {
            get => statusStrip.BackColor;
            set
            {
                statusStrip.BackColor = value;
                lblStatus.BackColor = value;
            }
        }


        public Color MessageColor { get; set; } = System.Drawing.Color.Black;

        public Color ErrorColor { get; set; } = System.Drawing.Color.Red;

        public HistoryStatusStrip()
        {
            InitializeComponent();
        }

        public void Error(string message)
        {
            lblStatus.ForeColor = ErrorColor;
            lblStatus.Text = message;
        }

        public void Message(string message)
        {
            lblStatus.ForeColor = MessageColor;
            lblStatus.Text = message;
        }
    }
}
