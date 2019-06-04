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
    /// History toolstrip control
    /// </summary>
    public partial class HistoryToolstrip : UserControl
    {
        /// <summary>
        /// History controller reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        /// <summary>
        /// Button "Back"
        /// </summary>
        public ToolStripButton BackButton { get => this.btnBack; }

        /// <summary>
        /// Button "Next"
        /// </summary>
        public ToolStripButton NextButton { get => this.btnForward; }

        /// <summary>
        /// Window article label
        /// </summary>
        public ToolStripLabel ArticleLabel { get => this.lblFormArticle; }

        /// <summary>
        /// ToolStrip reference
        /// </summary>
        public ToolStrip ToolStrip { get => this.toolStrip; }

        /// <summary>
        /// Foreground color
        /// </summary>
        public Color Foreground
        {
            get => this.toolStrip.ForeColor;
            set
            {
                ToolStrip.ForeColor = value;
                ArticleLabel.ForeColor = value;
                BackButton.ForeColor = value;
                NextButton.ForeColor = value;
            }
        }

        /// <summary>
        /// Background color
        /// </summary>
        public Color Background
        {
            get => this.toolStrip.BackColor;
            set
            {
                ToolStrip.BackColor = value;
                ArticleLabel.BackColor = value;
                BackButton.BackColor = value;
                NextButton.BackColor = value;
            }
        }

        /// <summary>
        /// Default constructor of <see cref="HistoryToolstrip"/>
        /// </summary>
        public HistoryToolstrip()
        {
            InitializeComponent();
            
            btnBack.Click += (o, e) => { HistoryController.Back(); };
            btnForward.Click += (o, e) => { HistoryController.Forward(); };
        }

        /// <summary>
        /// Sets the actual article text and icon
        /// </summary>
        /// <param name="article">Actual article text</param>
        /// <param name="icon">actual article icon</param>
        public void SetArticle(string article, Image icon)
        {
            ArticleLabel.Text = article;
            ArticleLabel.Image = icon;
        }
    }
}
