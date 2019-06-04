using DemoProject.Helpers;
using HistoryFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoProject.ChildForms
{
    /// <summary>
    /// Registration child form
    /// </summary>
    public partial class FormRegister : Form
    {
        /// <summary>
        /// History controller object reference
        /// </summary>
        public HistoryController HistoryController { get; set; }

        public FormRegister()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// OK (register) button clicked event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length > 0 && tbPassword.Text.Length > 0 && tbPassword.Text == tbRepeatPassword.Text)
            {
                // ok
                Authorization auth = new Authorization();
                auth.CreateAccount(tbLogin.Text, tbPassword.Text);
                HistoryController.Message("Registration completed. Try log in with created account data");
                HistoryController.Close();
            }
            else
            {
                HistoryController.Error("Incorrect registration data");
            }
        }

        /// <summary>
        /// Login textbox text changed event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbLogin_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length > 0)
            {
                lblStepLogin.ForeColor = SystemColors.Highlight;
                lblStepPassword.ForeColor = SystemColors.Highlight;
            }
            else
            {
                lblStepLogin.ForeColor = Color.Red;
                lblStepPassword.ForeColor = SystemColors.ControlText;
                HistoryController.Error("Login length must be at least 1 character length");
            }
        }

        /// <summary>
        /// Password textbox text changed event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length > 0)
            {
                lblStepPassword.ForeColor = SystemColors.Highlight;
                lblStepRepeatPassword.ForeColor = SystemColors.Highlight;
            }
            else
            {
                lblStepPassword.ForeColor = Color.Red;
                lblStepRepeatPassword.ForeColor = SystemColors.ControlText;
                HistoryController.Error("Password length must be at least 1 character length");
            }
        }

        /// <summary>
        /// Repeat password textbox text changed event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text  == tbRepeatPassword.Text)
            {
                lblStepRepeatPassword.ForeColor = SystemColors.Highlight;
            }
            else
            {
                lblStepRepeatPassword.ForeColor = Color.Red;
                HistoryController.Error("Repeat password value not match");
            }
        }
    }
}
