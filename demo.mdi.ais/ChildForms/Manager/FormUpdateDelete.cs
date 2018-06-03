using demo.mdi.ais.Helpers;
using demo.mdi.ais.Helpers.Enums;
using Newtonsoft.Json;
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
    //Сделать динамический список


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
                btnUpdateDelete.ForeColor = SystemColors.Highlight;
                btnUpdateDelete.Text = "Сохранить";
            }
            else
            {
                btnUpdateDelete.ForeColor = Color.Red;
                btnUpdateDelete.Text = "Удалить";
            }

            switch (tableToChange)
            {
                case TableToChange.Distance:
                    settingsTable.DynamicList = JsonConvert.DeserializeObject<SettingsTableDynamicList>(Encoding.UTF8.GetString(Properties.Resources.distance_dynamicList));
                    break;
                case TableToChange.District:
                    settingsTable.DynamicList = JsonConvert.DeserializeObject<SettingsTableDynamicList>(Encoding.UTF8.GetString(Properties.Resources.district_dynamicList));
                    break;
            }
        }
    }
}
