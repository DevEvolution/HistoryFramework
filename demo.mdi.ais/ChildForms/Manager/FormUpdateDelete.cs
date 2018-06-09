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
    public partial class FormUpdateDelete : Form
    {
        private TableAction action;
        private TableToChange tableToChange;
        private SettingsTable settingsTable;

        public FormUpdateDelete(TableAction action, TableToChange tableToChange)
        {
            InitializeComponent();
            this.action = action;
            this.tableToChange = tableToChange;

            settingsTable = new demo.mdi.ais.SettingsTable();
            settingsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            settingsTable.Location = new System.Drawing.Point(0, 24);
            settingsTable.Name = "settingsTable";
            settingsTable.Padding = new System.Windows.Forms.Padding(10);
            settingsTable.Size = new System.Drawing.Size(419, 599);
            settingsTable.TabIndex = 0;
            panel3.Controls.Add(this.settingsTable);
            settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;

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
                    {
                        SettingsTableDynamicList list = JsonConvert.DeserializeObject<SettingsTableDynamicList>(Encoding.UTF8.GetString(Properties.Resources.distance_dynamicList));
                        settingsTable.DynamicList = list;
                        list.rows.ForEach(x => dgvData.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = x.name }));
                        break;
                    }
                case TableToChange.District:
                    {
                        SettingsTableDynamicList list = JsonConvert.DeserializeObject<SettingsTableDynamicList>(Encoding.UTF8.GetString(Properties.Resources.district_dynamicList));
                        settingsTable.DynamicList = list;
                        list.rows.ForEach(x => dgvData.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = x.name }));
                        break;
                    }
            }
            Program.Controller.Message("Воспользуйтесь поиском для отображения необходимых данных");
        }

        private void FormUpdateDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (tableToChange)
            {
                case TableToChange.Distance:
                    {
                        FillFilteredTableDistance();
                        break;
                    }
                case TableToChange.District:
                    {
                        FillFilteredTableDistrict();
                        break;
                    }
            }
        }

        private void FillFilteredTableDistrict()
        {
            string district = SearchForValue("№ Района");
            string name = SearchForValue("Название");
            string count = SearchForValue("Количество обслуживаемых ТТ");

            Repository<District> districts = new Repository<District>(NHibernateHelper.OpenSession());
            var list = districts.All().ToList();
            if (!string.IsNullOrEmpty(district)) list = list.Where(x => x.DistrictNumber == int.Parse(district)).ToList();
            if (!string.IsNullOrEmpty(name)) list = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            if (!string.IsNullOrEmpty(count)) list = list.Where(x => x.SalesPointCount == int.Parse(count)).ToList();

            dgvData.Rows.Clear();
            list.ForEach(x => dgvData.Rows.Add(x.DistrictNumber, x.Name, x.SalesPointCount));
        }

        private void FillFilteredTableDistance()
        {
            string startPoint = SearchForValue("№ начальной ТТ");
            string endPoint = SearchForValue("№ конечной ТТ");
            string district = SearchForValue("№ района");
            string distance = SearchForValue("Расстояние между ТТ");
            string info = SearchForValue("Информация о пути");

            Repository<DistanceBetweenSalesPoints> distances = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
            var list = distances.All().ToList();
            if (!string.IsNullOrEmpty(startPoint)) list = list.Where(x => x.StartSalesPointNumber == int.Parse(startPoint)).ToList();
            if (!string.IsNullOrEmpty(endPoint)) list = list.Where(x => x.EndSalesPointNumber == int.Parse(endPoint)).ToList();
            if (!string.IsNullOrEmpty(district)) list = list.Where(x => x.DistrictNumber == int.Parse(district)).ToList();
            if (!string.IsNullOrEmpty(distance)) list = list.Where(x => x.Distance == int.Parse(distance)).ToList();
            if (!string.IsNullOrEmpty(info)) list = list.Where(x => x.InformationAboutPath.ToLower().Contains(info.ToLower())).ToList();

            dgvData.Rows.Clear();
            list.ForEach(x => dgvData.Rows.Add(x.StartSalesPointNumber, x.EndSalesPointNumber, x.DistrictNumber, x.Distance, x.InformationAboutPath));
        }

        private string SearchForValue(string value)
        {
            string item = settingsTable.GetValue(value);
            if (item != null && item.Trim().Length > 0 && item != "0")
                return item;
            else
                return null;
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case TableAction.Delete:
                    DeleteSelected();
                    break;
                case TableAction.Update:
                    UpdateSelected();
                    break;
            }
        }

        private void UpdateSelected()
        {
            if (dgvData.SelectedCells.Count == 0) return;
            switch (tableToChange)
            {
                case TableToChange.Distance:
                    {
                        int item = dgvData.SelectedCells[0].RowIndex;
                        Repository<DistanceBetweenSalesPoints> repository = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
                        DistanceBetweenSalesPoints oldDistance = repository.All().ToList().FirstOrDefault(x => x.StartSalesPointNumber == int.Parse(dgvData[0, item].Value.ToString()) && x.EndSalesPointNumber == int.Parse(dgvData[1, item].Value.ToString()));
                        DistanceBetweenSalesPoints newDistance = new DistanceBetweenSalesPoints()
                        {
                            StartSalesPointNumber = int.Parse(SearchForValue("№ начальной ТТ")),
                            EndSalesPointNumber = int.Parse(SearchForValue("№ конечной ТТ")),
                            DistrictNumber = int.Parse(SearchForValue("№ района")),
                            Distance = int.Parse(SearchForValue("Расстояние между ТТ")),
                            InformationAboutPath = SearchForValue("Информация о пути")
                        };
                        repository.Delete(oldDistance);
                        repository.Add(newDistance);

                        FillFilteredTableDistance();
                        break;
                    }
                case TableToChange.District:
                    {
                        int item = dgvData.SelectedCells[0].RowIndex;
                        Repository<District> repository = new Repository<District>(NHibernateHelper.OpenSession());
                        District oldDistrict = repository.All().ToList().FirstOrDefault(x => x.DistrictNumber == int.Parse(dgvData[0, item].Value.ToString()));
                        District newDistrict = new District()
                        {
                            DistrictNumber = int.Parse(SearchForValue("№ Района")),
                            Name = SearchForValue("Название"),
                            SalesPointCount = int.Parse(SearchForValue("Количество обслуживаемых ТТ"))
                        };
                        repository.Delete(oldDistrict);
                        repository.Add(newDistrict);

                        FillFilteredTableDistrict();
                        break;
                    }
            }
            Program.Controller.Message("Выбранные записи обновлены");
        }

        private void DeleteSelected()
        {
            switch (tableToChange)
            {
                case TableToChange.Distance:
                    {
                        List<int> selectedRows = new List<int>();
                        foreach (DataGridViewCell cell in dgvData.SelectedCells)
                        {
                            if (!selectedRows.Contains(cell.RowIndex)) selectedRows.Add(cell.RowIndex);
                        }
                        foreach (int item in selectedRows)
                        {
                            int startPoint = int.Parse(dgvData[0, item].Value.ToString());
                            int endPoint = int.Parse(dgvData[1, item].Value.ToString());
                            Repository<DistanceBetweenSalesPoints> repository = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
                            DistanceBetweenSalesPoints distanceBn = repository.All().ToList()
                                .First(x => x.StartSalesPointNumber == startPoint &&
                                x.EndSalesPointNumber == endPoint);
                            repository.Delete(distanceBn);
                        }
                        FillFilteredTableDistance();
                        break;
                    }
                case TableToChange.District:
                    {
                        List<int> selectedRows = new List<int>();
                        foreach (DataGridViewCell cell in dgvData.SelectedCells)
                        {
                            if (!selectedRows.Contains(cell.RowIndex)) selectedRows.Add(cell.RowIndex);
                        }
                        foreach (int item in selectedRows)
                        {
                            int district = int.Parse(dgvData[0, item].Value.ToString());
                            Repository<District> repository = new Repository<District>(NHibernateHelper.OpenSession());
                            District districtValue = repository.All().ToList()
                                .First(x => x.DistrictNumber == district);
                            repository.Delete(districtValue);
                        }
                        FillFilteredTableDistrict();
                        break;
                    }
            }
            Program.Controller.Message("Выбранные записи удалены");
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (action == TableAction.Update && dgvData.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = dgvData.SelectedCells[0];
                int selectedRow = cell.RowIndex;
                switch (tableToChange)
                {
                    case TableToChange.District:
                        {
                            int district = int.Parse(dgvData[0, selectedRow].Value.ToString());
                            Repository<District> repository = new Repository<District>(NHibernateHelper.OpenSession());
                            District districtValue = repository.All().ToList().First(x => x.DistrictNumber == district);
                            settingsTable.Rows[0].Value = districtValue.DistrictNumber.ToString();
                            settingsTable.Rows[1].Value = districtValue.Name;
                            settingsTable.Rows[2].Value = districtValue.SalesPointCount.ToString();
                            Program.Controller.Message("Обновите данные по выбранному району и нажмите кнопку \"Сохранить\"");
                            break;
                        }
                    case TableToChange.Distance:
                        {
                            int startPoint = int.Parse(dgvData[0, selectedRow].Value.ToString());
                            int endPoint = int.Parse(dgvData[1, selectedRow].Value.ToString());
                            Repository<DistanceBetweenSalesPoints> repository = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
                            DistanceBetweenSalesPoints distanceValue = repository.All().ToList().First(x => x.StartSalesPointNumber == startPoint && x.EndSalesPointNumber == endPoint);
                            settingsTable.Rows[0].Value = distanceValue.StartSalesPointNumber.ToString();
                            settingsTable.Rows[1].Value = distanceValue.EndSalesPointNumber.ToString();
                            settingsTable.Rows[2].Value = distanceValue.DistrictNumber.ToString();
                            settingsTable.Rows[3].Value = distanceValue.Distance.ToString();
                            settingsTable.Rows[4].Value = distanceValue.InformationAboutPath;
                            Program.Controller.Message("Обновите данные по выбранной записи и нажмите кнопку \"Сохранить\"");
                            break;
                        }
                }
            }
        }
    }
}
