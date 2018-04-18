using demo.mdi.ais.Helpers.ORMInteraction;
using demo.mdi.ais.Helpers.ORMInteraction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais.ChildForms
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Trim().Length == 0)
            {
                Program.Controller.Error("Поле \"Электронная почта\" обязательно для заполнения.");
                return;
            }
            if (tbPassword.Text.Length == 0)
            {
                Program.Controller.Error("Поле \"Пароль\" обязательно для заполнения.");
                return;
            }
            if (tbPasswordAccept.Text.Length == 0)
            {
                Program.Controller.Error("Подтвердите выбранный пароль.");
                return;
            }
            if (tbPassword.Text != tbPasswordAccept.Text)
            {
                Program.Controller.Error("Несовпадение введенного пароля с проверочным паролем");
                return;
            }

            ORMRepository.Accounts.Add(new AccountModel
            {
                Login = tbEmail.Text,
                Password = tbPassword.Text
            });

            Program.Controller.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.Controller.Close();
        }
    }
}
