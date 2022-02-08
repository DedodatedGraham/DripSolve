
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.SessileDropPage = new System.Windows.Forms.TabPage();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.SettingPage.SuspendLayout();
            this.SessileDropPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.SettingPage);
            this.Tabs.Controls.Add(this.SessileDropPage);
            this.Tabs.Depth = 0;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.ImageList = this.imageList1;
            this.Tabs.Location = new System.Drawing.Point(3, 64);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1934, 1013);
            this.Tabs.TabIndex = 0;
            // 
            // SettingPage
            // 
            this.SettingPage.BackColor = System.Drawing.Color.DimGray;
            this.SettingPage.Controls.Add(this.materialSlider1);
            this.SettingPage.ImageKey = "SettingsIcon.png";
            this.SettingPage.Location = new System.Drawing.Point(4, 39);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Size = new System.Drawing.Size(1926, 970);
            this.SettingPage.TabIndex = 1;
            this.SettingPage.Text = "Settings";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(3, 3);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 1000000;
            this.materialSlider1.Size = new System.Drawing.Size(250, 40);
            this.materialSlider1.TabIndex = 0;
            this.materialSlider1.Text = "Iteration Limit";
            this.materialSlider1.Value = 50000;
            // 
            // SessileDropPage
            // 
            this.SessileDropPage.BackColor = System.Drawing.Color.DimGray;
            this.SessileDropPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.SessileDropPage.Name = "SessileDropPage";
            this.SessileDropPage.Padding = new System.Windows.Forms.Padding(3);
            this.SessileDropPage.Size = new System.Drawing.Size(1926, 970);
            this.SessileDropPage.TabIndex = 0;
            this.SessileDropPage.Text = "Sessile Drop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dimensonless Volume:";
            this.label5.Visible = false;
            // 
            // DimlessVol
            // 
            this.DimlessVol.Location = new System.Drawing.Point(127, 691);
            this.DimlessVol.Name = "DimlessVol";
            this.DimlessVol.Size = new System.Drawing.Size(244, 20);
            this.DimlessVol.TabIndex = 12;
            this.DimlessVol.Visible = false;
            // 
            // Bnd
            // 
            this.Bnd.Location = new System.Drawing.Point(436, 644);
            this.Bnd.Name = "Bnd";
            this.Bnd.Size = new System.Drawing.Size(164, 20);
            this.Bnd.TabIndex = 11;
            this.Bnd.Visible = false;
            // 
            // CA
            // 
            this.CA.Location = new System.Drawing.Point(127, 644);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(244, 20);
            this.CA.TabIndex = 10;
            this.CA.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
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
            this.InitalizeButton.Location = new System.Drawing.Point(163, 138);
            this.InitalizeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.label3.Location = new System.Drawing.Point(332, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
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
            this.StepBox.Location = new System.Drawing.Point(300, 32);
            this.StepBox.MaxLength = 50;
            this.StepBox.MouseState = MaterialSkin.MouseState.OUT;
            this.StepBox.Multiline = false;
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(100, 50);
            this.StepBox.TabIndex = 4;
            this.StepBox.Text = "";
            this.StepBox.TrailingIcon = null;
            this.StepBox.TextChanged += new System.EventHandler(this.StepBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
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
            this.BondBox.Location = new System.Drawing.Point(163, 32);
            this.BondBox.MaxLength = 50;
            this.BondBox.MouseState = MaterialSkin.MouseState.OUT;
            this.BondBox.Multiline = false;
            this.BondBox.Name = "BondBox";
            this.BondBox.Size = new System.Drawing.Size(100, 50);
            this.BondBox.TabIndex = 2;
            this.BondBox.Text = "";
            this.BondBox.TrailingIcon = null;
            this.BondBox.TextChanged += new System.EventHandler(this.BondBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
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
            this.ContactAngleBox.Location = new System.Drawing.Point(22, 32);
            this.ContactAngleBox.MaxLength = 50;
            this.ContactAngleBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ContactAngleBox.Multiline = false;
            this.ContactAngleBox.Name = "ContactAngleBox";
            this.ContactAngleBox.Size = new System.Drawing.Size(100, 50);
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
            this.SolveButton.Location = new System.Drawing.Point(127, 138);
            this.SolveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.chart1.Location = new System.Drawing.Point(2, -1);
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
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(979, 611);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sessileDrop.png");
            this.imageList1.Images.SetKeyName(1, "SettingsIcon.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact Angle:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bond Number:";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1080);
            this.Controls.Add(this.Tabs);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.Tabs;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DripSolve";
            this.Tabs.ResumeLayout(false);
            this.SettingPage.ResumeLayout(false);
            this.SessileDropPage.ResumeLayout(false);
            this.SessileDropPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
    }
}

