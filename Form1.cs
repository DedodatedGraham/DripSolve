using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #endregion

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Indigo100, TextShade.WHITE);

            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;

            chart1.ChartAreas[0].AxisX.Minimum = -1.0;
            chart1.ChartAreas[0].AxisX.Maximum =  1.0;

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



        private void
            StepBox_TextChanged(object sender, EventArgs e)
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
                DimlessVol.Text = testcase.getDimlessVolume().ToString();
            }
            else
            {
                label4.Visible = true;
            }



        }

    }
}
