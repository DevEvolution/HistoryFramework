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

        private FormMdiMain baseForm;

        public bool CanGoForward { get => history.IndexOf(currentForm) < history.Count - 1; }
        public bool CanGoBack { get => history.IndexOf(currentForm) > 0; }

        public ChildWindowsHistoryController(FormMdiMain baseForm)
        {
            this.baseForm = baseForm;
        }

        public void Open(Form form)
        {
            form.MdiParent = baseForm;
            form.Show();
            history.Add(form);
            currentForm = form;
            currentForm.WindowState = FormWindowState.Maximized;

            CheckButtonAvailability();
        }

        public void Forward()
        {
            if (CanGoForward)
            {
                currentForm.Visible = false;
                currentForm = history[history.IndexOf(currentForm) + 1];
                currentForm.Visible = true;
                currentForm.WindowState = FormWindowState.Maximized;

                CheckButtonAvailability();
            }
        }

        public void Back()
        {
            if (CanGoBack)
            {
                currentForm.Visible = false;
                currentForm = history[history.IndexOf(currentForm) - 1];
                currentForm.Visible = true;
                currentForm.WindowState = FormWindowState.Maximized;

                CheckButtonAvailability();
            }
        }

        public void Close()
        {
            Form formToClose = currentForm;
            if (CanGoForward) Forward();
            else if (CanGoBack) Back();

            formToClose.Close();
            history.Remove(formToClose);
            CheckButtonAvailability();
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
    }
}
