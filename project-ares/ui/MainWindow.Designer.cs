
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
            this.loadInformationButton = new System.Windows.Forms.Button();
            this.filterDataConfirmButton = new System.Windows.Forms.Button();
            this.generateChartsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.categoricComboBox = new System.Windows.Forms.ComboBox();
            this.fieldsComboBox = new System.Windows.Forms.ComboBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.numberMinTextBox = new System.Windows.Forms.TextBox();
            this.numberMaxTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(460, 12);
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
            this.gMapControl1.Size = new System.Drawing.Size(884, 660);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 10D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // loadInformationButton
            // 
            this.loadInformationButton.Location = new System.Drawing.Point(3, 226);
            this.loadInformationButton.Name = "loadInformationButton";
            this.loadInformationButton.Size = new System.Drawing.Size(121, 23);
            this.loadInformationButton.TabIndex = 1;
            this.loadInformationButton.Text = "Load information";
            this.loadInformationButton.UseVisualStyleBackColor = true;
            this.loadInformationButton.Click += new System.EventHandler(this.loadInformationButton_Click);
            // 
            // filterDataConfirmButton
            // 
            this.filterDataConfirmButton.Location = new System.Drawing.Point(48, 177);
            this.filterDataConfirmButton.Name = "filterDataConfirmButton";
            this.filterDataConfirmButton.Size = new System.Drawing.Size(76, 23);
            this.filterDataConfirmButton.TabIndex = 2;
            this.filterDataConfirmButton.Text = "Filter data";
            this.filterDataConfirmButton.UseVisualStyleBackColor = true;
            this.filterDataConfirmButton.Click += new System.EventHandler(this.filterDataConfirmButton_Click);
            // 
            // generateChartsButton
            // 
            this.generateChartsButton.Location = new System.Drawing.Point(153, 226);
            this.generateChartsButton.Name = "generateChartsButton";
            this.generateChartsButton.Size = new System.Drawing.Size(121, 23);
            this.generateChartsButton.TabIndex = 3;
            this.generateChartsButton.Text = "Generate charts";
            this.generateChartsButton.UseVisualStyleBackColor = true;
            this.generateChartsButton.Click += new System.EventHandler(this.generateChartsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(442, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 402);
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
            this.categoricComboBox.Location = new System.Drawing.Point(131, 48);
            this.categoricComboBox.Name = "categoricComboBox";
            this.categoricComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoricComboBox.TabIndex = 11;
            // 
            // fieldsComboBox
            // 
            this.fieldsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldsComboBox.FormattingEnabled = true;
            this.fieldsComboBox.Location = new System.Drawing.Point(131, 20);
            this.fieldsComboBox.Name = "fieldsComboBox";
            this.fieldsComboBox.Size = new System.Drawing.Size(121, 21);
            this.fieldsComboBox.TabIndex = 14;
            this.fieldsComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldsComboBox_SelectedValueChanged);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(131, 78);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(121, 20);
            this.stringTextBox.TabIndex = 15;
            // 
            // numberMinTextBox
            // 
            this.numberMinTextBox.Location = new System.Drawing.Point(65, 127);
            this.numberMinTextBox.Name = "numberMinTextBox";
            this.numberMinTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberMinTextBox.TabIndex = 16;
            // 
            // numberMaxTextBox
            // 
            this.numberMaxTextBox.Location = new System.Drawing.Point(176, 127);
            this.numberMaxTextBox.Name = "numberMaxTextBox";
            this.numberMaxTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberMaxTextBox.TabIndex = 18;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(153, 177);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 23);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset Table";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loadInformationButton);
            this.panel1.Controls.Add(this.generateChartsButton);
            this.panel1.Controls.Add(this.fieldsComboBox);
            this.panel1.Controls.Add(this.stringTextBox);
            this.panel1.Controls.Add(this.categoricComboBox);
            this.panel1.Controls.Add(this.numberMaxTextBox);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.numberMinTextBox);
            this.panel1.Controls.Add(this.filterDataConfirmButton);
            this.panel1.Location = new System.Drawing.Point(12, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 252);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "String fields filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Letter picker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filtering Criteria";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gMapControl1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Ares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button loadInformationButton;
        private System.Windows.Forms.Button filterDataConfirmButton;
        private System.Windows.Forms.Button generateChartsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox categoricComboBox;
        private System.Windows.Forms.ComboBox fieldsComboBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.TextBox numberMinTextBox;
        private System.Windows.Forms.TextBox numberMaxTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

