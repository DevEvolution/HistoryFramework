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
    public partial class HistoryButtonList : UserControl
    {
        private List<Button> historyList = new List<Button>();

        public FlowLayoutPanel FlowLayout { get => flowLayoutHistory; }
        
        public HistoryController HistoryController { get; set; }

        public Color Background { get => FlowLayout.BackColor; set => FlowLayout.BackColor = value; }

        public Color StaticColor { get; set; } = SystemColors.ControlText;

        public Color HighlightedColor { get; set; } = SystemColors.Highlight;


        private Size _buttonSize = new System.Drawing.Size(215, 60);
        public Size ButtonSize { get => _buttonSize; set { _buttonSize = value; historyList.ForEach(u => u.Size = value); } }

        public HistoryButtonList()
        {
            InitializeComponent();
        }

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

        protected virtual void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryController.SetActiveForm(HistoryController.History.First(x => x.Tag == ((Button)sender).Tag));
            HistoryListGarbageCollection();
        }
    }
}
