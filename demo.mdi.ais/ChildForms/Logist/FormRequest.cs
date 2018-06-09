using demo.mdi.ais.Helpers;
using demo.mdi.ais.Helpers.ORMInteraction;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais.ChildForms.Logist
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            Program.Controller.Message($"Добро пожаловать, {Authorization.AuthorizedAccount.login}");
        }

        private void datePickerBorderDate_ValueChanged(object sender, EventArgs e)
        {
            dgvRequest.Rows.Clear();
            foreach (Request request in new Repository<Request>(NHibernateHelper.OpenSession()).All().Where(x => x.RequestStatus == "активна" && x.BorderDeliveryDate <= datePickerBorderDate.Value))
                dgvRequest.Rows.Add(true, request.RequestNumber, request.SalesPointNumber, request.ShipmentNumber, request.BorderDeliveryDate.ToShortDateString(), request.Count);

            Program.Controller.Message("Отметьте все необходимые заявки");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<Request> requests = new List<Request>();

            foreach (DataGridViewRow row in dgvRequest.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int requestNumber = Convert.ToInt32(row.Cells[1].Value);
                    int salesPointNumber = Convert.ToInt32(row.Cells[2].Value);
                    int shipmentNumber = Convert.ToInt32(row.Cells[3].Value);
                    DateTime borderDate = Convert.ToDateTime(row.Cells[4].Value);
                    requests.Add(new Repository<Request>(NHibernateHelper.OpenSession()).All().ToList()
                        .First(x => x.RequestNumber == requestNumber && x.SalesPointNumber == salesPointNumber && x.ShipmentNumber == shipmentNumber && x.BorderDeliveryDate == borderDate));
                }
            }
            Program.Controller.Open(new FormCapacity(requests, datePickerBorderDate.Value));
        }
    }
}
