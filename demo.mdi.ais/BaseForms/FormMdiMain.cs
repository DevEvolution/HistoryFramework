using demo.mdi.ais.ChildForms;
using demo.mdi.ais.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais
{
    public partial class FormMdiMain : Form
    {
        private List<Button> historyList = new List<Button>();

        public FormMdiMain()
        {
            InitializeComponent();
        }

        private void FormMdiMain_Load(object sender, EventArgs e)
        {
            Program.Controller.HistoryUpdated += HistoryChangedCallback;
            Program.Controller.Open(new FormLogIn());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.Controller.Back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            Program.Controller.Forward();
        }

        public void SetArticle(string article, Image icon)
        {
            lblFormArticle.Text = article;
            lblFormArticle.Image = icon;
        }

        public void HistoryChangedCallback()
        {
            for (int i = 0; i < Program.Controller.History.Count; i++)
            {
                if(!historyList.Exists(x => x.Tag == Program.Controller.History[i].Tag))
                {
                    Button btn = new Button();
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Size = new System.Drawing.Size(215, 60);
                    btn.Text = Program.Controller.History[i].Text;
                    btn.AutoEllipsis = true;
                    btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    btn.UseVisualStyleBackColor = true;
                    btn.Image = Program.Controller.History[i].Icon.ToBitmap();
                    btn.Tag = Program.Controller.History[i].Tag;
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
                if (button.Tag == Program.Controller.CurrentForm.Tag)
                    button.ForeColor = SystemColors.Highlight;
                else
                    button.ForeColor = SystemColors.ControlText;

                if (!Program.Controller.History.Exists(x => x.Tag == button.Tag))
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
            Program.Controller.SetActiveForm(Program.Controller.History.First(x => x.Tag == ((Button)sender).Tag));
            HistoryListGarbageCollection();
        }
    }
}
