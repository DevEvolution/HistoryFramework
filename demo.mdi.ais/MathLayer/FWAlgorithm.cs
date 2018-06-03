using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.MathLayer
{
    public class FWAlgorithm
    {
        public static readonly int INFINITE = 1000000;
        public int Size { get; }
        public (int waypoint, int distance)[,] Nodes { get; }

        public FWAlgorithm(int[,] distances)
        {
            Size = distances.GetLength(0);
            Nodes = new(int, int)[Size, Size];
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                {
                    Nodes[i, j].distance = distances[i, j];
                    if (i == j) Nodes[i, j].waypoint = 0;
                    else Nodes[i, j].waypoint = j;
                }

            for (int k = 0; k < Size; k++)
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (Nodes[i, k].distance + Nodes[k, j].distance < Nodes[i, j].distance)
                        {
                            Nodes[i, j].distance = Nodes[i, k].distance + Nodes[k, j].distance;
                            Nodes[i, j].waypoint = k;
                        }
                    }
                }
            }
        }

        public List<int> GetPath(int fromPoint, int toPoint)
        {
            List<int> path = new List<int>();
            int currentPoint = toPoint;
            if (Nodes[fromPoint, toPoint].waypoint != toPoint)
            {
                do
                {
                    path.Add(Nodes[fromPoint, currentPoint].waypoint);
                    currentPoint = Nodes[fromPoint, currentPoint].waypoint;
                } while (currentPoint != Nodes[fromPoint, currentPoint].waypoint);
                path.Reverse();
            }

            path.Add(toPoint);
            return path;
        }

        public (int waypoint, int distance) this[int vertical, int horizontal]
        {
            get => Nodes[vertical, horizontal];
        }
    }
}
