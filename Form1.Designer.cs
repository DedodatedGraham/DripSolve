
namespace DripSolve
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series Shape = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SolveButton = new System.Windows.Forms.Button();
            this.sessiledropButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(421, 63);
            this.chart1.Name = "chart1";
            Shape.ChartArea = "ChartArea1";
            Shape.Legend = "Legend1";
            Shape.Name = "Shape";
            this.chart1.Series.Add(Shape);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(77, 295);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(182, 125);
            this.SolveButton.TabIndex = 1;
            this.SolveButton.Text = "SolveButton";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            this.SolveButton.Visible = false;
            // 
            // sessiledropButton
            // 
            this.sessiledropButton.Location = new System.Drawing.Point(338, 369);
            this.sessiledropButton.Name = "sessiledropButton";
            this.sessiledropButton.Size = new System.Drawing.Size(145, 33);
            this.sessiledropButton.TabIndex = 2;
            this.sessiledropButton.Text = "sessiledropButton";
            this.sessiledropButton.UseVisualStyleBackColor = true;
            this.sessiledropButton.Click += new System.EventHandler(this.sessiledropButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sessiledropButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SolveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button sessiledropButton;
    }
}

