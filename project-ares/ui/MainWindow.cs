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

namespace project_ares.ui
{
    public partial class MainWindow : Form
    {
        
        // ------------------------------------------------------------------------------

        // Attributes of the system

        private DataTable dt;

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
            //Cree un objeto de tipo DataSetManager
            //Lea los datos


            openFileDialog1.ShowDialog();

            string content = File.ReadAllText(openFileDialog1.FileName);

            string[] splitContent = content.Split('\n');

            string[] splitLine = splitContent[0].Split(',');

            dt.Columns.Add(splitLine[0]);
            dt.Columns.Add(splitLine[1]);
            dt.Columns.Add(splitLine[2]);
            dt.Columns.Add(splitLine[3]);
            dt.Columns.Add(splitLine[4]);

            for (int i = 1; i < splitContent.Length; i++)
            {
                splitLine = splitContent[i].Split(',');

                dt.Rows.Add(splitLine);
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
