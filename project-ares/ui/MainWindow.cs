using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_ares.model;
using System.Collections;
using System.Globalization;

namespace project_ares.ui
{
    public partial class MainWindow : Form
    {
        
        // ------------------------------------------------------------------------------

        // Attributes of the system

        private DataTable dt;
        private DataSetManager dsM;
        GMapOverlay markers = new GMapOverlay("markers"); 
        GMapOverlay polygons = new GMapOverlay("polygons");

        // ------------------------------------------------------------------------------

        // Constructor method of the Form1

        public MainWindow()
        {
            InitializeComponent();

            button2.Enabled = false;
            button3.Enabled = false;

            dt = new DataTable();

        }

        // ------------------------------------------------------------------------------

        // Click method of the Button1

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            dsM = new DataSetManager();
            dsM.Load(openFileDialog1.FileName);

            ArrayList[] data = dsM.Data;

            dt.Columns.Add((string)data[0][0], typeof(string));
            dt.Columns.Add((string)data[1][0], typeof(string));
            dt.Columns.Add((string)data[2][0], typeof(string));
            dt.Columns.Add((string)data[3][0], typeof(double));
            dt.Columns.Add((string)data[4][0], typeof(double));

            

            for (int i = 1; i < data[0].Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr[(string)data[0][0]] = (string)data[0][i];
                dr[(string)data[1][0]] = (string)data[1][i];
                dr[(string)data[2][0]] = (string)data[2][i];
                dr[(string)data[3][0]] = (double)data[3][i];
                dr[(string)data[4][0]] = (double)data[4][i];

                dt.Rows.Add(dr);
            }
            
            dataGridView1.DataSource = dt;

            button2.Enabled = true;

            button3.Enabled = true;

        }

        // ------------------------------------------------------------------------------

        // Load all the information of the GMap system.

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMapControl1.Position = new PointLatLng(30, 70);

            gMapControl1.Overlays.Add(markers);
            gMapControl1.Overlays.Add(polygons);

        }

        // ------------------------------------------------------------------------------

    }
}
