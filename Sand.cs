using System;

namespace SandPile
{
    public enum EpsionDis { Random, Directed, Elliptical};

    public class Sand
    {
        public int Lx, Ly;
        public int[,] massSites;
        public Direction[,] eSites;
        public EpsionDis epsilonDis;
        public int e, m, numFalledGrains;
        public int minAdded = 1, maxAdded = 1000, scale = 4000, scalak = 1000;

        
        public int xInit, yInit, topledValueInit;
        public int[,] h;
        public bool isCompleteAvalanche;

        static int[] nnX = new int[] { 1, -1, 0, 0 };
        static int[] nnY = new int[] { 0, 0, 1, -1};
        Random rand = new Random();
         


        public Sand(int Lx, int Ly, int e, int m, EpsionDis epsilonDis)
        {
            this.Lx = Lx;
            this.Ly = Ly;
            this.e = e;
            this.m = m;
            h = new int[Lx, Ly];

            massSites = new int[Lx, Ly];
            eSites = new Direction[Lx, Ly];
            this.epsilonDis = epsilonDis;

            InitEpsilon();
            InitMass();
            InitHeigths();

            isCompleteAvalanche = true;
        }

        void InitEpsilon()
        {
            int i, j;
            switch (epsilonDis)
            {
                case EpsionDis.Directed:
                    for (i = 0; i < Lx; i++)
                        for (j = 0; j < Ly; j++)
                            eSites[i, j] = new Direction(e, -e, e, -e);
                    break;
                case EpsionDis.Elliptical:
                    for (i = 0; i < Lx; i++)
                        for (j = 0; j < Ly; j++)
                            eSites[i, j] = new Direction(e, e, -e, -e);
                    break;
                case EpsionDis.Random:
                    int temp_e;
                    for (i = 0; i < Lx; i++)
                        for (j = 0; j < Ly; j++)
                        {
                            temp_e = (rand.NextDouble() < 0.5) ? e : -e;
                            eSites[i, j] = new Direction(temp_e, temp_e, -temp_e, -temp_e);
                        }
                    break;
            }
        }

        void InitMass()
        {
            for (int i = 0; i < Lx; i++)
                for (int j = 0; j < Ly; j++)
                    massSites[i, j] = m;
        }

        void InitHeigths()
        {
            for (int i = 0; i < Lx; i++)
                for (int j = 0; j < Ly; j++)
                    h[i, j] = rand.Next(scalak + 1, scale + 1);
        }

      

        bool IsInLattice(int x, int y)
        {
            if (x >= 0 && x < Lx && y >= 0 && y < Ly)
                return true;
            return false;
        }

        public void PropagateOneWave()
        {
            Topple(xInit, yInit, topledValueInit);
            if (h[xInit, yInit] > topledValueInit)
                isCompleteAvalanche = false;
            else
                isCompleteAvalanche = true;
        }

        void Topple(int x, int y, int topledValue)
        {
            if (h[x, y] <= topledValue)
                return;

            h[x, y] += -topledValue;
            int x2 = x + 1, x1 = x - 1;
            int y2 = y + 1, y1 = y - 1;

            if (x2 < Lx)
            {
                h[x2, y] += scalak + eSites[x, y].right;
                int topledValueNew = scale + massSites[x2, y];
                if ((x2 != xInit || y != yInit) && h[x2, y] > topledValueNew)
                    Topple(x2, y, topledValueNew);
            }

            if (x1 >= 0)
            {
                h[x1, y] += scalak + eSites[x, y].left;
                int topledValueNew = scale + massSites[x1, y];
                if ((x1 != xInit || y != yInit) && h[x1, y] > topledValueNew)
                    Topple(x1, y, topledValueNew);
            }


            if (y2 < Ly)
            {
                h[x, y2] += scalak + eSites[x, y].up;
                int topledValueNew = scale + massSites[x, y2];
                if ((x != xInit || y2 != yInit) && h[x, y2] > topledValueNew)
                    Topple(x, y2, topledValueNew);
            }

            if (y1 >= 0)
            {
                h[x, y1] += scalak + eSites[x, y].down;
                int topledValueNew = scale + massSites[x, y1];
                if ((x != xInit || y1 != yInit) && h[x, y1] > topledValueNew)
                    Topple(x, y1, topledValueNew);
            }

        }

        public void AddOneGrain()
        {
            isCompleteAvalanche = true;
            numFalledGrains++;

            int x0 = rand.Next(Lx);
            int y0 = rand.Next(Ly);
            h[x0, y0] += rand.Next(minAdded, maxAdded);
            int topledValue = scale + massSites[x0, y0];

            xInit = x0;
            yInit = y0;
            topledValueInit = topledValue;
            if (h[x0, y0] > topledValue)
                PropagateOneWave();


        }
      

    }

   
}
