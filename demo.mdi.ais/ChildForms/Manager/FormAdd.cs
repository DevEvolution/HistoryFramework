using demo.mdi.ais.Helpers;
using demo.mdi.ais.Helpers.Enums;
using demo.mdi.ais.Helpers.ORMInteraction;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (table)
            {
                case TableToChange.Distance:
                    if (!string.IsNullOrEmpty(settingsTable.GetValue("№ начальной ТТ")) &&
                        !string.IsNullOrEmpty(settingsTable.GetValue("№ конечной ТТ")) &&
                        !string.IsNullOrEmpty(settingsTable.GetValue("№ района")) &&
                        !string.IsNullOrEmpty(settingsTable.GetValue("Расстояние между ТТ")) &&
                        !string.IsNullOrEmpty(settingsTable.GetValue("Информация о пути")))
                    {
                        DistanceBetweenSalesPoints distance = new DistanceBetweenSalesPoints()
                        {
                            StartSalesPointNumber = int.Parse(settingsTable.GetValue("№ начальной ТТ")),
                            EndSalesPointNumber = int.Parse(settingsTable.GetValue("№ конечной ТТ")),
                            DistrictNumber = int.Parse(settingsTable.GetValue("№ района")),
                            Distance = int.Parse(settingsTable.GetValue("Расстояние между ТТ")),
                            InformationAboutPath = settingsTable.GetValue("Информация о пути")
                        };
                        Repository<DistanceBetweenSalesPoints> repository = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
                        if (repository.All().ToList().FirstOrDefault(x => x.StartSalesPointNumber == distance.StartSalesPointNumber && x.EndSalesPointNumber == distance.EndSalesPointNumber) == null)
                        {
                            repository.Add(distance);
                            Program.Controller.Message("Запись успешно добавлена");
                        }
                        else
                            Program.Controller.Error("Такая запись уже существует!");
                    }
                    break;
                case TableToChange.District:
                    if (!string.IsNullOrEmpty(settingsTable.GetValue("№ Района")) &&
                        !string.IsNullOrEmpty(settingsTable.GetValue("Название")) &&
                        !string.IsNullOrEmpty(settingsTable.GetValue("Количество обслуживаемых ТТ")))
                    {
                        District district = new District()
                        {
                            DistrictNumber = int.Parse(settingsTable.GetValue("№ Района")),
                            Name = settingsTable.GetValue("Название"),
                            SalesPointCount = int.Parse(settingsTable.GetValue("Количество обслуживаемых ТТ"))
                        };
                        Repository<District> repository = new Repository<District>(NHibernateHelper.OpenSession());
                        if (repository.All().ToList().FirstOrDefault(x => x.DistrictNumber == district.DistrictNumber) == null)
                        {
                            repository.Add(district);
                            Program.Controller.Message("Запись успешно добавлена");
                        }
                        else
                            Program.Controller.Error("Такая запись уже существует!");
                    }
                    break;
            }

        }
    }
}
