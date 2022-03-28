using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DripSolve
{
    public class Bugers
    {
        #region solution variables
        public List<double> time { get; set; }
        public List<double> space { get; set; }
        public List<List<double>> solution { get; set; }
        #endregion

        #region boundary conditions & equations
        private const double xMin = -1;
        private const double xMax = 1;
        
        Func<double, double> u0x = delegate(double x)
         {
             //input x output u0(x,t=0) = -sin(pi*x)
             return -1 * Math.Sin(Math.PI * x);
         };

        #endregion
        public Bugers(double deltax)
        {
            space = new List<double>();
            time = new List<double>();
            double i = xMin;
            while(i < xMax + deltax){
                space.Add(Math.Round(i,6));
                i = i + deltax;
            }
        }

        public void Solve(int method)
        {
            //methods:
            // 1 = 2nd order Central Difference; v = 0
            // 2 = Lax-Friedrichs; v = 0
            // 3 = Kurganov-Tadmor; v  = 0
            // 4 = 2nd Order Central Difference; v = 0.01/pi
            // 5 = Lax-Friedrichs; v = 0.01/pi
            switch (method)
            {
                case 1:
                    SolveCD(0.0);
                    break;
                case 2:
                    SolveLF(0.0);
                    break;
                case 3:
                    SolveKT();
                    break;
                case 4:
                    SolveCD(0.01/Math.PI);
                    break;
                case 5:
                    SolveLF(0.01 / Math.PI);
                    break;
            }

        }

        public void SolveCD(double v)
        {
            
            
            

            
        }
        public void SolveLF(double v)
        {

        }
        public void SolveKT()
        {

        }
    }
}
