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
        public List<List<double>> flux { get; set; }

        #endregion

        #region boundary conditions & equations
        private const double xMin = -1;
        private const double xMax = 1;
        private double dx { get; set; }
        private const double dt = 0.1;

        Func<double, double> u0x = delegate(double x)
         {
             //input x output u0(x,t=0) = -sin(pi*x)
             return -1 * Math.Sin(Math.PI * x);
         };

        #endregion
        public Bugers(double deltax)
        {
            dx = deltax;
            space = new List<double>();
            time = new List<double>();
            solution = new List<List<double>>();
            flux = new List<List<double>>();
            //creates grid for both space and time dimensions
            for(double i = xMin; i < xMax + deltax; i = i + dx)
            {
                space.Add(Math.Round(i, 6));
            }
            for (double j = 0; j <= 0.5; j = j + 0.1)
            {
                time.Add(j);
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
            for(int t = 0; t < time.Count; t++)
            {
                List<double> tsol = new List<double>();
                List<double> tflux = new List<double>();
                if (t == 0)
                {
                    //first time step 
                    //makes guesses from IVP
                    //u(x,t=0) = u0(x) = -sin(pi*x)
                    for(int x = 0; x < space.Count; x++)
                    {
                        //Gets the inital wave u0 = -sin(pi*x)
                        tsol.Add(u0x(space[x]));
                        
                    }
                }
                else
                {
                    //the rest of the timesteps use the last timesteps info to infer
                    for (int x = 0; x < space.Count; x++)
                    {
                        //gets the next time step solution from previous values and flux movement
                        tsol.Add((dt / dx) * (flux[t-1][x+1]- flux[t-1][x]) + solution[t - 1][x]);
                    }
                }
                solution.Add(tsol);
                //calulates flux per timestep, it is needed to find solution at next time step
                for (int x = 0; x < space.Count; x++)
                {
                    //flux has 1 more point than space, meaning each U will have a values on +-1/2
                    //only first itteration needs to calculate j = -1/2
                    //and every other thing will calculate j = j + 1/2
                    double left = 0;
                    double right = 0;
                    if (x == 0)
                    {
                        left = Math.Pow((solution[t][x] - solution[t][space.Count - 1]) / 2, 2) / 2;
                        right = -1 * (v / (2 * dx)) * ((solution[t][x + 1] - solution[t][x]) / dx - (solution[t][space.Count - 1] - solution[t][space.Count - 2]) / dx);
                        tflux.Add(left + right); 

                        double left1 = Math.Pow((solution[t][x + 1] - solution[t][x]) / 2, 2) / 2;
                        double right1 = -1 * (v / (2 * dx)) * ((solution[t][x + 2] - solution[t][x + 1]) / dx - (solution[t][x] - solution[t][space.Count - 1]) / dx);
                        tflux.Add(left1 + right1);

                    }
                    else if (x < space.Count - 2)
                    {
                        left = Math.Pow((solution[t][x + 1] - solution[t][x]) / 2, 2) / 2;
                        right = -1 * (v / (2 * dx)) * ((solution[t][x + 2] - solution[t][x + 1]) / dx - (solution[t][x] - solution[t][x - 1]) / dx);
                        tflux.Add(left + right);
                    }
                    else if (x == space.Count - 2)
                    {
                        left = Math.Pow((solution[t][x + 1] - solution[t][x]) / 2, 2) / 2;
                        right = -1 * (v / (2 * dx)) * ((solution[t][0] - solution[t][x + 1]) / dx - (solution[t][x] - solution[t][x - 1]) / dx);
                        tflux.Add(left + right);
                    }
                    else
                    {
                        left = Math.Pow((solution[t][0] - solution[t][x]) / 2, 2) / 2;
                        right = -1 * (v / (2 * dx)) * ((solution[t][1] - solution[t][0]) / dx - (solution[t][x] - solution[t][x - 1]) / dx);
                        tflux.Add(left + right);
                    }
                    if(t == 0 && space[x] < -0.9)
                    {
                        Debug.WriteLine(left.ToString());
                        Debug.WriteLine(right.ToString());
                    }
                }
                
                flux.Add(tflux);
            }
        }
        public void SolveLF(double v)
        {

        }
        public void SolveKT()
        {

        }
    }
}
