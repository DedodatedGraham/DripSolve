using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DripSolve
{
    public partial class Form1 : MaterialForm
    {
        #region Sessile Drop Place Holders
        public SessileDrop testcase;
        public double Bond;
        public double ContactAngle;
        public double Step;
        public double dlessvol;
        public List<double> dimvolumes;
        public List<double> contactAngles;
        public List<double> bonds;

        #endregion

        #region Plateflow Properties
        public int N;
        public PlateFlow RealPlate;
        public PlateFlow testPlate;
        public List<double> PlateError;
        public List<double> E2dy;
        public List<double> E2Error;

        #endregion

        #region Bugers variables
        public Bugers berg { get; set; } 
        #endregion
        public List<List<double>> plots;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Indigo100, TextShade.WHITE);

            dimvolumes = new List<double>();
            contactAngles = new List<double>();
            bonds = new List<double>();

            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;

            chart1.ChartAreas[0].AxisX.Minimum = -1.0;
            chart1.ChartAreas[0].AxisX.Maximum =  1.0;

            chart5.ChartAreas[0].AxisY.Maximum = 10;
            chart5.ChartAreas[0].AxisY.Minimum = -10;
            chart5.ChartAreas[0].AxisX.Maximum = 1;
            chart5.ChartAreas[0].AxisX.Minimum = -1;

            E2dy = new List<double>();
            E2Error = new List<double>();
        }
        private void ContactAngleBox_TextChanged(object sender, EventArgs e)
        {
            if (!(ContactAngleBox.Text is null) && ContactAngleBox.Text.Length != 0)
            {
                ContactAngle = double.Parse(ContactAngleBox.Text);
            }
        }
        private void BondBox_TextChanged(object sender, EventArgs e)
        {
            if (!(BondBox.Text is null) && BondBox.Text.Length != 0)
            {

                Bond = double.Parse(BondBox.Text);
            }
        }



        private void StepBox_TextChanged(object sender, EventArgs e)
        {
            if (!(StepBox.Text is null) && StepBox.Text.Length != 0)
            {
                Step = double.Parse(StepBox.Text);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            testcase = new SessileDrop(ContactAngle, Bond, Step, materialSlider1.Value);
            ContactAngleBox.Visible = false;
            BondBox.Visible = false;
            StepBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            InitalizeButton.Visible = false;
            SolveButton.Visible = true;
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            bool pass = testcase.Solve();
            SolveButton.Visible = false;

            if (pass)
            {
                double low = -testcase.z[testcase.z.Count - 1];
                DataTable dt = new DataTable();
                dt.Columns.Add("X", typeof(double));
                dt.Columns.Add("Z", typeof(double));
                dt.Columns.Add("surfaceZ", typeof(double));
                for (int i = 0; i < testcase.x.Count; i++)
                {
                    dt.Rows.Add(-testcase.x[testcase.x.Count - 1 - i], -testcase.z[testcase.z.Count - 1 - i], low);

                    //left side
                }
                for (int i = 0; i < testcase.x.Count; i++)
                {
                    //right side
                    dt.Rows.Add(testcase.x[i], -testcase.z[i], low);
                }

                chart1.DataSource = dt;
                chart1.Series["SessileShape"].XValueMember = "X";
                chart1.Series["SessileShape"].YValueMembers = "Z";
                
                chart1.Series["SessileShape"].ChartType = SeriesChartType.Line;
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";


                chart1.Series["Surface"].XValueMember = "X";
                chart1.Series["Surface"].YValueMembers = "surfaceZ";
                chart1.Series["Surface"].ChartType = SeriesChartType.Line;

                chart1.ChartAreas[0].AxisY.Maximum = 0.1;
                chart1.ChartAreas[0].AxisY.Minimum =Math.Floor(low * 10) / 10;

                chart1.Visible = true;
                Bnd.Visible = true;
                CA.Visible = true;
                DimlessVol.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label5.Visible = true;

                Bnd.Text =testcase.bond.ToString() ;
                CA.Text = (testcase.alpha * (180/Math.PI)).ToString();
                dlessvol = testcase.getDimlessVolume();
                DimlessVol.Text = dlessvol.ToString();

                
                    
                    PlotButton.Visible = true;
                



            }
            else
            {
                label4.Visible = true;
            }



            
            

        }

        private void PlotButton_Click(object sender, EventArgs e)
        {
            //this saves the dimensionless volume and angles for interpolation
            dimvolumes.Add(dlessvol);
            contactAngles.Add(testcase.alpha * (180 / Math.PI));
            bonds.Add(testcase.bond);

            
            
            chart1.Visible = false;
            Bnd.Visible = false;
            CA.Visible = false;
            DimlessVol.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            
            BondBox.Visible = true;
            StepBox.Visible = true;
            ContactAngleBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            InitalizeButton.Visible = true;
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            //decides what to do based on index of the combo box
            if (materialComboBox1.SelectedIndex == 0 && dimvolumes.Count !=0)
            {
                //first we will create the plot of the needed values ordered and with out repeating.
                plots = orderSessile(dimvolumes, contactAngles);


                DataTable tempData = new DataTable();
                tempData.MinimumCapacity = plots[0].Count;

                tempData.Columns.Add("X");//angles
                tempData.Columns.Add("Y");//volume

                for(int j = 0; j < plots[0].Count; j++)
                {
                    tempData.Rows.Add(plots[0][j],plots[1][j]);
                }

                chart2.DataSource = tempData;
                chart2.Series["Angle Vs Vstar"].XValueMember = "X";
                chart2.Series["Angle Vs Vstar"].YValueMembers = "Y";

                chart2.Series["Angle Vs Vstar"].ChartType = SeriesChartType.Line;
                chart2.ChartAreas[0].AxisY.LabelStyle.Format = "";


                //if sessile drop is selected then it will do this
                //when plotting 


                materialTextBox1.Visible = true;
                label8.Visible = true;
                materialTextBox3.Visible = true;
                label9.Visible = true;
                materialButton2.Visible = true;
            }


        }


        private List<List<double>> orderSessile(List<double> vstar, List<double> ca)
        {
            List<List<double>> temp = Sort(ca,vstar);
            return temp;
        }

        private List<List<double>> Sort(List<double> sort,List<double> alt)
        {
            List<double> t1 = new List<double>();
            List<double> t2 = new List<double>();

            t1 = sort.Distinct().ToList();
            for(int i = 0; i < t1.Count;i++)
            {
                double temp = 0;
                int indx = 0;
                for(int j = 0; j < sort.Count; j++)
                {
                    if(sort[j] == t1[i])
                    {
                        temp = temp + alt[j];
                        indx++;
                    }
                }

                t2.Add(temp / indx);

            }
            //this will give us a distinct array of the average alt and only one of each sort
            //next it will actually sort the list

            for(int i = 0; i < t1.Count - 1; i++)
            {
                double y = t1[i];
                int x = i;
                for(int j = i + 1; j < t1.Count; j++)
                {
                    if(y > t1[j])
                    {
                        y = t1[j];
                        x = j;
                    }
                }
                double temp1 = t1[i];
                t1[i] = t1[x];
                t1[x] = temp1;
                double temp2 = t2[i];
                t2[i] = t2[x];
                t2[x] = temp2;

            }

            List<List<double>> ret = new List<List<double>>();
            ret.Add(t1);
            ret.Add(t2);
            return ret;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //we need to now find the solution of V* for the given angle
            double angle = double.Parse(materialTextBox3.Text);
            double tvstar = 0;
            for(int i = 0; i < plots[1].Count - 1; i++)
            {
                //now we will take the average dimensionless value and turn it into what we want
                if (plots[0][i] <= angle && plots[0][i + 1] >= angle)
                {
                    tvstar = plots[1][i] + (plots[1][i + 1] - plots[1][i]) * ((angle - plots[0][i])/(plots[0][i+1] - plots[0][i])) ;
                    break;
                }
            }


            materialTextBox2.Text = testcase.getDimVolume(tvstar,double.Parse(materialTextBox1.Text)).ToString();
            materialTextBox2.Visible = true;
        }

        private void materialTextBox4_TextChanged(object sender, EventArgs e)
        { 
            if(materialTextBox4.Text != "")
            {
                N = int.Parse(materialTextBox4.Text);
            }
            
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            RealPlate = new PlateFlow();
            if (N != 0)
            {
                switch (PlatePicker.Text)
                {
                    case ("Bisection Method"):
                        testPlate = new PlateFlow(1, N);
                        testPlate.Solve();
                        RealPlate.Solve(testPlate.y);
                        PlateError = RealPlate.getError(testPlate);
                        break;
                    case ("Secant Method"):
                        testPlate = new PlateFlow(2, N);
                        testPlate.Solve();
                        RealPlate.Solve(testPlate.y);
                        PlateError = RealPlate.getError(testPlate);
                        break;
                    case ("Direct Method"):
                        testPlate = new PlateFlow(3, N);
                        testPlate.Solve();
                        RealPlate.Solve(testPlate.y);
                        PlateError = RealPlate.getError(testPlate);
                        break;
                }
                PlatePicker.Visible = false;
                materialButton3.Visible = false;
                materialLabel1.Visible = false;
                materialTextBox4.Visible = false;
                materialButton4.Visible = true;
                materialButton5.Visible = true;

                DataTable dt = new DataTable();
                dt.Columns.Add("SurfaceX", typeof(double));
                dt.Columns.Add("SurfaceYB", typeof(double));
                dt.Columns.Add("SurfaceYT", typeof(double));
                dt.Columns.Add("Ygrid", typeof(double));
                dt.Columns.Add("UExact", typeof(double));
                dt.Columns.Add("UTest", typeof(double));

                double max = RealPlate.solveU.Max();
                double min =
                N = testPlate.y.Count;
                double dxSurface = max / N;
                for (int i = 0; i < N; i++)
                {
                    //adds the surfaces, and exact and real plots into the 
                    dt.Rows.Add(i * dxSurface, 0, 2, testPlate.y[i], RealPlate.solveU[i], testPlate.solveU[i]);
                }
                chart3.DataSource = dt;

                chart3.Series["Top Plate"].XValueMember = "SurfaceX";
                chart3.Series["Top Plate"].YValueMembers = "SurfaceYT";

                chart3.Series["Bottom Plate"].XValueMember = "SurfaceX";
                chart3.Series["Bottom Plate"].YValueMembers = "SurfaceYB";

                chart3.Series["Exact Solution"].XValueMember = "UExact";
                chart3.Series["Exact Solution"].YValueMembers = "Ygrid";

                chart3.Series["Test Solution"].XValueMember = "UTest";
                chart3.Series["Test Solution"].YValueMembers = "Ygrid";

                chart3.Visible = true;

                chart3.ChartAreas[0].AxisY.Maximum = 2.5;
                chart3.ChartAreas[0].AxisY.Minimum = -0.5;
                chart3.ChartAreas[0].AxisX.Maximum = max + 10;
                chart3.ChartAreas[0].AxisX.Minimum = 0;
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            PlatePicker.Visible = true;
            materialButton3.Visible = true;
            materialLabel1.Visible = true;
            materialTextBox4.Visible = true;
            chart3.Visible = false;
            materialTextBox4.Text = "";
            materialButton4.Visible = false;
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            double temp = 0;
            E2dy.Add(testPlate.dy);
            for (int i = 0; i < PlateError.Count; i++)
            {
                temp = temp + (Math.Pow(PlateError[i], 2));
            }
            temp = Math.Sqrt(temp);
            temp = temp / (PlateError.Count - 1);
            E2Error.Add(temp);
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            if(E2Error.Count > 0)
            {
                List<List<double>> sorted = Sort(E2dy,E2Error);
                List<double> tempdy = sorted[0];
                List<double> tempError = sorted[1];
                E2dy = new List<double>();
                E2Error = new List<double>();
                for(int i = 0; i < tempdy.Count; i++)
                {
                    E2dy.Add(Math.Log10(tempdy[i]));
                    E2Error.Add(Math.Log10(tempError[i]));
                }

                


                DataTable dt = new DataTable();
                dt.Columns.Add("Log(dy)",typeof(double));
                dt.Columns.Add("Log(E2)",typeof(double));

                for(int i = 0; i < E2dy.Count; i++)
                {
                    dt.Rows.Add(E2dy[i],E2Error[i]);
                }



                chart4.DataSource = dt;

                chart4.Series["E2 vs dy"].XValueMember = "Log(dy)";
                chart4.Series["E2 vs dy"].YValueMembers = "Log(E2)";

                chart4.Visible = true;




            }
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            //Bugers solve button click
            double dx = double.Parse(materialTextBox5.Text);
            berg = new Bugers(dx);
            berg.Solve(materialComboBox2.SelectedIndex + 1);
            //Next now that it is solved we can display the solution on the results tab
            DataTable dt = new DataTable();
            dt.Columns.Add("X",typeof(double));
            dt.Columns.Add("U-0", typeof(double));
            dt.Columns.Add("U-1", typeof(double));
            dt.Columns.Add("U-2", typeof(double));
            dt.Columns.Add("U-3", typeof(double));
            dt.Columns.Add("U-4", typeof(double));
            dt.Columns.Add("U-5", typeof(double));

            for(int i = 0; i < berg.solution[0].Count; i++)
            {
                dt.Rows.Add(berg.space[i], berg.solution[0][i], berg.solution[1][i], berg.solution[2][i], berg.solution[3][i], berg.solution[4][i], berg.solution[5][i]);
            }

            chart5.DataSource = dt;

            chart5.Series["Series1"].XValueMember = "X";
            chart5.Series["Series1"].YValueMembers = "U-0";

            chart5.Series["Series2"].XValueMember = "X";
            chart5.Series["Series2"].YValueMembers = "U-1";

            chart5.Series["Series3"].XValueMember = "X";
            chart5.Series["Series3"].YValueMembers = "U-2";

            chart5.Series["Series4"].XValueMember = "X";
            chart5.Series["Series4"].YValueMembers = "U-3";

            chart5.Series["Series5"].XValueMember = "X";
            chart5.Series["Series5"].YValueMembers = "U-4";

            chart5.Series["Series6"].XValueMember = "X";
            chart5.Series["Series6"].YValueMembers = "U-5";
            
        }
    }
}
