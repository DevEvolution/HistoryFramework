using demo.mdi.ais.ChildForms;
using demo.mdi.ais.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais
{
    public partial class FormMdiMain : Form
    {
        public FormMdiMain()
        {
            InitializeComponent();
        }

        private void FormMdiMain_Load(object sender, EventArgs e)
        {
            Program.Controller.Open(new FormLogIn());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.Controller.Back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            Program.Controller.Forward();
        }
    }
}
