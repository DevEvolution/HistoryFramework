using demo.mdi.ais.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais.ChildForms.Manager
{
    public partial class FormTableChoice : Form
    {
        public FormTableChoice()
        {
            InitializeComponent();
        }

        private void btnDistricts_Click(object sender, EventArgs e)
        {
            Program.Controller.OpenDialog(new FormDataChange(TableToChange.District));
        }

        private void btnDistances_Click(object sender, EventArgs e)
        {
            Program.Controller.OpenDialog(new FormDataChange(TableToChange.Distance));
        }
    }
}
