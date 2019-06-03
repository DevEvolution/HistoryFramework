using DemoProject.Helpers;
using HistoryFramework;
using System;
using System.Windows.Forms;

namespace DemoProject.ChildForms.Logist
{
    public partial class FormRequest : Form
    {
        public HistoryController HistoryController { get; set; }

        public FormRequest()
        {
            InitializeComponent();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            HistoryController.Message($"Добро пожаловать, {Authorization.AuthorizedAccount.login}");
        }

        private void datePickerBorderDate_ValueChanged(object sender, EventArgs e)
        {
            HistoryController.Message("Отметьте все необходимые заявки");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        }
    }
}
