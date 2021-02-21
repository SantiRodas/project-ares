
namespace project_ares.ui
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoricComboBox = new System.Windows.Forms.ComboBox();
            this.fieldsComboBox = new System.Windows.Forms.ComboBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.numberMinTextBox = new System.Windows.Forms.TextBox();
            this.numberMaxTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 1;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(839, 625);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 10D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1052, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Filter data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1094, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate charts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(981, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Draw search area";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(866, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(866, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 432);
            this.dataGridView1.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // categoricComboBox
            // 
            this.categoricComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoricComboBox.FormattingEnabled = true;
            this.categoricComboBox.Location = new System.Drawing.Point(1073, 37);
            this.categoricComboBox.Name = "categoricComboBox";
            this.categoricComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoricComboBox.TabIndex = 11;
            // 
            // fieldsComboBox
            // 
            this.fieldsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldsComboBox.FormattingEnabled = true;
            this.fieldsComboBox.Location = new System.Drawing.Point(1073, 10);
            this.fieldsComboBox.Name = "fieldsComboBox";
            this.fieldsComboBox.Size = new System.Drawing.Size(121, 21);
            this.fieldsComboBox.TabIndex = 14;
            this.fieldsComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldsComboBox_SelectedValueChanged);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(1084, 64);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(100, 20);
            this.stringTextBox.TabIndex = 15;
            // 
            // numberMinTextBox
            // 
            this.numberMinTextBox.Location = new System.Drawing.Point(1050, 90);
            this.numberMinTextBox.Name = "numberMinTextBox";
            this.numberMinTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberMinTextBox.TabIndex = 16;
            // 
            // numberMaxTextBox
            // 
            this.numberMaxTextBox.Location = new System.Drawing.Point(1132, 90);
            this.numberMaxTextBox.Name = "numberMaxTextBox";
            this.numberMaxTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberMaxTextBox.TabIndex = 18;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1132, 113);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset Table";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 649);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.numberMaxTextBox);
            this.Controls.Add(this.numberMinTextBox);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.fieldsComboBox);
            this.Controls.Add(this.categoricComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Ares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox categoricComboBox;
        private System.Windows.Forms.ComboBox fieldsComboBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.TextBox numberMinTextBox;
        private System.Windows.Forms.TextBox numberMaxTextBox;
        private System.Windows.Forms.Button resetButton;
    }
}

