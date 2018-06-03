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
    public partial class FormDataChange : Form
    {
        private TableToChange tableToChange;

        public FormDataChange(TableToChange tableToChange)
        {
            InitializeComponent();
            this.tableToChange = tableToChange;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Program.Controller.OpenDialog(new FormUpdateDelete(TableAction.Update, tableToChange));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.Controller.OpenDialog(new FormUpdateDelete(TableAction.Delete, tableToChange));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.Controller.OpenDialog(new FormAdd(tableToChange));
        }
    }
}
