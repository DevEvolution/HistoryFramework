using demo.mdi.ais.Helpers;
using demo.mdi.ais.Helpers.ORMInteraction;
using NHibernate;
using NHibernate.SqlCommand;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais.ChildForms.Logist
{
    public partial class FormCapacity : Form
    {
        IEnumerable<Request> _requests;
        DateTime _borderDeliveryDate;

        public FormCapacity(IEnumerable<Request> requests, DateTime chosenBorderDeliveryDate)
        {
            InitializeComponent();
            _requests = requests;
            _borderDeliveryDate = chosenBorderDeliveryDate;

            dgvTotalDeliveryVolumes.Rows.Clear();
            foreach (var volume in CalculateTotalDiliveryVolumesByDistrict(CalculateVolumesByRequests(), _borderDeliveryDate))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 40;
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = volume.DistrictNumber });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = volume.TotalVolume });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = volume.TotalWeight });
                row.Cells.Add(new DataGridViewButtonCell() { Value = "Рассчитать", FlatStyle=FlatStyle.Flat });
                row.Tag = volume;
                dgvTotalDeliveryVolumes.Rows.Add(row);
            }
            foreach (DataGridViewRow row in dgvTotalDeliveryVolumes.Rows)
            {
                DataGridViewButtonCell button = row.Cells[3] as DataGridViewButtonCell;
                button.Value = "Рассчитать";

                //button.FlatStyle = FlatStyle.Flat;
                //button.Style.ForeColor = Color.CornflowerBlue;
            }
        }

        private void FormCapacity_Load(object sender, EventArgs e)
        {

        }

        private List<RequestVolume> CalculateVolumesByRequests()
        {
            List<RequestVolume> requestVolumes = new List<RequestVolume>();
            var uniqueRequestNumbers = _requests.Select(x => x.RequestNumber).Distinct();

            foreach (int requestNumber in uniqueRequestNumbers)
            {
                double totalWeight = 0;
                double totalVolume = 0;
                List<Request> allRequests = _requests.Where(x => x.RequestNumber == requestNumber).ToList();
                allRequests.ForEach(x => { totalWeight += x.Goods.DeliveryUnitWeight * x.Count; totalVolume += x.Goods.DeliveryUnitVolume * x.Count; });
                var req = _requests.First(x => x.RequestNumber == requestNumber);
                requestVolumes.Add(new RequestVolume()
                {
                    RequestNumber = requestNumber,
                    BorderDeliveryDate = req.BorderDeliveryDate,
                    DistrictNumber = req.SalesPoint.DistrictNumber,
                    TotalVolume = totalVolume,
                    TotalWeight = totalWeight
                });
            }

            Repository<RequestVolume> repository = new Repository<RequestVolume>(NHibernateHelper.OpenSession());
            foreach (RequestVolume volume in requestVolumes)
            {
                RequestVolume volumeInDb = repository.All().ToList().FirstOrDefault(x => x.RequestNumber == volume.RequestNumber);
                if (volumeInDb != null)
                {
                    volumeInDb.BorderDeliveryDate = volume.BorderDeliveryDate;
                    volumeInDb.DistrictNumber = volume.DistrictNumber;
                    volumeInDb.TotalVolume = volume.TotalVolume;
                    volumeInDb.TotalWeight = volume.TotalWeight;
                    repository.Update(volumeInDb);
                }
                else
                    repository.Add(volume);
            }
            return requestVolumes;
        }

        private List<TotalDeliveryVolume> CalculateTotalDiliveryVolumesByDistrict(List<RequestVolume> requestVolumes, DateTime borderDate)
        {
            List<TotalDeliveryVolume> totalDeliveryVolumes = new List<TotalDeliveryVolume>();
            var uniqueDistricts = requestVolumes.Select(x => x.DistrictNumber).Distinct();

            foreach (int district in uniqueDistricts)
            {
                double totalWeight = 0;
                double totalVolume = 0;
                List<RequestVolume> volumes = requestVolumes.Where(x => x.DistrictNumber == district).ToList();
                volumes.ForEach(x => { totalWeight += x.TotalWeight; totalVolume += x.TotalVolume; });
                totalDeliveryVolumes.Add(new TotalDeliveryVolume()
                {

                    DistrictNumber = district,
                    BorderDeliveryDate = borderDate,
                    TotalVolume = totalVolume,
                    TotalWeight = totalWeight
                });
            }

            foreach (TotalDeliveryVolume volume in totalDeliveryVolumes)
            {
                Repository<TotalDeliveryVolume> repository = new Repository<TotalDeliveryVolume>(NHibernateHelper.OpenSession());
                var totalVolume = repository.All().ToList().FirstOrDefault(x => x.DistrictNumber == volume.DistrictNumber);
                if (totalVolume != null)
                {
                    totalVolume.DistrictNumber = volume.DistrictNumber;
                    totalVolume.BorderDeliveryDate = volume.BorderDeliveryDate;
                    totalVolume.TotalVolume = volume.TotalVolume;
                    totalVolume.TotalWeight = volume.TotalWeight;
                    repository.Add(volume);
                }
                else
                    repository.Add(volume);
            }
            return totalDeliveryVolumes;
        }

        private void dgvTotalDeliveryVolumes_Click(object sender, EventArgs e)
        {

        }

        private void dgvTotalDeliveryVolumes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                senderGrid[e.ColumnIndex, e.RowIndex].Style.Font = new Font("Wingdings 2", 22F, FontStyle.Bold);
                senderGrid[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.RoyalBlue;
                senderGrid[e.ColumnIndex, e.RowIndex].Value = "R";

                var volume = senderGrid.Rows[e.RowIndex].Tag as TotalDeliveryVolume;
                List<Request> req = _requests.Where(x => x.SalesPoint.DistrictNumber == volume.DistrictNumber).ToList();

                bool allCount = true;
                for (int i = 0; i < dgvTotalDeliveryVolumes.RowCount; i++)
                {
                    if (dgvTotalDeliveryVolumes[e.ColumnIndex, i].Value != "R")
                        allCount = false;
                }
                if (allCount) btnFinal.Visible = true;

                Program.Controller.Open(new FormPathfinding(req, allCount));
            }

        }
    }
}
