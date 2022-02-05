using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DripSolve
{
    public class SessileDrop
    {
        //itteration limit to prevent stack overflows / can be changed
        public double iL { get; set; } = 1000000;


        #region inital Conditions
        private static double x0 = 0;
        private static double z0 = 0;
        private static double theta0 = 0;
        private static double s0 = 0;

        //Assigned Variables that are static but given in creation to limit the solver
        private double alpha;
        private double bond;
        private double ds;
        public string type;
        #endregion



        #region tempvars
        private double tempx;
        private double tempz;
        private double temptheta;
        private double temps;
        #endregion

        #region Governing Equations
        public Func<double, double> dxds = delegate (double t)
        {
            //t is theta in radians
            return Math.Cos(t);
        };
        Func<double, double> dzds = delegate (double t)
        {
            //t is theta in radians
            return Math.Sin(t);
        };
        //work on this alittle bit
        Func<List<double>, double> dthetads = delegate (List<double> vars)
        {
            //dtheta/ds = 2 + 
            //vars[0] is Bond number
            //vars[1] is zstar
            //vars[2] is theta in radians
            //vars[3] is xstar
            if (vars[3] != 0)
            {
                return 2 + vars[0] * vars[1] - (Math.Sin(vars[2]) / vars[3]);
            }
            else
            {
                return 2 + vars[0] * vars[1];
            }
        };
        #endregion

        #region DataLists
        public List<double> x { get; set; }
        public List<double> z { get; set; }
        public List<double> theta { get; set; }
        public List<double> s { get; set; }
        #endregion
        public SessileDrop(double ContactAngle, double BondNumber, double Step,double itLimit)
        {
            //Math uses radians, can be converted into deg later for processing
            alpha = ContactAngle * (Math.PI / 180);
            bond = BondNumber;
            ds = Step;
            //initalize lists in case current size needs to be 0 & not null
            x = new List<double>();
            x.Add(x0);
            z = new List<double>();
            z.Add(z0);
            theta = new List<double>();
            theta.Add(theta0);
            s = new List<double>();
            s.Add(s0);
            s.Add(s0 + ds);
            iL = itLimit;
        }


        public void Solve()
        {

            int index = 1;

            //solve loop
            while ((theta[theta.Count - 1] < alpha) && (index <= iL))
            {
                #region TempData
                //used for passing information into dthetads
                List<double> tempList = new List<double>();
                tempList.Add(bond);
                tempList.Add(z[index - 1]);
                tempList.Add(theta[index - 1]);
                tempList.Add(x[index - 1]);

                #endregion

                #region Forward Euler
                if (index == 1)
                {
                    //So here we apply the Foward Euler
                    //essentially T(k) = T(k-1) + ds* ODE(@k-1)
                    //same follows for x and z 
                    theta.Add(theta[index - 1] + ds * dthetads(tempList));
                    x.Add(x[index - 1] + ds * dxds(theta[index - 1]));
                    z.Add(z[index - 1] + ds * dzds(theta[index - 1]));
                }
                #endregion

                #region AB2
                else
                {
                    #region Extra TempData
                    List<double> tempList2 = new List<double>();
                    tempList2.Add(bond);
                    tempList2.Add(z[index - 2]);
                    tempList2.Add(theta[index - 2]);
                    tempList2.Add(x[index - 2]);
                    #endregion
                    //Here the AB2 method will be used for every step past the first 2
                    //Ab follows T(k) = T(k-1) + 3/2 * ds * ODE(@k-1) - 1/2 * ds * ODE(@k-2)
                    theta.Add(theta[index - 1] + (3 / 2) * ds * dthetads(tempList) - (1 / 2) * ds * dthetads(tempList2));
                    x.Add(x[index - 1] + (3 / 2) * ds * dxds(theta[index - 1]) - (1 / 2) * ds * dxds(theta[index - 2]));
                    z.Add(z[index - 1] + (3 / 2) * ds * dzds(theta[index - 1]) - (1 / 2) * ds * dzds(theta[index - 2]));
                }
                #endregion
                s.Add(s[s.Count - 1] + ds);
                index++;

            }


            if (index >= iL)
            {
                Debug.WriteLine("Error: Itteration Limit Reached");
            }



        }




    }

}