using DemoProject.Helpers;
using System;
using System.Windows.Forms;
using HistoryFramework;

namespace DemoProject.ChildForms
{
    /// <summary>
    /// Initial child form
    /// </summary>
    public partial class FormLogIn : Form
    {
        /// <summary>
        /// History controller object reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        public FormLogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Log in button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            Account account = auth.Authorize(tbLogin.Text, tbPassword.Text);
            if (account == null) HistoryController.Error("Error logging in. Incorrect username or password.");
            else
                HistoryController.Open(new FormActionHub() { HistoryController = HistoryController });
        }

        /// <summary>
        /// Keyboard button pressed on password textbox event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                btnLogIn_Click(this, new EventArgs());
        }

        /// <summary>
        /// Register button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            HistoryController.Message("Enter account data");
            HistoryController.Open(new FormRegister() { HistoryController = HistoryController });
        }
    }
}
