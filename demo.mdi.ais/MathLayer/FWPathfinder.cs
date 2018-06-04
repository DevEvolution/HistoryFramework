using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.MathLayer
{
    class FWPathfinder
    {
        private FWAlgorithm floyd;
        private bool[,] ZMatrix;
        public List<int> Path { get => fullRound; }
        private List<int> fullRound = new List<int>();
        //private List<(int,bool)> needList;
        private List<int> needList;
        public int Distance { get; private set; }

        public FWPathfinder(FWAlgorithm floydResults, List<int> needList)
        {
            floyd = floydResults;
            ZMatrix = new bool[floyd.Size, floyd.Size];
            ZMatrix[0, 0] = true;
            this.needList = needList;
            //foreach (int point in needList)
            //    this.needList.Add((point, false));
            CalculateRoute();
        }

        public void CalculateRoute()
        {
            int currentPoint = 0;
            do
            {
                currentPoint = FindNextTargetPoint(currentPoint);
            }
            while (currentPoint != -1);
            int last = fullRound.Last();
            foreach (var item in floyd.GetPath(last, 0))
            {
                fullRound.Add(item);
            }
            Distance += floyd[last, fullRound.Last()].distance;
        }


        public int FindNextTargetPoint(int fromPoint)
        {
            (int point, int distance) minimumDistancePoint = (-1, 99999);
            for (int i = 0; i < floyd.Size; i++)
            {
                int toPoint = i;
                if (needList.Contains(toPoint) && !ZMatrix[fromPoint, toPoint] && !fullRound.Contains(toPoint) && floyd[fromPoint, toPoint].distance < minimumDistancePoint.distance)
                {
                    minimumDistancePoint = (toPoint, floyd[fromPoint, toPoint].distance);
                }
            }
            if (minimumDistancePoint.point == -1) return -1;

            Distance += minimumDistancePoint.distance;
            var path = floyd.GetPath(fromPoint, minimumDistancePoint.point);
            int previous = fromPoint;
            if (fullRound.Count == 0 || fullRound.Last() != previous)
            {
                fullRound.Add(previous);

            }
            for (int j = 0; j < path.Count; j++)
            {
                ZMatrix[previous, path[j]] = true;
                fullRound.Add(path[j]);
            }
            return minimumDistancePoint.point;
        }
    }
}
