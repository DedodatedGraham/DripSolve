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
    public partial class Form1 : Form
    {
        public SessileDrop testcase;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            testcase = new SessileDrop(70, 1.5, .001);
            testcase.Solve();

           

        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X", typeof(double));
            dt.Columns.Add("Z", typeof(double));
            dt.BeginLoadData();
            for (int i = 0; i < testcase.x.Count; i++)
            {
                dt.Rows.Add(testcase.x[i], -testcase.z[i]);
            }


            chart1.DataSource = dt;
            chart1.Name = "Shape";
            chart1.Series["Shape"].XValueMember = "X";
            chart1.Series["Shape"].YValueMembers = "Z";
            chart1.Series["Shape"].ChartType = SeriesChartType.Line;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";
            SolveButton.Visible = false;
            chart1.Visible = true;
        }

        private void sessiledropButton_Click(object sender, EventArgs e)
        {
            sessiledropButton.Visible = false;
            SolveButton.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void geometryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is where we will input the Initial Values needed to find the Geometry

        }
    }
}
