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
        private DataView dv;
        GMapOverlay markers = new GMapOverlay("markers"); 
        GMapOverlay polygons = new GMapOverlay("polygons");

        // ------------------------------------------------------------------------------

        // Constructor method of the Form1

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 65; i <= 90; i++)
            {

                categoricComboBox.Items.Add((char)i);

            }

            button2.Enabled = false;
            button3.Enabled = false;
            resetButton.Enabled = false;

            fieldsComboBox.Enabled = false;
            categoricComboBox.Enabled = false;
            stringTextBox.Enabled = false;
            numberMinTextBox.Enabled = false;
            numberMaxTextBox.Enabled = false;


            dt = new DataTable();
            dv = new DataView(dt);

        }

        // ------------------------------------------------------------------------------

        // Click method of the Button1, loads table

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            dsM = new DataSetManager();
            dsM.Load(openFileDialog1.FileName);

            ArrayList[] data = dsM.Data;

            dt.Columns.Add((string)data[0][0], typeof(string));
            dt.Columns.Add((string)data[1][0], typeof(string));
            dt.Columns.Add((string)data[2][0], typeof(int));
            dt.Columns.Add((string)data[3][0], typeof(double));
            dt.Columns.Add((string)data[4][0], typeof(double));
               

            for (int i = 1; i < data[0].Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr[(string)data[0][0]] = (string)data[0][i];
                dr[(string)data[1][0]] = (string)data[1][i];
                dr[(string)data[2][0]] = (int)data[2][i];
                dr[(string)data[3][0]] = (double)data[3][i];
                dr[(string)data[4][0]] = (double)data[4][i];

                dt.Rows.Add(dr);
            }
            
            dataGridView1.DataSource = dv;

            button3.Enabled = true;
            resetButton.Enabled = true;
            fieldsComboBox.Enabled = true;

            for(int i = 0 ; i < dt.Columns.Count ; i++)
            {
                fieldsComboBox.Items.Add(dt.Columns[i].ColumnName);
            }

            fieldsComboBox.Items.Add(dt.Columns[0].ColumnName + " (First letter) ");
            fieldsComboBox.Items.Add(dt.Columns[1].ColumnName + " (First letter) ");

            LoadMarkers();
            LoadPolygons();
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

        // Filter data
        
        private void button2_Click(object sender, EventArgs e)
        {        
            
            if (fieldsComboBox.SelectedItem.Equals(dt.Columns[0].ColumnName))
            {
                string name = stringTextBox.Text;
                dv.RowFilter = $"Name LIKE \'%{name}%\'";
            }
            else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[1].ColumnName))
            {
                string lastname = stringTextBox.Text;
                dv.RowFilter = $"Last_Name LIKE \'%{lastname}%\'";
            }
            else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[2].ColumnName))
            {
                try
                {
                    double minHour = Double.Parse(numberMinTextBox.Text, CultureInfo.InvariantCulture);
                    double maxHour = Double.Parse(numberMaxTextBox.Text, CultureInfo.InvariantCulture);

                    dv.RowFilter = $"Time >= {minHour} AND Time <= {maxHour}";
                }
                catch(FormatException)
                {
                    WrongNumberFormatMessageBox();
                }            
                
            }
            else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[3].ColumnName))
            {
                try 
                { 
                    double minLatitude = Double.Parse(numberMinTextBox.Text,CultureInfo.InvariantCulture);
                    double maxLatitude = Double.Parse(numberMaxTextBox.Text,CultureInfo.InvariantCulture);

                    dv.RowFilter = $"Latitude >= {minLatitude} AND Latitude <= {maxLatitude}";
                }
                catch (FormatException)
                {
                    WrongNumberFormatMessageBox();
                }
        }
            else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[4].ColumnName))
            {
                try 
                { 
                    double minLongitude = Double.Parse(numberMinTextBox.Text, CultureInfo.InvariantCulture);
                    double maxLongitude = Double.Parse(numberMaxTextBox.Text, CultureInfo.InvariantCulture);

                    dv.RowFilter = $"Longitude >= {minLongitude} AND Longitude <= {maxLongitude}";
                }
                catch (FormatException)
                {
                    WrongNumberFormatMessageBox();
                }
        }
            else
            {                
                if (((string)fieldsComboBox.SelectedItem).Equals(dt.Columns[0].ColumnName + " (First letter) "))
                {
                    string letter = Char.ToString((char)categoricComboBox.SelectedItem);
                    dv.RowFilter = $"Name LIKE \'{letter}*\'";
                }
                else
                {
                    string letter = Char.ToString((char)categoricComboBox.SelectedItem);
                    dv.RowFilter = $"Last_name LIKE \'{letter}*\'";
                }
            }
            LoadMarkers();
            LoadPolygons();
        }
        
        // ------------------------------------------------------------------------------

        private void fieldsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            categoricComboBox.SelectedValue = "";
            numberMaxTextBox.Text = "";
            numberMinTextBox.Text = "";
            stringTextBox.Text = "";
            if (fieldsComboBox.SelectedItem.Equals(dt.Columns[0].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = false;
                numberMinTextBox.Enabled = false;
                stringTextBox.Enabled = true;
            }
            else if(fieldsComboBox.SelectedItem.Equals(dt.Columns[1].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = false;
                numberMinTextBox.Enabled = false;
                stringTextBox.Enabled = true;
            }
            else if(fieldsComboBox.SelectedItem.Equals(dt.Columns[2].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = true;
                numberMinTextBox.Enabled = true;
                stringTextBox.Enabled = false;
            }
            else if(fieldsComboBox.SelectedItem.Equals(dt.Columns[3].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = true;
                numberMinTextBox.Enabled = true;
                stringTextBox.Enabled = false;
            }
            else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[4].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = true;
                numberMinTextBox.Enabled = true;
                stringTextBox.Enabled = false;
            }
            else
            {
                categoricComboBox.Enabled = true;
                numberMaxTextBox.Enabled = false;
                numberMinTextBox.Enabled = false;
                stringTextBox.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChartWindow secondForm = new ChartWindow(dt);

            secondForm.Show();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "";
        }

        private void WrongNumberFormatMessageBox()
        {
            MessageBox.Show("Error filtering data: Make sure the format is right, the fields are complete, and the maximum value is larger than the minimum"
                ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        // ------------------------------------------------------------------------------

        private void LoadMarkers()
        {
            markers.Clear();
            foreach (DataRow dr in dv.ToTable().Rows)
            {
                PointLatLng point = new PointLatLng((double)dr["Latitude"], (double)dr["Longitude"]);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
                marker.ToolTipText = $"{(string)dr["Name"]}" +
                    $" {(string)dr["Last_name"]} \n" +
                    $"{((int)dr["Time"]).ToString()} \n" +
                    $"{((double)dr["Latitude"]).ToString(CultureInfo.InvariantCulture)}, {((double)dr["Longitude"]).ToString(CultureInfo.InvariantCulture)}";
                markers.Markers.Add(marker);
            }
        }

        private void LoadPolygons()
        {
            polygons.Clear();
            foreach (DataRow dr in dv.ToTable().Rows)
            {
                double centerLat = (double)dr["Latitude"];
                double centerLng = (double)dr["Longitude"];

                //0.005 lat = 500m aprox

                PointLatLng point1 = new PointLatLng(centerLat - 0.01, centerLng + 0.01);
                PointLatLng point2 = new PointLatLng(centerLat - 0.01, centerLng - 0.01);
                PointLatLng point3 = new PointLatLng(centerLat + 0.01, centerLng - 0.01);
                PointLatLng point4 = new PointLatLng(centerLat + 0.01, centerLng + 0.01);

                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(point1);
                points.Add(point2);
                points.Add(point3);
                points.Add(point4);

                GMapPolygon polygon = new GMapPolygon(points, $"{dr["Name"]} {dr["Last_name"]}" );
                polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.OrangeRed));
                polygon.Stroke = new Pen(Color.Red);
                markers.Polygons.Add(polygon);
            }
        }
    }
}
