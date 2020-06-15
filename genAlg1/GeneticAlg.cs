using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace genAlg1
{
    class GeneticAlg
    {
        private int[,] matrixWeight;
        //private int[] route;
        private int sizeMatrix, sizePopulation;
        private double p1, p2, p3;
        private int iteration;
        private List<int[]> oldPopulation, newPopulation;
        private int[] routeElite;

        public GeneticAlg(int[,] matrixWeight, double p1, double p2, double p3, int sizePopulation, int iteration)
        {
            //sizeMatrix = matrixWeight.GetLength(0);
            //Array.Copy(this.matrixWeight, matrixWeight,sizeMatrix*sizeMatrix);
            this.matrixWeight = (int[,])matrixWeight.Clone();
            sizeMatrix = this.matrixWeight.GetLength(0);
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.sizePopulation = sizePopulation;
            this.iteration = iteration;
            oldPopulation = new List<int[]>();
            newPopulation = new List<int[]>();
            startPopulation(sizePopulation, sizeMatrix);
            oldPopulation.Sort(compareRoutes);
            routeElite = (int[])oldPopulation.First().Clone();
            workGenAlg();
            //this.matrixWeight.CopyTo= matrixWeight;
        }
        public int[] RouteElite
        {
            get
            {
                return routeElite;
            }
        }

        private int[] workGenAlg()
        {
            int[] x;
            int[] y;
            for (int step = 0; step < iteration; step++)
            {
                while (oldPopulation.Count > 0)
                {
                    x = oldPopulation[0];
                    oldPopulation.RemoveAt(0);
                    while (oldPopulation.Count > 0)
                    {
                        y = oldPopulation[0];
                        oldPopulation.RemoveAt(0);
                        crossingover(x, y);
                    }

                }
                int sizeNewPopulation = newPopulation.Count;
                Random rnd = new Random();
                for (int i = 0; i < sizeNewPopulation; i++)
                {
                    if (rnd.NextDouble() < p1)
                    {
                        reversMutation(newPopulation[i]);
                        if (rnd.NextDouble() < p2)
                        {
                            reversMutation(newPopulation[i]);
                        }
                    }
                }
                selectPopulation();
            }
            int k = Weight(routeElite);
            return routeElite;

        }

        private (int, int) LRrandom(int size)
        {
            Random rndm = new Random();
            int L, R;
            L = rndm.Next(1, size);
            R = rndm.Next(1, size);
            if (R < L)
            {
                int k = L;
                L = R;
                R = k;
            }
            return (L, R);
        }
        private int Weight(int[] route)
        {
            int weight = 0;
            for (int i = 2; i < sizeMatrix; i++)
            {
                weight += matrixWeight[ route[i-1], route[i]];
            }
            weight += matrixWeight[ 0, route[1]] + matrixWeight[route[sizeMatrix - 1], 0];//

            return weight;
        }
        private void crossingover(int[] x, int[] y)
        {
            Random rndm = new Random();
            int size = x.Length;
            int[] crossRoute1 = new int[size];
            int[] crossRoute2 = new int[size];
            int point = rndm.Next(1, size);
            for (int i = 1; i < point; i++)
            {
                crossRoute1[i] = x[i];
                crossRoute2[i] = y[i];
            }
            int index = point;
            for (int iY = 1; iY < size; iY++)
            {
                bool flagCopy = true;
                for (int k = 1; k < point; k++)
                {
                    if (y[iY] == crossRoute1[k])
                    {
                        flagCopy = false;
                        break;
                    }
                }
                if (flagCopy)
                {
                    crossRoute1[index] = y[iY];
                    index++;
                }
            }
            index = point;
            for (int iX = 1; iX < size; iX++)
            {
                bool flagCopy = true;
                for (int k = 1; k < point; k++)
                {
                    if (x[iX] == crossRoute2[k])
                    {
                        flagCopy = false;
                        break;
                    }
                }
                if (flagCopy)
                {
                    crossRoute2[index] = x[iX];
                    index++;
                }
            }
            crossRoute1[0] = Weight(crossRoute1);
            crossRoute2[0] = Weight(crossRoute2);

            newPopulation.Add(crossRoute1);
            newPopulation.Add(crossRoute2);

        }
        private void routeRandom(int sizeRoute)
        {
            Random rnd = new Random();
            int[] route = new int[sizeRoute];
            List<int> listIndex = new List<int>();

            for (int i = 1; i < sizeRoute; i++)
            {
                listIndex.Add(i);
            }
            int index;
            for (int i = 1; listIndex.Count > 0; i++)
            {
                index = rnd.Next(0, listIndex.Count);
                route[i] = listIndex[index];
                listIndex.RemoveAt(index);
            }
            route[0] = Weight(route);
            oldPopulation.Add(route);
        }
        private void routeInc(int sizeRoute)
        {
            int[] route = new int[sizeRoute];
            for (int i = 1; i < sizeRoute; i++)
            {
                route[i] = i;
            }
            route[0] = Weight(route);
            oldPopulation.Add(route);
        }
        private void routeNeighbors(int sizeRoute)
        {
            int min;
            int index;
            List<int> listIndex = new List<int>();
            int[] route = new int[sizeRoute];

            for (int i = 1; i < sizeRoute; i++)
            {
                listIndex.Add(i);
            }

            for (int i = 1, x = 0; listIndex.Count > 0; i++)
            {
                min = matrixWeight[x, listIndex.First()];
                index = 0;
                for (int y = 1; y < listIndex.Count; y++)
                {
                    if (min > matrixWeight[x, listIndex[y]])
                    {
                        min = matrixWeight[x, listIndex[y]];
                        index = y;
                    }
                }
                route[i] = listIndex[index];
                x = listIndex[index];
                listIndex.RemoveAt(index);
            }
            route[0] = Weight(route);
            oldPopulation.Add(route);
        }



        private void startPopulation(int sizePopulation, int sizeRoute)
        {
            oldPopulation.Clear();
            newPopulation.Clear();
            routeNeighbors(sizeRoute);
            routeInc(sizeRoute);
            for (int i = oldPopulation.Count; i < sizePopulation; i++)
            {
                routeRandom(sizeRoute);
            }

        }
        private void reversMutation(int[] route)
        {
            int L, R;
            int sizeRout = route.Length;
            (L, R) = LRrandom(sizeRout);
            int[] routeMutation = new int[sizeRout];

            for (int i = 1; i < L; i++)
            {
                routeMutation[i] = route[i];
            }
            for (int i = 0; i < (R - L) + 1; i++)
            {
                routeMutation[L + i] = route[R - i];
            }
            for (int i = R + 1; i < sizeRout; i++)
            {
                routeMutation[i] = route[i];
            }
            routeMutation[0] = Weight(routeMutation);
            newPopulation.Add(routeMutation);
        }
        private int compareRoutes(int[] x, int[] y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    return x[0].CompareTo(y[0]);
                }
            }
        }
        private void selectPopulation()
        {
            // oldPopulation.Sort(compareRoutes);
            //int[] route= (int[]) routeElite.Clone();
            oldPopulation.Clear();
            oldPopulation.Add(routeElite);
            newPopulation.Sort(compareRoutes);
            for (int i = 0; i < sizePopulation - 1; i++)
            {

                oldPopulation.Add(newPopulation.First());
                newPopulation.RemoveAt(0);
            }
            if (routeElite[0] > oldPopulation[1][0])
            {
                routeElite = (int[])oldPopulation[1].Clone();
            }

        }
    }
}
