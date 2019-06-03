using HistoryFramework.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryFramework
{
    public partial class HistoryController : Component, IChildWindowController
    {

        private HistoryToolstrip _historyToolstrip;
        public HistoryToolstrip HistoryToolstrip
        {
            get => _historyToolstrip;
            set
            {
                _historyToolstrip = value;
                _historyToolstrip.HistoryController = this;
            }
        }

        private HistoryButtonList _historyButtonList;
        public HistoryButtonList HistoryButtonList
        {
            get => _historyButtonList;
            set
            {
                _historyButtonList = value;
                _historyButtonList.HistoryController = this;
            }
        }

        private HistoryStatusStrip _historyStatusStrip;
        public HistoryStatusStrip HistoryStatusStrip
        {
            get => _historyStatusStrip;
            set
            {
                _historyStatusStrip = value;
                _historyStatusStrip.HistoryController = this;
            }
        }

        public HistoryController()
        {
            InitializeComponent();
        }

        public HistoryController(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        protected List<Form> history = new List<Form>();

        protected Form currentForm;
        protected bool isDialog = false;

        public Form BaseForm { get; set; }

        public List<Form> History { get => history; }
        public Form CurrentForm { get => currentForm; }

        public bool CanGoForward { get => history.IndexOf(currentForm) < history.Count - 1; }
        public bool CanGoBack { get => history.IndexOf(currentForm) > 0; }
        private int freeId = 1;


        public void Open(Form form)
        {
            if (isDialog)
                Close();

            form.MdiParent = BaseForm;
            history.Add(form);
            currentForm = form;
            currentForm.WindowState = FormWindowState.Maximized;

            HistoryToolstrip?.SetArticle(form.Text, form.Icon.ToBitmap());
            form.Tag = GetUniqueTag();
            form.Show();
            CheckButtonAvailability();
            isDialog = false;
            HistoryButtonList.HistoryChangedCallback();
            form.FormClosed += formClosed;

            void formClosed(object sender, EventArgs e)
            {
                ((Form)sender).FormClosed -= formClosed;
                Close();
                HistoryButtonList.HistoryChangedCallback();
            }
        }

        public void OpenDialog(Form form)
        {
            this.Open(form);
            isDialog = true;
        }

        public void Forward()
        {
            if (CanGoForward)
            {
                currentForm.Visible = false;
                currentForm = history[history.IndexOf(currentForm) + 1];
                currentForm.WindowState = FormWindowState.Maximized;
                currentForm.Visible = true;
                HistoryToolstrip?.SetArticle(currentForm.Text, currentForm.Icon.ToBitmap());
                CheckButtonAvailability();
                isDialog = false;
                HistoryButtonList.HistoryChangedCallback();
            }
        }

        public void Back()
        {
            if (CanGoBack)
            {
                if (isDialog)
                {
                    //if (MessageBox.Show("Вся введенная информация на форме не будет сохранена. Закрыть форму?",
                    //    "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    //{
                    isDialog = false;
                    Close();
                    //}
                    //else
                    //    return;
                }
                else
                {
                    currentForm.Visible = false;
                    currentForm = history[history.IndexOf(currentForm) - 1];
                    currentForm.WindowState = FormWindowState.Maximized;
                    currentForm.Visible = true;
                    HistoryToolstrip?.SetArticle(currentForm.Text, currentForm.Icon.ToBitmap());
                    CheckButtonAvailability();
                    isDialog = false;
                }
                HistoryButtonList.HistoryChangedCallback();
            }
        }

        public void Close()
        {
            Form formToClose = currentForm;
            if (CanGoForward) Forward();
            else if (CanGoBack) Back();

            formToClose.Close();
            history.Remove(formToClose);
            HistoryToolstrip?.SetArticle(currentForm.Text, currentForm.Icon.ToBitmap());
            CheckButtonAvailability();
            isDialog = false;
            HistoryButtonList.HistoryChangedCallback();
        }

        public void SetActiveForm(Form form)
        {
            if (form == currentForm) return;

            if (history.Contains(form))
            {
                if (history.IndexOf(form) < history.IndexOf(currentForm))
                {
                    do
                    {
                        Back();
                    }
                    while (form != currentForm);
                }
                else
                {
                    do
                    {
                        Forward();
                    }
                    while (form != currentForm);
                }
            }
        }

        public void Error(string message)
        {
            HistoryStatusStrip.Error(message);
        }

        public void Message(string message)
        {
            HistoryStatusStrip.Message(message);
        }

        private void CheckButtonAvailability()
        {
            if (!CanGoForward)
                HistoryToolstrip.NextButton.Enabled = false;
            else
                HistoryToolstrip.NextButton.Enabled = true;

            if (!CanGoBack)
                HistoryToolstrip.BackButton.Enabled = false;
            else
                HistoryToolstrip.BackButton.Enabled = true;
        }

        protected virtual string GetUniqueTag()
        {
            string tag = (freeId++).ToString();
            return tag;
        }
    }
}
