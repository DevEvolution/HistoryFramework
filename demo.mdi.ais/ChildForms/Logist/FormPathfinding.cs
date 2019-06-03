using HistoryFramework;
using System;
using System.Windows.Forms;

namespace DemoProject.ChildForms.Logist
{
    public partial class FormPathfinding : Form
    {
        public HistoryController HistoryController { get; set; }

        public FormPathfinding()
        {
            InitializeComponent();
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Машина №5:" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "грузовик;" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Маршрут №34 успешно построен" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "дата выхода 02.05.2018" });
            row.Height = 50;
            dgvCars.Rows.Add(row);
            HistoryController.Message("Построение маршрута завершено");

        }

        private void FormPathfinding_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HistoryController.Message("Маршрут успешно построен");
            HistoryController.Close();
        }
    }
}
