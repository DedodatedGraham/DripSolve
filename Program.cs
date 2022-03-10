using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DripSolve
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //example solving using shooting
            PlateFlow a1 = new PlateFlow(1, 120);
            a1.Solve();
            //example solving using secant

            PlateFlow a2 = new PlateFlow(2, 120);
            a2.Solve();
            //example solving using direct
            PlateFlow a3 = new PlateFlow(3, 120);
            a3.Solve();


            //the direct method can be used as a direct check for errors when given the y values of the given method  

            PlateFlow b = new PlateFlow();
            b.Solve(a3.y);
            List<double> error = b.getError(a1);
            for(int i = 0; i < error.Count; i++)
            {
                Debug.Print(error[i].ToString());
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
