using demo.mdi.ais.Helpers;
using demo.mdi.ais.Helpers.ORMInteraction;
using demo.mdi.ais.MathLayer;
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
    public partial class FormPathfinding : Form
    {
        List<Request> _requests;
        List<int> path = new List<int>();
        int distance;

        public FormPathfinding(List<Request> requests)
        {
            InitializeComponent();
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Машина №5:" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "грузовик;" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "Маршрут №34 успешно построен" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = "дата выхода 02.05.2018" });
            row.Height = 50;
            dgvCars.Rows.Add(row);
            _requests = requests;
            Calculate();
        }

        private void FormPathfinding_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Repository<Request> repository = new Repository<Request>(NHibernateHelper.OpenSession());
            foreach (var req in _requests)
            {
                var newReq = repository.All().ToList().FirstOrDefault(x => x.RequestNumber == req.RequestNumber && x.SalesPointNumber == req.SalesPointNumber
                && x.ShipmentNumber == req.ShipmentNumber);
                newReq.RequestStatus = "в обработке";
                repository.Update(newReq);
            }
            Program.Controller.Close();
        }

        private void Calculate()
        {
            List<int> salesPointsMapping = new List<int>();
            salesPointsMapping.Add(1);
            _requests.ForEach(x => { if (!salesPointsMapping.Contains(x.SalesPointNumber)) salesPointsMapping.Add(x.SalesPointNumber); });
            int[,] distanceMatrix = new int[salesPointsMapping.Count, salesPointsMapping.Count];
            //NHibernateHelper.OpenSession().Clear();
            Repository<DistanceBetweenSalesPoints> distances = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
            
            for (int i = 0; i < salesPointsMapping.Count; i++)
            {
                for (int j = 0; j < salesPointsMapping.Count; j++)
                {
                    if (i == j)
                        distanceMatrix[i, j] = 0;
                    else
                    {
                        {
                            var distanceBnPoints = distances.All().ToList().FirstOrDefault(x => x.StartSalesPointNumber == salesPointsMapping[i] && x.EndSalesPointNumber == salesPointsMapping[j]);
                            var ee = distances.All().ToList();
                            if (distanceBnPoints != null)
                            {
                                distanceMatrix[i, j] = distanceBnPoints.Distance;
                            }
                            else
                            {
                                distanceMatrix[i, j] = FWAlgorithm.INFINITE;
                            }
                        }
                    }
                }
            }
            FWPathfinder pathfinder = new FWPathfinder(new FWAlgorithm(distanceMatrix));
            foreach (int item in pathfinder.Path)
            {
                path.Add(salesPointsMapping[item]);
            }
            distance = pathfinder.Distance;
        }
    }
}
