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
        bool finalPoint;

        public FormPathfinding(List<Request> requests, bool final)
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
            finalPoint = final;
            Calculate();
            Program.Controller.Message("Построение маршрута завершено");

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
            if (finalPoint)
            {
                var formRequest = Program.Controller.History.FirstOrDefault(x => x is FormRequest);
                if (formRequest != null)
                {
                    Program.Controller.Message("Все маршруты успешно построены");
                    Program.Controller.SetActiveForm(formRequest);
                    return;
                }
            }
            Program.Controller.Message("Маршрут успешно построен");
            Program.Controller.Close();
        }

        private void Calculate()
        {
            List<int> fullMapping = new List<int>();
            List<int> salesPointsMapping = new List<int>();
            salesPointsMapping.Add(1);
            _requests.ForEach(x => { if (!salesPointsMapping.Contains(x.SalesPointNumber)) salesPointsMapping.Add(x.SalesPointNumber); });

            Repository<DistanceBetweenSalesPoints> distances = new Repository<DistanceBetweenSalesPoints>(NHibernateHelper.OpenSession());
            var allDistancePoints = distances.All().ToList();
            fullMapping = new Repository<SalesPoint>(NHibernateHelper.OpenSession()).All().ToList().Select(x => x.SalesPointNumber).Distinct().ToList();
            int[,] distanceMatrix = new int[allDistancePoints.Count, allDistancePoints.Count];

            for (int i = 0; i < allDistancePoints.Count; i++)
            {
                for (int j = 0; j < allDistancePoints.Count; j++)
                {
                    if (i == j)
                        distanceMatrix[i, j] = 0;
                    else
                    {
                        {
                            var distanceBnPoints = allDistancePoints.FirstOrDefault(x => x.StartSalesPointNumber == fullMapping[i] && x.EndSalesPointNumber == fullMapping[j]);
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
            FWPathfinder pathfinder = new FWPathfinder(new FWAlgorithm(distanceMatrix), salesPointsMapping);
            foreach (int item in pathfinder.Path)
            {
                path.Add(salesPointsMapping[item]);
            }
            distance = pathfinder.Distance;
            SaveResults();
        }

        private void SaveResults()
        {
            Route route = new Route();
            route.CarNumber = 5;
            route.RouteNumber = 34;
            route.CarDepartureDate = new DateTime(2018, 5, 2);
            route.ConversionsNumber = path.Count - 1;
            Repository<Route> routes = new Repository<Route>(NHibernateHelper.OpenSession());
            routes.Add(route);

            Repository<RouteScheme> schemes = new Repository<RouteScheme>(NHibernateHelper.OpenSession());
            schemes.Delete(schemes.FilterBy(x => x.RouteNumber == 5));

            int from = path[0];
            for (int i = 1; i < path.Count; i++)
            {
                int to = path[i];
                RouteScheme routeScheme = new RouteScheme();
                routeScheme.RouteSectorNumber = i;
                routeScheme.RouteNumber = 34;
                routeScheme.StartPointNumber = from;
                routeScheme.EndPointNumber = to;
                schemes.Add(routeScheme);
                from = to;
            }
        }
    }
}
