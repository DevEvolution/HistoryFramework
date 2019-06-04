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
    /// History button list control
    /// </summary>
    public partial class HistoryButtonList : UserControl
    {
        /// <summary>
        /// List of all buttons that history list contains
        /// </summary>
        private List<Button> historyList = new List<Button>();

        /// <summary>
        /// Flow layout panel container
        /// </summary>
        public FlowLayoutPanel FlowLayout { get => flowLayoutHistory; }

        /// <summary>
        /// History controller reference that is necessary to work
        /// </summary>
        public HistoryController HistoryController { get; set; }

        /// <summary>
        /// Background color
        /// </summary>
        public Color Background { get => FlowLayout.BackColor; set => FlowLayout.BackColor = value; }

        /// <summary>
        /// Static button color
        /// </summary>
        public Color StaticColor { get; set; } = SystemColors.ControlText;

        /// <summary>
        /// Highlighted button color
        /// </summary>
        public Color HighlightedColor { get; set; } = SystemColors.Highlight;

        /// <summary>
        /// Size of buttons in history list
        /// </summary>
        private Size _buttonSize = new System.Drawing.Size(215, 60);

        /// <summary>
        /// Size of buttons in history list
        /// </summary>
        public Size ButtonSize { get => _buttonSize; set { _buttonSize = value; historyList.ForEach(u => u.Size = value); } }

        /// <summary>
        /// Default constructor of <see cref="HistoryButtonList"/>
        /// </summary>
        public HistoryButtonList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rearrangement of all buttons in history list
        /// </summary>
        public void HistoryChangedCallback()
        {
            for (int i = 0; i < HistoryController.History.Count; i++)
            {
                if (!historyList.Exists(x => x.Tag == HistoryController.History[i].Tag))
                {
                    Button btn = new Button();
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Size = ButtonSize;
                    btn.Text = HistoryController.History[i].Text;
                    btn.AutoEllipsis = true;
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    btn.UseVisualStyleBackColor = true;
                    btn.Image = HistoryController.History[i].Icon.ToBitmap();
                    btn.Tag = HistoryController.History[i].Tag;
                    btn.Click += btnHistory_Click;
                    historyList.Add(btn);
                    flowLayoutHistory.Controls.Add(btn);
                    btn.Show();
                }
            }

            HistoryListGarbageCollection();
        }

        /// <summary>
        /// Gets rid of all buttons that were referenced at for now closed windows
        /// </summary>
        private void HistoryListGarbageCollection()
        {
            List<Button> demolition = new List<Button>();
            foreach (var button in historyList)
            {
                if (button.Tag == HistoryController.CurrentForm.Tag)
                    button.ForeColor = HighlightedColor;
                else
                    button.ForeColor = StaticColor;

                if (!HistoryController.History.Exists(x => x.Tag == button.Tag))
                {
                    button.Hide();
                    button.Click -= btnHistory_Click;
                    demolition.Add(button);
                }
            }
            demolition.ForEach(x => historyList.Remove(x));
        }

        /// <summary>
        /// Sets clicked button active and switches to referenced window
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        protected virtual void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryController.SetActiveForm(HistoryController.History.First(x => x.Tag == ((Button)sender).Tag));
            HistoryListGarbageCollection();
        }
    }
}
