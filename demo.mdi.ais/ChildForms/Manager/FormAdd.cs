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
    //при добавлении новой строки проверка по №района/№нач-й и кон-й ТТ, есть ли такие в БД

    public partial class FormAdd : Form
    {
        TableToChange table;

        public FormAdd(TableToChange tableToChange)
        {
            table = tableToChange;
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            switch (table)
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
