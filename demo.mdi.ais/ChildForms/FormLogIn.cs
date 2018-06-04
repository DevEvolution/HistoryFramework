using demo.mdi.ais.ChildForms.Logist;
using demo.mdi.ais.Helpers;
using Newtonsoft.Json;
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

namespace demo.mdi.ais.ChildForms
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            Account account = auth.Authorize(tbLogin.Text, tbPassword.Text);
            if (account == null) Program.Controller.Error("Не удалось авторизоваться");
            else if (account.accountType == Helpers.Enums.AccountType.Logist)
                Program.Controller.Open(new FormRequest());
            else if (account.accountType == Helpers.Enums.AccountType.Manager)
                Program.Controller.Open(new FormManagerAction());
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
