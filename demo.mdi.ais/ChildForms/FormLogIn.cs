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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Program.Controller.Error("Дальше пока не работает");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Program.Controller.Open(new FormRegistration());
        }
    }
}
