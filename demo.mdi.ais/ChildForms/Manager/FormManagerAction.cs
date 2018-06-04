using demo.mdi.ais.ChildForms.Manager;
using demo.mdi.ais.Helpers;
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
    public partial class FormManagerAction : Form
    {
        public FormManagerAction()
        {
            InitializeComponent();
            Program.Controller.Message($"Добро пожаловать, {Authorization.AuthorizedAccount.login}");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Program.Controller.Open(new FormTableChoice());
        }

        private void btnBuildDocumentation_Click(object sender, EventArgs e)
        {

        }
    }
}
