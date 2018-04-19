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

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Controller.Open(new FormDataChange(TableToChange.Distance));
        }

        private void btnDistricts_Click(object sender, EventArgs e)
        {
            Program.Controller.Open(new FormDataChange(TableToChange.District));
        }
    }
}
