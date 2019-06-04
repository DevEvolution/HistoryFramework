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
    /// <summary>
    /// History controller component
    /// </summary>
    public partial class HistoryController : Component, IChildWindowController
    {

        /// <summary>
        /// History toolstrip reference
        /// </summary>
        private HistoryToolstrip _historyToolstrip;

        /// <summary>
        /// History toolstrip reference
        /// </summary>
        public HistoryToolstrip HistoryToolstrip
        {
            get => _historyToolstrip;
            set
            {
                _historyToolstrip = value;
                _historyToolstrip.HistoryController = this;
            }
        }

        /// <summary>
        /// History button list reference
        /// </summary>
        private HistoryButtonList _historyButtonList;

        /// <summary>
        /// History button list reference
        /// </summary>
        public HistoryButtonList HistoryButtonList
        {
            get => _historyButtonList;
            set
            {
                _historyButtonList = value;
                _historyButtonList.HistoryController = this;
            }
        }

        /// <summary>
        /// History status strip reference
        /// </summary>
        private HistoryStatusStrip _historyStatusStrip;

        /// <summary>
        /// History status strip reference
        /// </summary>
        public HistoryStatusStrip HistoryStatusStrip
        {
            get => _historyStatusStrip;
            set
            {
                _historyStatusStrip = value;
                _historyStatusStrip.HistoryController = this;
            }
        }

        /// <summary>
        /// Default constructor for <see cref="HistoryController"/>
        /// </summary>
        public HistoryController()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Default constructor for <see cref="HistoryController"/> including owner container
        /// </summary>
        public HistoryController(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// List of all windows that history component references
        /// </summary>
        protected List<Form> history = new List<Form>();

        /// <summary>
        /// List of all windows that history component references
        /// </summary>
        public List<Form> History { get => history; }

        /// <summary>
        /// Currently showed form
        /// </summary>
        protected Form currentForm;

        /// <summary>
        /// Currently showed form
        /// </summary>
        public Form CurrentForm { get => currentForm; }

        /// <summary>
        /// Is currently showed form a dialog window
        /// </summary>
        protected bool isDialog = false;

        /// <summary>
        /// MDI Container form reference
        /// </summary>
        public Form BaseForm { get; set; }

        /// <summary>
        /// Check if can go forward in window history
        /// </summary>
        public bool CanGoForward { get => history.IndexOf(currentForm) < history.Count - 1; }

        /// <summary>
        /// Check if can go back in window history
        /// </summary>
        public bool CanGoBack { get => history.IndexOf(currentForm) > 0; }

        /// <summary>
        /// Currently free id tag
        /// </summary>
        private int freeId = 1;

        /// <summary>
        /// Opens window with adding it to window history
        /// </summary>
        /// <param name="form">Form to open</param>
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


        /// <summary>
        /// Opens window as a dialog and adds it to window history
        /// </summary>
        /// <param name="form">Form to open</param>
        public void OpenDialog(Form form)
        {
            this.Open(form);
            isDialog = true;
        }

        /// <summary>
        /// Step forward in window history
        /// </summary>
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

        /// <summary>
        /// Step back in window history
        /// </summary>
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

        /// <summary>
        /// Closes current window and removes it from window history
        /// </summary>
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

        /// <summary>
        /// Sets form active
        /// </summary>
        /// <param name="form">Form to show</param>
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

        /// <summary>
        /// Prints the error message at status strip
        /// </summary>
        /// <param name="message">Message to show</param>
        public void Error(string message)
        {
            HistoryStatusStrip.Error(message);
        }

        /// <summary>
        /// Prints the message at status strip
        /// </summary>
        /// <param name="message">Message to show</param>
        public void Message(string message)
        {
            HistoryStatusStrip.Message(message);
        }

        /// <summary>
        /// Checks if the buttons are currently available and disables them if not
        /// </summary>
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

        /// <summary>
        /// Gets unique id tag;
        /// </summary>
        /// <returns>Unique tag</returns>
        protected virtual string GetUniqueTag()
        {
            string tag = (freeId++).ToString();
            return tag;
        }
    }
}
