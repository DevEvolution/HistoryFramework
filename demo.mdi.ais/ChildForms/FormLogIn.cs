using DemoProject.ChildForms.Logist;
using DemoProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoryFramework;

namespace DemoProject.ChildForms
{
    public partial class FormLogIn : Form
    {
        public HistoryController HistoryController { get; set; }

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            Account account = auth.Authorize(tbLogin.Text, tbPassword.Text);
            if (account == null) HistoryController.Error("Не удалось авторизоваться");
            else if (account.accountType == Helpers.Enums.AccountType.Logist)
                HistoryController.Open(new FormRequest() { HistoryController = HistoryController });
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                btnLogIn_Click(this, new EventArgs());
        }
    }
}
