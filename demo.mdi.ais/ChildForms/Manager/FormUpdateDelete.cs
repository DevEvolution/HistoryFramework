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
    public partial class FormUpdateDelete : Form
    {
        private TableAction action;
        private TableToChange tableToChange;

        public FormUpdateDelete(TableAction action, TableToChange tableToChange)
        {
            InitializeComponent();
            this.action = action;
            this.tableToChange = tableToChange;
        }

        private void FormUpdateDelete_Load(object sender, EventArgs e)
        {
            if (action == TableAction.Update)
            {
                btnUpdateDelete.Text = "Сохранить изменения";
            }
            else
            {
                btnUpdateDelete.Text = "Удалить";
            }
        }
    }
}
