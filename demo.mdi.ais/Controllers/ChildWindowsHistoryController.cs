using demo.mdi.ais.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais.Controllers
{
    public class ChildWindowsHistoryController : IChildWindowController
    {
        protected List<Form> history = new List<Form>();
        protected Form currentForm;
        protected bool isDialog = false;

        private FormMdiMain baseForm;

        public Action HistoryUpdated;
        public List<Form> History { get => history; }
        public Form CurrentForm { get => currentForm; }

        public bool CanGoForward { get => history.IndexOf(currentForm) < history.Count - 1; }
        public bool CanGoBack { get => history.IndexOf(currentForm) > 0; }
        private int freeId = 1;


        public ChildWindowsHistoryController(FormMdiMain baseForm)
        {
            this.baseForm = baseForm;
        }

        public void Open(Form form)
        {
            if (isDialog)
                Close();

            form.MdiParent = baseForm;
            history.Add(form);
            currentForm = form;
            currentForm.WindowState = FormWindowState.Maximized;
            baseForm.SetArticle(form.Text, form.Icon.ToBitmap());
            form.Tag = GetUniqueTag();
            form.Show();
            CheckButtonAvailability();
            isDialog = false;
            HistoryUpdated();
            form.FormClosed += formClosed;

            void formClosed(object sender, EventArgs e)
            {
                ((Form)sender).FormClosed -= formClosed;
                Close();
                HistoryUpdated();
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
                baseForm.SetArticle(currentForm.Text, currentForm.Icon.ToBitmap());
                CheckButtonAvailability();
                isDialog = false;
                HistoryUpdated();
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
                    baseForm.SetArticle(currentForm.Text, currentForm.Icon.ToBitmap());
                    CheckButtonAvailability();
                    isDialog = false;
                }
                HistoryUpdated();
            }
        }

        public void Close()
        {
            Form formToClose = currentForm;
            if (CanGoForward) Forward();
            else if (CanGoBack) Back();

            formToClose.Close();
            history.Remove(formToClose);
            baseForm.SetArticle(currentForm.Text, currentForm.Icon.ToBitmap());
            CheckButtonAvailability();
            isDialog = false;
            HistoryUpdated();
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
            baseForm.lblStatus.ForeColor = System.Drawing.Color.Red;
            baseForm.lblStatus.Text = message;
        }

        public void Message(string message)
        {
            baseForm.lblStatus.ForeColor = System.Drawing.Color.Black;
            baseForm.lblStatus.Text = message;
        }

        private void CheckButtonAvailability()
        {
            if (!CanGoForward)
                baseForm.btnForward.Enabled = false;
            else
                baseForm.btnForward.Enabled = true;

            if (!CanGoBack)
                baseForm.btnBack.Enabled = false;
            else
                baseForm.btnBack.Enabled = true;
        }

        protected virtual string GetUniqueTag()
        {
            string tag = (freeId++).ToString();
            return tag;
        }
    }
}
