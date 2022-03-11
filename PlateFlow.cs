using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DripSolve
{
    public class PlateFlow
    {
        //Plate flow describes the laminar viscous flow between two parallel plates

        private int method;

        #region Initial Conditions 
        private static double u0 = 0;// m/s
        private static double L = 2;// Cm
        private static double B = -20;// Pa/m
        private static double rho = 1000;// kg/m^2
        private static double mu0 = 0.03;// Pa*s
        private static double A = 0.05;// Pa*s/m
        private static double U = 0.05;// m/s
        #endregion

        #region Governing Equations

        public Func<double, double> mu = delegate (double y)
         {
             double temp = mu0 + A * y;
             return (temp);
         };


        #endregion

        #region Exact Equations
        //This will give us the exact du/dy for analysis
        public Func<List<double>, double> Edudy = delegate (List<double> vars)
         {
             //vars layout:
             //vars[0] = y
             //vars[1] = c1
             return ((B*Math.Log(Math.Abs(A*vars[0]+mu0)))/A + vars[1]);
             
         };

        public Func<List<double>, double> Eu = delegate (List<double> vars)
         {
             //vars layout:
             //vars[0] = y
             //vars[1] = c1
             //vars[2] = c2
             return ((B * (A * vars[0] + mu0) * (Math.Log(Math.Abs(A * vars[0] + mu0)) - 1)) / (Math.Pow(A, 2))) + vars[1] * vars[0] + vars[2];
         };
        #endregion

        #region Solution Values
        public List<double> y { get; set; }
        public double dy { get; set; }

        private double c1 { get; set; }
        private double c2 { get; set; }

        private List<double> d2udy { get; set; }
        public List<double> solveU { get; set; }
        private List<double> a0 { get; set; }

        public double[,] matrix { get; set; }

        #endregion
        public PlateFlow()
        {
            //Base Constructor Creates Direct Solution
            //first find what c1 is, c2 is 0
            c2 = -1* ((B * mu0 * (Math.Log(Math.Abs(mu0))-1))/(Math.Pow(A,2)));
            c1 = (U/L) - (c2/L) - ((B*(A*L+mu0)*(Math.Log(Math.Abs(A*L+mu0)) - 1))/(Math.Pow(A,2) * L));
            
            method = 0;

        }

        public PlateFlow(int m,int N)
        {
            method = m;
            //Method = 1 Bisect method
            //Method = 2 Secant method
            //Method = 3 Direct method
            y = new List<double>();
            //When not solving exactky we need to make a list of y points for each solution value
            dy = L / (N-1);
            for (int i = 0; i < N; i++)
            {
                y.Add(i * dy);
            }
            

            switch (method)
            {
                case 1:
                    setUpBisect();
                    break;
                case 2:
                    setUpSecant();
                    break;
                case 3:
                    setUpDirect();
                    break;
            }
        }

        #region SetUp
        private void setUpBisect()
        {
            a0 = new List<double>();
            a0.Add(10000.0);
        }
        
        private void setUpSecant()
        {
            a0 = new List<double>();
            a0.Add(10000.0);
        }

        private void setUpDirect()
        {

        }
        #endregion

        #region Solves
        public void Solve()
        {
            switch (method)
            {
                case 1:
                    solveBisect();
                    break;
                case 2:
                    solveSecant();
                    break;
                case 3:
                    solveDirect();
                    break;
            }
        }
        public void Solve(List<double> grid)
        {
            //this only works for direct method
            if(method == 0)
            {
                a0 = new List<double>();
                solveU = new List<double>();
                solveU.Add(0);
                for(int i = 1; i < grid.Count; i++)
                {
                    List<double> a = new List<double>();
                    a.Add(grid[i]);
                    a.Add(c1);
                    a.Add(c2);
                    solveU.Add(Eu(a));
                }
                List<double> b = new List<double>();
                b.Add(grid[0]);
                b.Add(c1);
                a0.Add(Edudy(b));

            }
        }

        private void solveBisect()
        {
            bool go = true;
            int index = 0;
            double mina = 0;
            double maxa = a0[0];
            while (go)
            {
               
                double foundu = 0; //this is the final U value, will be used to determine if converges
                solveU = new List<double>();
                solveU.Add(u0);
                for(int i = 0; i < y.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        solveU.Add(solveU[0] + a0[a0.Count - 1] * dy);
                    }
                    else
                    {
                        solveU.Add((B / mu(y[i+1]) * Math.Pow(dy, 2)) - solveU[i - 1] + (2 * solveU[i]));
                    }

                }
                    
                foundu = solveU[solveU.Count - 1];

                if (foundu == U || Math.Abs(foundu - U) < 0.000000001 )
                {
                    go = false;
                }
                else if(foundu > U)
                {
                    maxa = a0[a0.Count - 1];
                    a0.Add(mina + ((maxa - mina)/2));
                }
                else
                {
                    mina = a0[a0.Count - 1];
                    a0.Add(mina + ((maxa - mina) / 2));
                }
                index = index + 1;
            }
        }
        private void solveSecant()
        {
            bool go = true;
            int index = 0;
            List<double> foundu = new List<double>();
            while (go)
            {
                
                solveU = new List<double>();
                solveU.Add(u0);
                for (int i = 0; i < y.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        solveU.Add(solveU[0] + a0[a0.Count - 1] * dy);
                    }
                    else
                    {
                        solveU.Add((B / mu(y[i+1])) * Math.Pow(dy, 2) - solveU[i - 1] + 2 * solveU[i]);
                    }
                }

                foundu.Add(solveU[solveU.Count - 1]);
                if (index > 0)
                { 
                    if(a0[a0.Count -1] == a0[a0.Count -2] || Math.Abs(a0[a0.Count - 1]-a0[a0.Count - 2]) < 0.00000001)
                    {
                        go = false;
                    }
                    else
                    {
                        int cnt = a0.Count - 1;
                        a0.Add(a0[cnt] - (foundu[cnt] * (a0[cnt] - a0[cnt - 1])) / (foundu[cnt] - foundu[cnt - 1]));
                    }
                }
                else
                {
                    a0.Add(0);
                }
                index++;
            }
        }
        private void solveDirect()
        {
            List<double> d2udy = new List<double>();
            //creates the matrix of (d^2u/dy^2 = B/mu)
            for(int i = 1; i < y.Count-1; i++)
            {
                d2udy.Add(B/mu(y[i]));
            }
            //next the second order matrix
            //will be square of d2udy length to ensure it can be inverted
            matrix = new double[d2udy.Count, d2udy.Count+1];
            for(int i = 0; i < d2udy.Count; i++)
            {
                for(int q = 0; q < d2udy.Count+1; q++)
                {
                    if(q == i)
                    {
                        matrix[i,q] = 2 * (1 / Math.Pow(dy, 2));
                    }
                    else if (q == d2udy.Count)
                    {
                        //here we add in d2udy
                        matrix[i, q] = d2udy[i];
                    }
                    else if(q == i-1 || q == i + 1)
                    {
                        matrix[i,q] = (-1 * (1/Math.Pow(dy,2)));
                    }
                    else
                    {
                        matrix[i,q] = 0;
                    }
                    
                }
            }
            //Then invert matrix
            //choosing to do gauss-jordan for inverting this matrix system
            int n = d2udy.Count;
            int k = 0;
            int c = 0;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] == 0)
                {
                    c = 1;
                    while ((i + c) < n && matrix[i + c, i] == 0)
                        c++;
                    if ((i + c) == n)
                    {
                        break;
                    }
                    for (j = i, k = 0; k <= n; k++)
                    {
                        double temp = matrix[j, k];
                        matrix[j, k] = matrix[j + c, k];
                        matrix[j + c, k] = temp;
                    }
                }

                for (j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        double p = matrix[j, i] / matrix[i, i];

                        for (k = 0; k <= n; k++)
                        {
                            matrix[j, k] = matrix[j, k] - (matrix[i, k]) * p;
                        }
                            
                    }
                }
            }

            //then we will take the matrix and put it into the solved U's
            solveU = new List<double>();
            a0 = new List<double>();
            solveU.Add(u0);
            for(int i = 0; i < d2udy.Count; i++)
            {
                double temp = (matrix[i, (int)Math.Ceiling(Math.Sqrt(matrix.Length)) -1]  / matrix[i, i]) * -1;
                solveU.Add(temp);
            }
            solveU.Add(U);
            a0.Add((solveU[1]-solveU[0])/dy);

        }
        #endregion


        public List<double> getError(PlateFlow test)
        {
            List<double> ret = new List<double>();

            for(int i = 0; i < solveU.Count; i++)
            {
                ret.Add(Math.Abs(solveU[i] - test.solveU[i]));
            }

            return ret;
        }
    }
}
