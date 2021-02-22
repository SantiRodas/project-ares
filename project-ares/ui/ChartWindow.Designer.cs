
namespace project_ares.ui
{
    partial class ChartWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartWindow));
            this.firstNameLetterChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.filterNameButton = new System.Windows.Forms.Button();
            this.lastnameOption1CB = new System.Windows.Forms.ComboBox();
            this.lastnameOption2CB = new System.Windows.Forms.ComboBox();
            this.lastnameOption3CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterLastnameButton = new System.Windows.Forms.Button();
            this.firstLastnameLetterChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timeFilterChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timeOption1 = new System.Windows.Forms.RadioButton();
            this.timeOption2 = new System.Windows.Forms.RadioButton();
            this.timeOption3 = new System.Windows.Forms.RadioButton();
            this.timeOption4 = new System.Windows.Forms.RadioButton();
            this.filterTimeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameLetterChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLastnameLetterChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeFilterChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLetterChart
            // 
            chartArea4.Name = "ChartArea1";
            this.firstNameLetterChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.firstNameLetterChart.Legends.Add(legend4);
            this.firstNameLetterChart.Location = new System.Drawing.Point(12, 12);
            this.firstNameLetterChart.Name = "firstNameLetterChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.firstNameLetterChart.Series.Add(series4);
            this.firstNameLetterChart.Size = new System.Drawing.Size(437, 301);
            this.firstNameLetterChart.TabIndex = 0;
            this.firstNameLetterChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a letter to filter the name";
            // 
            // nameOptionsComboBox
            // 
            this.nameOptionsComboBox.FormattingEnabled = true;
            this.nameOptionsComboBox.Location = new System.Drawing.Point(472, 144);
            this.nameOptionsComboBox.Name = "nameOptionsComboBox";
            this.nameOptionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameOptionsComboBox.TabIndex = 3;
            // 
            // filterNameButton
            // 
            this.filterNameButton.Location = new System.Drawing.Point(497, 171);
            this.filterNameButton.Name = "filterNameButton";
            this.filterNameButton.Size = new System.Drawing.Size(75, 23);
            this.filterNameButton.TabIndex = 4;
            this.filterNameButton.Text = "Generate";
            this.filterNameButton.UseVisualStyleBackColor = true;
            this.filterNameButton.Click += new System.EventHandler(this.filterNameButton_Click);
            // 
            // lastnameOption1CB
            // 
            this.lastnameOption1CB.FormattingEnabled = true;
            this.lastnameOption1CB.Location = new System.Drawing.Point(480, 447);
            this.lastnameOption1CB.Name = "lastnameOption1CB";
            this.lastnameOption1CB.Size = new System.Drawing.Size(121, 21);
            this.lastnameOption1CB.TabIndex = 6;
            // 
            // lastnameOption2CB
            // 
            this.lastnameOption2CB.FormattingEnabled = true;
            this.lastnameOption2CB.Location = new System.Drawing.Point(480, 474);
            this.lastnameOption2CB.Name = "lastnameOption2CB";
            this.lastnameOption2CB.Size = new System.Drawing.Size(121, 21);
            this.lastnameOption2CB.TabIndex = 7;
            // 
            // lastnameOption3CB
            // 
            this.lastnameOption3CB.FormattingEnabled = true;
            this.lastnameOption3CB.Location = new System.Drawing.Point(480, 501);
            this.lastnameOption3CB.Name = "lastnameOption3CB";
            this.lastnameOption3CB.Size = new System.Drawing.Size(121, 21);
            this.lastnameOption3CB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select a letter to filter the last name";
            // 
            // filterLastnameButton
            // 
            this.filterLastnameButton.Location = new System.Drawing.Point(505, 528);
            this.filterLastnameButton.Name = "filterLastnameButton";
            this.filterLastnameButton.Size = new System.Drawing.Size(75, 23);
            this.filterLastnameButton.TabIndex = 10;
            this.filterLastnameButton.Text = "Generate";
            this.filterLastnameButton.UseVisualStyleBackColor = true;
            this.filterLastnameButton.Click += new System.EventHandler(this.filterLastnameButton_Click);
            // 
            // firstLastnameLetterChart
            // 
            chartArea5.Name = "ChartArea1";
            this.firstLastnameLetterChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.firstLastnameLetterChart.Legends.Add(legend5);
            this.firstLastnameLetterChart.Location = new System.Drawing.Point(12, 336);
            this.firstLastnameLetterChart.Name = "firstLastnameLetterChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            this.firstLastnameLetterChart.Series.Add(series5);
            this.firstLastnameLetterChart.Size = new System.Drawing.Size(437, 301);
            this.firstLastnameLetterChart.TabIndex = 11;
            this.firstLastnameLetterChart.Text = "chart2";
            // 
            // timeFilterChart
            // 
            chartArea6.Name = "ChartArea1";
            this.timeFilterChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.timeFilterChart.Legends.Add(legend6);
            this.timeFilterChart.Location = new System.Drawing.Point(763, 12);
            this.timeFilterChart.Name = "timeFilterChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series3";
            this.timeFilterChart.Series.Add(series6);
            this.timeFilterChart.Size = new System.Drawing.Size(437, 301);
            this.timeFilterChart.TabIndex = 12;
            this.timeFilterChart.Text = "chart3";
            // 
            // timeOption1
            // 
            this.timeOption1.AutoSize = true;
            this.timeOption1.Location = new System.Drawing.Point(856, 353);
            this.timeOption1.Name = "timeOption1";
            this.timeOption1.Size = new System.Drawing.Size(58, 17);
            this.timeOption1.TabIndex = 13;
            this.timeOption1.TabStop = true;
            this.timeOption1.Text = "0 - 559";
            this.timeOption1.UseVisualStyleBackColor = true;
            // 
            // timeOption2
            // 
            this.timeOption2.AutoSize = true;
            this.timeOption2.Location = new System.Drawing.Point(856, 376);
            this.timeOption2.Name = "timeOption2";
            this.timeOption2.Size = new System.Drawing.Size(76, 17);
            this.timeOption2.TabIndex = 14;
            this.timeOption2.TabStop = true;
            this.timeOption2.Text = "600 - 1159";
            this.timeOption2.UseVisualStyleBackColor = true;
            // 
            // timeOption3
            // 
            this.timeOption3.AutoSize = true;
            this.timeOption3.Location = new System.Drawing.Point(856, 399);
            this.timeOption3.Name = "timeOption3";
            this.timeOption3.Size = new System.Drawing.Size(82, 17);
            this.timeOption3.TabIndex = 15;
            this.timeOption3.TabStop = true;
            this.timeOption3.Text = "1200 - 1759";
            this.timeOption3.UseVisualStyleBackColor = true;
            // 
            // timeOption4
            // 
            this.timeOption4.AutoSize = true;
            this.timeOption4.Location = new System.Drawing.Point(856, 422);
            this.timeOption4.Name = "timeOption4";
            this.timeOption4.Size = new System.Drawing.Size(82, 17);
            this.timeOption4.TabIndex = 16;
            this.timeOption4.TabStop = true;
            this.timeOption4.Text = "1800 - 2359";
            this.timeOption4.UseVisualStyleBackColor = true;
            // 
            // filterTimeButton
            // 
            this.filterTimeButton.Location = new System.Drawing.Point(1025, 376);
            this.filterTimeButton.Name = "filterTimeButton";
            this.filterTimeButton.Size = new System.Drawing.Size(75, 23);
            this.filterTimeButton.TabIndex = 17;
            this.filterTimeButton.Text = "Generate";
            this.filterTimeButton.UseVisualStyleBackColor = true;
            this.filterTimeButton.Click += new System.EventHandler(this.filterTimeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(927, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select a item to filter the time";
            // 
            // ChartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filterTimeButton);
            this.Controls.Add(this.timeOption4);
            this.Controls.Add(this.timeOption3);
            this.Controls.Add(this.timeOption2);
            this.Controls.Add(this.timeOption1);
            this.Controls.Add(this.timeFilterChart);
            this.Controls.Add(this.firstLastnameLetterChart);
            this.Controls.Add(this.filterLastnameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnameOption3CB);
            this.Controls.Add(this.lastnameOption2CB);
            this.Controls.Add(this.lastnameOption1CB);
            this.Controls.Add(this.filterNameButton);
            this.Controls.Add(this.nameOptionsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameLetterChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart\'s";
            ((System.ComponentModel.ISupportInitialize)(this.firstNameLetterChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLastnameLetterChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeFilterChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart firstNameLetterChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nameOptionsComboBox;
        private System.Windows.Forms.Button filterNameButton;
        private System.Windows.Forms.ComboBox lastnameOption1CB;
        private System.Windows.Forms.ComboBox lastnameOption2CB;
        private System.Windows.Forms.ComboBox lastnameOption3CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filterLastnameButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart firstLastnameLetterChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeFilterChart;
        private System.Windows.Forms.RadioButton timeOption1;
        private System.Windows.Forms.RadioButton timeOption2;
        private System.Windows.Forms.RadioButton timeOption3;
        private System.Windows.Forms.RadioButton timeOption4;
        private System.Windows.Forms.Button filterTimeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}