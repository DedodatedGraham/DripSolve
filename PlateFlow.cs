using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             return ((B / (mu0 + A * vars[0]))* vars[0] + vars[1]);
         };

        public Func<List<double>, double> Eu = delegate (List<double> vars)
         {
             //vars layout:
             //vars[0] = y
             //vars[1] = c1
             return ((B/(mu0 + A * vars[0]))*(Math.Pow(vars[0],2) / 2)+(vars[1]*vars[0]));
         };
        #endregion

        #region Solution Values
        public List<double> y { get; set; }
        public double dy { get; set; }

        private double c1 { get; set; }

        private double a0 { get; set; }
        #endregion
        public PlateFlow()
        {
            //Base Constructor Creates Direct Solution
            //first find what c1 is, c2 is 0
            c1 = (U / L) - (B / mu(L)) * (L / 2);


        }

        public PlateFlow(int m,int N)
        {
            method = m;
            //Method = 1 Shooting method
            //Method = 2 Secant method
            //Method = 3 Direct method
            y = new List<double>();
            //When not solving directly we need to make a list of y points for each solution value
            dy = L / (N-1);
            for (int i = 0; i < N; i++)
            {
                y.Add(i * dy);
            }
            

            switch (method)
            {
                case 1:
                    setUpShoot();
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
        private void setUpShoot()
        {
            a0 = 1;
        }
        
        private void setUpSecant()
        {

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
                    solveShoot();
                    break;
                case 2:
                    solveSecant();
                    break;
                case 3:
                    solveDirect();
                    break;
            }
        }

        private void solveShoot()
        {
            bool go = true;
        }
        private void solveSecant()
        {

        }
        private void solveDirect()
        {

        }
        #endregion
    }
}
