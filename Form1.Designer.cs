
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.SessileDropPage = new System.Windows.Forms.TabPage();
            this.PlotButton = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DimlessVol = new System.Windows.Forms.TextBox();
            this.Bnd = new System.Windows.Forms.TextBox();
            this.CA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InitalizeButton = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.StepBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BondBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactAngleBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SolveButton = new MaterialSkin.Controls.MaterialButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Results = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.label8 = new System.Windows.Forms.Label();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.plateflow = new System.Windows.Forms.TabPage();
            this.Tabs.SuspendLayout();
            this.SettingPage.SuspendLayout();
            this.SessileDropPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.SettingPage);
            this.Tabs.Controls.Add(this.SessileDropPage);
            this.Tabs.Controls.Add(this.Results);
            this.Tabs.Controls.Add(this.plateflow);
            this.Tabs.Depth = 0;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.ImageList = this.imageList1;
            this.Tabs.Location = new System.Drawing.Point(4, 79);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1934, 1019);
            this.Tabs.TabIndex = 0;
            // 
            // SettingPage
            // 
            this.SettingPage.BackColor = System.Drawing.Color.DimGray;
            this.SettingPage.Controls.Add(this.materialSlider1);
            this.SettingPage.ImageKey = "SettingsIcon.png";
            this.SettingPage.Location = new System.Drawing.Point(4, 39);
            this.SettingPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Size = new System.Drawing.Size(1926, 976);
            this.SettingPage.TabIndex = 1;
            this.SettingPage.Text = "Settings";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(4, 4);
            this.materialSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 1000000;
            this.materialSlider1.Size = new System.Drawing.Size(333, 40);
            this.materialSlider1.TabIndex = 0;
            this.materialSlider1.Text = "Iteration Limit";
            this.materialSlider1.Value = 50000;
            // 
            // SessileDropPage
            // 
            this.SessileDropPage.BackColor = System.Drawing.Color.DimGray;
            this.SessileDropPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SessileDropPage.Controls.Add(this.PlotButton);
            this.SessileDropPage.Controls.Add(this.label7);
            this.SessileDropPage.Controls.Add(this.label6);
            this.SessileDropPage.Controls.Add(this.label5);
            this.SessileDropPage.Controls.Add(this.DimlessVol);
            this.SessileDropPage.Controls.Add(this.Bnd);
            this.SessileDropPage.Controls.Add(this.CA);
            this.SessileDropPage.Controls.Add(this.label4);
            this.SessileDropPage.Controls.Add(this.InitalizeButton);
            this.SessileDropPage.Controls.Add(this.label3);
            this.SessileDropPage.Controls.Add(this.StepBox);
            this.SessileDropPage.Controls.Add(this.label2);
            this.SessileDropPage.Controls.Add(this.BondBox);
            this.SessileDropPage.Controls.Add(this.label1);
            this.SessileDropPage.Controls.Add(this.ContactAngleBox);
            this.SessileDropPage.Controls.Add(this.SolveButton);
            this.SessileDropPage.Controls.Add(this.chart1);
            this.SessileDropPage.ImageKey = "sessileDrop.png";
            this.SessileDropPage.Location = new System.Drawing.Point(4, 39);
            this.SessileDropPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SessileDropPage.Name = "SessileDropPage";
            this.SessileDropPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SessileDropPage.Size = new System.Drawing.Size(1926, 976);
            this.SessileDropPage.TabIndex = 0;
            this.SessileDropPage.Text = "Sessile Drop";
            // 
            // PlotButton
            // 
            this.PlotButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlotButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PlotButton.Depth = 0;
            this.PlotButton.HighEmphasis = true;
            this.PlotButton.Icon = null;
            this.PlotButton.Location = new System.Drawing.Point(907, 782);
            this.PlotButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.PlotButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PlotButton.Size = new System.Drawing.Size(115, 36);
            this.PlotButton.TabIndex = 18;
            this.PlotButton.Text = "Save Values";
            this.PlotButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PlotButton.UseAccentColor = false;
            this.PlotButton.UseVisualStyleBackColor = true;
            this.PlotButton.Visible = false;
            this.PlotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 773);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bond Number:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 773);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact Angle:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 831);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dimensonless Volume:";
            this.label5.Visible = false;
            // 
            // DimlessVol
            // 
            this.DimlessVol.Location = new System.Drawing.Point(169, 850);
            this.DimlessVol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DimlessVol.Name = "DimlessVol";
            this.DimlessVol.ReadOnly = true;
            this.DimlessVol.Size = new System.Drawing.Size(324, 22);
            this.DimlessVol.TabIndex = 12;
            this.DimlessVol.Visible = false;
            // 
            // Bnd
            // 
            this.Bnd.Location = new System.Drawing.Point(581, 793);
            this.Bnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bnd.Name = "Bnd";
            this.Bnd.ReadOnly = true;
            this.Bnd.Size = new System.Drawing.Size(217, 22);
            this.Bnd.TabIndex = 11;
            this.Bnd.Visible = false;
            // 
            // CA
            // 
            this.CA.Location = new System.Drawing.Point(169, 793);
            this.CA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CA.Name = "CA";
            this.CA.ReadOnly = true;
            this.CA.Size = new System.Drawing.Size(324, 22);
            this.CA.TabIndex = 10;
            this.CA.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Error: Itteration Limit Reached";
            this.label4.Visible = false;
            // 
            // InitalizeButton
            // 
            this.InitalizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InitalizeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.InitalizeButton.Depth = 0;
            this.InitalizeButton.HighEmphasis = true;
            this.InitalizeButton.Icon = null;
            this.InitalizeButton.Location = new System.Drawing.Point(217, 170);
            this.InitalizeButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.InitalizeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InitalizeButton.Name = "InitalizeButton";
            this.InitalizeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.InitalizeButton.Size = new System.Drawing.Size(88, 36);
            this.InitalizeButton.TabIndex = 6;
            this.InitalizeButton.Text = "Initalize";
            this.InitalizeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.InitalizeButton.UseAccentColor = false;
            this.InitalizeButton.UseVisualStyleBackColor = true;
            this.InitalizeButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "S-Step";
            // 
            // StepBox
            // 
            this.StepBox.AnimateReadOnly = false;
            this.StepBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StepBox.Depth = 0;
            this.StepBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StepBox.LeadingIcon = null;
            this.StepBox.Location = new System.Drawing.Point(400, 39);
            this.StepBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StepBox.MaxLength = 50;
            this.StepBox.MouseState = MaterialSkin.MouseState.OUT;
            this.StepBox.Multiline = false;
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(133, 50);
            this.StepBox.TabIndex = 4;
            this.StepBox.Text = "";
            this.StepBox.TrailingIcon = null;
            this.StepBox.TextChanged += new System.EventHandler(this.StepBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bond Number";
            // 
            // BondBox
            // 
            this.BondBox.AnimateReadOnly = false;
            this.BondBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BondBox.Depth = 0;
            this.BondBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BondBox.LeadingIcon = null;
            this.BondBox.Location = new System.Drawing.Point(217, 39);
            this.BondBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BondBox.MaxLength = 50;
            this.BondBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BondBox.Multiline = false;
            this.BondBox.Name = "BondBox";
            this.BondBox.Size = new System.Drawing.Size(133, 50);
            this.BondBox.TabIndex = 2;
            this.BondBox.Text = "";
            this.BondBox.TrailingIcon = null;
            this.BondBox.TextChanged += new System.EventHandler(this.BondBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Angle";
            // 
            // ContactAngleBox
            // 
            this.ContactAngleBox.AnimateReadOnly = false;
            this.ContactAngleBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.ContactAngleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactAngleBox.Depth = 0;
            this.ContactAngleBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContactAngleBox.LeadingIcon = null;
            this.ContactAngleBox.LeaveOnEnterKey = true;
            this.ContactAngleBox.Location = new System.Drawing.Point(29, 39);
            this.ContactAngleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactAngleBox.MaxLength = 50;
            this.ContactAngleBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ContactAngleBox.Multiline = false;
            this.ContactAngleBox.Name = "ContactAngleBox";
            this.ContactAngleBox.Size = new System.Drawing.Size(133, 50);
            this.ContactAngleBox.TabIndex = 0;
            this.ContactAngleBox.Text = "";
            this.ContactAngleBox.TrailingIcon = null;
            this.ContactAngleBox.TextChanged += new System.EventHandler(this.ContactAngleBox_TextChanged);
            // 
            // SolveButton
            // 
            this.SolveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SolveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SolveButton.Depth = 0;
            this.SolveButton.HighEmphasis = true;
            this.SolveButton.Icon = null;
            this.SolveButton.Location = new System.Drawing.Point(169, 170);
            this.SolveButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.SolveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SolveButton.Size = new System.Drawing.Size(66, 36);
            this.SolveButton.TabIndex = 8;
            this.SolveButton.Text = "Solve";
            this.SolveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SolveButton.UseAccentColor = false;
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Visible = false;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, -20);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Surface";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SessileShape";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Lines";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1305, 752);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.DimGray;
            this.Results.Controls.Add(this.label10);
            this.Results.Controls.Add(this.label9);
            this.Results.Controls.Add(this.materialTextBox3);
            this.Results.Controls.Add(this.materialTextBox2);
            this.Results.Controls.Add(this.materialButton2);
            this.Results.Controls.Add(this.label8);
            this.Results.Controls.Add(this.materialTextBox1);
            this.Results.Controls.Add(this.materialButton1);
            this.Results.Controls.Add(this.materialComboBox1);
            this.Results.Controls.Add(this.chart2);
            this.Results.ImageKey = "ResultsIcon.png";
            this.Results.Location = new System.Drawing.Point(4, 39);
            this.Results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(1926, 976);
            this.Results.TabIndex = 2;
            this.Results.Text = "Sessile Results";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 665);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Real Volume (mm^3)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(819, 514);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Angle";
            this.label9.Visible = false;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(773, 534);
            this.materialTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(133, 50);
            this.materialTextBox3.TabIndex = 8;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            this.materialTextBox3.Visible = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(596, 684);
            this.materialTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(311, 50);
            this.materialTextBox2.TabIndex = 7;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.Visible = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(676, 613);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(116, 36);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "Find Volume";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Visible = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(635, 514);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "R0 (mm)";
            this.label8.Visible = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(596, 534);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(133, 50);
            this.materialTextBox1.TabIndex = 4;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1187, 524);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(112, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "CreatePlot";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Sessile Drop"});
            this.materialComboBox1.Location = new System.Drawing.Point(61, 524);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(427, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 2;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(20, 15);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Angle Vs Vstar";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(1377, 474);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.DimGray;
            this.imageList1.Images.SetKeyName(0, "sessileDrop.png");
            this.imageList1.Images.SetKeyName(1, "SettingsIcon.png");
            this.imageList1.Images.SetKeyName(2, "ResultsIcon.png");
            // 
            // plateflow
            // 
            this.plateflow.Location = new System.Drawing.Point(4, 39);
            this.plateflow.Name = "plateflow";
            this.plateflow.Size = new System.Drawing.Size(1926, 976);
            this.plateflow.TabIndex = 3;
            this.plateflow.Text = "Plate Flow";
            this.plateflow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.Tabs);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.Tabs;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DripSolve";
            this.Tabs.ResumeLayout(false);
            this.SettingPage.ResumeLayout(false);
            this.SessileDropPage.ResumeLayout(false);
            this.SessileDropPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Results.ResumeLayout(false);
            this.Results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private MaterialSkin.Controls.MaterialTabControl Tabs;
        private System.Windows.Forms.TabPage SessileDropPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage SettingPage;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialTextBox ContactAngleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox BondBox;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox StepBox;
        private MaterialSkin.Controls.MaterialButton InitalizeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialButton SolveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Bnd;
        private System.Windows.Forms.TextBox CA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DimlessVol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton PlotButton;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage plateflow;
    }
}

