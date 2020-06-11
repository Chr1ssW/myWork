namespace NHL_Stenden_Weather
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWind = new System.Windows.Forms.Label();
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.txtUpdate = new System.Windows.Forms.Label();
            this.txtCond = new System.Windows.Forms.Label();
            this.txtHumid = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartTrending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.inputCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intInterval = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrending)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.Settings.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-4, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 338);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(431, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(111, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "NHL Stenden Weather Station";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtWind);
            this.groupBox1.Controls.Add(this.picWeather);
            this.groupBox1.Controls.Add(this.txtUpdate);
            this.groupBox1.Controls.Add(this.txtCond);
            this.groupBox1.Controls.Add(this.txtHumid);
            this.groupBox1.Controls.Add(this.txtTemp);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(11, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(408, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current weather";
            // 
            // txtWind
            // 
            this.txtWind.AutoSize = true;
            this.txtWind.Location = new System.Drawing.Point(16, 148);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(47, 20);
            this.txtWind.TabIndex = 7;
            this.txtWind.Text = "Wind";
            // 
            // picWeather
            // 
            this.picWeather.Location = new System.Drawing.Point(252, 25);
            this.picWeather.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(71, 64);
            this.picWeather.TabIndex = 5;
            this.picWeather.TabStop = false;
            // 
            // txtUpdate
            // 
            this.txtUpdate.AutoSize = true;
            this.txtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUpdate.Location = new System.Drawing.Point(248, 180);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(46, 17);
            this.txtUpdate.TabIndex = 4;
            this.txtUpdate.Text = "label6";
            // 
            // txtCond
            // 
            this.txtCond.AutoSize = true;
            this.txtCond.Location = new System.Drawing.Point(248, 91);
            this.txtCond.Name = "txtCond";
            this.txtCond.Size = new System.Drawing.Size(53, 20);
            this.txtCond.TabIndex = 3;
            this.txtCond.Text = "label5";
            // 
            // txtHumid
            // 
            this.txtHumid.AutoSize = true;
            this.txtHumid.Location = new System.Drawing.Point(16, 122);
            this.txtHumid.Name = "txtHumid";
            this.txtHumid.Size = new System.Drawing.Size(75, 20);
            this.txtHumid.TabIndex = 2;
            this.txtHumid.Text = "Humidity";
            // 
            // txtTemp
            // 
            this.txtTemp.AutoSize = true;
            this.txtTemp.Location = new System.Drawing.Point(16, 89);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(104, 20);
            this.txtTemp.TabIndex = 1;
            this.txtTemp.Text = "Temperature";
            // 
            // txtLocation
            // 
            this.txtLocation.AutoSize = true;
            this.txtLocation.Location = new System.Drawing.Point(16, 34);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(134, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "Current Location";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.chartTrending);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(431, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trending";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartTrending
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrending.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTrending.Legends.Add(legend1);
            this.chartTrending.Location = new System.Drawing.Point(12, 18);
            this.chartTrending.Name = "chartTrending";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.chartTrending.Series.Add(series1);
            this.chartTrending.Size = new System.Drawing.Size(408, 270);
            this.chartTrending.TabIndex = 0;
            this.chartTrending.Text = "chart1";
            title1.Name = "text1";
            title1.Text = "History Data";
            this.chartTrending.Titles.Add(title1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.Settings);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(431, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.radioButton2);
            this.Settings.Controls.Add(this.radioButton1);
            this.Settings.Controls.Add(this.button1);
            this.Settings.Controls.Add(this.txtInterval);
            this.Settings.Controls.Add(this.inputCity);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.label4);
            this.Settings.Controls.Add(this.intInterval);
            this.Settings.Controls.Add(this.txtPlace);
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Settings.Location = new System.Drawing.Point(9, 16);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Size = new System.Drawing.Size(408, 273);
            this.Settings.TabIndex = 0;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 149);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "°C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(117, 149);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(280, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(108, 98);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(75, 27);
            this.txtInterval.TabIndex = 5;
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(108, 47);
            this.inputCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(100, 27);
            this.inputCity.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(189, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "[in sec]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Display";
            // 
            // intInterval
            // 
            this.intInterval.AutoSize = true;
            this.intInterval.Location = new System.Drawing.Point(37, 102);
            this.intInterval.Name = "intInterval";
            this.intInterval.Size = new System.Drawing.Size(63, 20);
            this.intInterval.TabIndex = 1;
            this.intInterval.Text = "Interval";
            // 
            // txtPlace
            // 
            this.txtPlace.AutoSize = true;
            this.txtPlace.Location = new System.Drawing.Point(37, 47);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(51, 20);
            this.txtPlace.TabIndex = 0;
            this.txtPlace.Text = "Place";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Weather Station";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 124);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Clicked);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Clicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Clicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Clicked);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.closeToolStripMenuItem.Text = "Close...";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Clicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 327);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "NHL Stenden Weather Station";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrending)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtWind;
        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label txtUpdate;
        private System.Windows.Forms.Label txtCond;
        private System.Windows.Forms.Label txtHumid;
        private System.Windows.Forms.Label txtTemp;
        private System.Windows.Forms.Label txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label intInterval;
        private System.Windows.Forms.Label txtPlace;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrending;
    }
}