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
    public partial class HistoryToolstrip : UserControl
    {
        public HistoryController HistoryController { get; set; }

        public ToolStripButton BackButton { get => this.btnBack; }

        public ToolStripButton NextButton { get => this.btnForward; }

        public ToolStripLabel ArticleLabel { get => this.lblFormArticle; }

        public ToolStrip ToolStrip { get => this.toolStrip; }

        #region Events

        public event EventHandler BackButtonClicked;

        public event EventHandler NextButtonClicked;

        #endregion


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

        public HistoryToolstrip()
        {
            InitializeComponent();
            
            btnBack.Click += (o, e) => { HistoryController.Back(); };
            btnForward.Click += (o, e) => { HistoryController.Forward(); };
        }

        public void SetArticle(string article, Image icon)
        {
            ArticleLabel.Text = article;
            ArticleLabel.Image = icon;
        }
    }
}
