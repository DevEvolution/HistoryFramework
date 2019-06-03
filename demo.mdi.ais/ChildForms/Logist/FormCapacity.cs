using HistoryFramework;
using System;
using System.Windows.Forms;

namespace DemoProject.ChildForms.Logist
{
    public partial class FormCapacity : Form
    {
        public HistoryController HistoryController { get; set; }

        public FormCapacity()
        {
            InitializeComponent();

            HistoryController.Message("Выполните рассчеты комплектации машин");
        }

        private void FormCapacity_Load(object sender, EventArgs e)
        {

        }

        private void dgvTotalDeliveryVolumes_Click(object sender, EventArgs e)
        {

        }

        private void dgvTotalDeliveryVolumes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
