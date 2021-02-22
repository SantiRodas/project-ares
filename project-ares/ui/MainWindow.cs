using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using project_ares.model;
using System.Collections;
using System.Globalization;

namespace project_ares.ui
{
    public partial class MainWindow : Form
    {

        // ------------------------------------------------------------------------------

        // Attributes of MainWindow

        private DataTable dt;
        private DataSetManager dsM;
        private DataView dv;
        GMapOverlay markers = new GMapOverlay("markers");
        GMapOverlay polygons = new GMapOverlay("polygons");

        // ------------------------------------------------------------------------------

        // Constructor method of the MainWindow

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 65; i <= 90; i++)
            {
                categoricComboBox.Items.Add((char)i);
            }

            filterDataConfirmButton.Enabled = false;
            generateChartsButton.Enabled = false;
            resetButton.Enabled = false;

            fieldsComboBox.Enabled = false;
            categoricComboBox.Enabled = false;
            stringTextBox.Enabled = false;
            numberMinTextBox.Enabled = false;
            numberMaxTextBox.Enabled = false;

            dt = new DataTable();
            dv = new DataView(dt);
            dsM = new DataSetManager();

            dataGridView1.DataSource = dv;
        }

        // ------------------------------------------------------------------------------

        // Method to reseat all the information of the data table and create a new data set manager

        public void clearData()
        {
            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
            dsM = new DataSetManager();
            resetFilteringOptionsVisibility();
            resetFilteringOptions();            
            fieldsComboBox.Items.Clear();
        }

        // ------------------------------------------------------------------------------

        // Click method of the Button1, loads table

        private void loadInformationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Checks if the cancel button in the file selector was pressed
            if (result == DialogResult.Cancel)            
                return;
                    
            //Checks if there is already some data in data table
            if(dt.Columns.Count > 0)
                clearData();
                        
            dsM.Load(openFileDialog1.FileName);

            //Gets data from data base manager
            ArrayList[] data = dsM.Data;

            //Set up of columns in data table
            dt.Columns.Add((string)data[0][0], typeof(string));//Name
            dt.Columns.Add((string)data[1][0], typeof(string));//Last_name
            dt.Columns.Add((string)data[2][0], typeof(int));//Time (military format)
            dt.Columns.Add((string)data[3][0], typeof(double));//Latitude
            dt.Columns.Add((string)data[4][0], typeof(double));//Longitude

            //Fill rows in data table
            for (int i = 1; i < data[0].Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr[(string)data[0][0]] = (string)data[0][i];//Name
                dr[(string)data[1][0]] = (string)data[1][i];//Last_name
                dr[(string)data[2][0]] = (int)data[2][i];//Time (military format)
                dr[(string)data[3][0]] = (double)data[3][i];//Latitude
                dr[(string)data[4][0]] = (double)data[4][i];//Longitude

                dt.Rows.Add(dr);
            }           

            //Updates availability of options and set up of filtering fucntionality
            generateChartsButton.Enabled = true;
            resetButton.Enabled = true;
            fieldsComboBox.Enabled = true;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                fieldsComboBox.Items.Add(dt.Columns[i].ColumnName);
            }

            fieldsComboBox.Items.Add(dt.Columns[0].ColumnName + " (First letter) ");
            fieldsComboBox.Items.Add(dt.Columns[1].ColumnName + " (First letter) ");

            LoadMarkers();
            LoadPolygons();

        }
        
        // ------------------------------------------------------------------------------

        // Filter data

        private void filterDataConfirmButton_Click(object sender, EventArgs e)
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
            else if (((string)fieldsComboBox.SelectedItem).Equals(dt.Columns[0].ColumnName + " (First letter) "))
            {
                string letter = Char.ToString((char)categoricComboBox.SelectedItem);
                dv.RowFilter = $"Name LIKE \'{letter}*\'";
            }
            else if (((string)fieldsComboBox.SelectedItem).Equals(dt.Columns[1].ColumnName + " (First letter) "))
            {
                string letter = Char.ToString((char)categoricComboBox.SelectedItem);
                dv.RowFilter = $"Last_name LIKE \'{letter}*\'";
            }
            else
            {
                try
                {
                    double min = Double.Parse(numberMinTextBox.Text, CultureInfo.InvariantCulture);
                    double max = Double.Parse(numberMaxTextBox.Text, CultureInfo.InvariantCulture);

                    if (max < min)
                        throw new FormatException("Max number is smaller than min number!");

                    if (fieldsComboBox.SelectedItem.Equals(dt.Columns[2].ColumnName))
                        dv.RowFilter = $"Time >= {(int)min} AND Time <= {(int)max}";

                    else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[3].ColumnName))
                        dv.RowFilter = $"Latitude >= '{min}' AND Latitude <= '{max}'";

                    else
                        dv.RowFilter = $"Longitude >= '{min}' AND Longitude <= '{max}'";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error filtering data: Make sure the format is right, the fields are complete, and the maximum value is larger than the minimum"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadMarkers();
            LoadPolygons();

        }

        // ------------------------------------------------------------------------------

        private void fieldsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (fieldsComboBox.SelectedIndex == -1)
                return;
            //Clears data from filtering fields and enables reset table button
            filterDataConfirmButton.Enabled = true;
            resetFilteringOptions();

            //String type filtering
            if (fieldsComboBox.SelectedItem.Equals(dt.Columns[0].ColumnName) || fieldsComboBox.SelectedItem.Equals(dt.Columns[1].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = false;
                numberMinTextBox.Enabled = false;
                stringTextBox.Enabled = true;
            }
            //Number type filtering
            else if (fieldsComboBox.SelectedItem.Equals(dt.Columns[2].ColumnName)
            || fieldsComboBox.SelectedItem.Equals(dt.Columns[3].ColumnName)
            || fieldsComboBox.SelectedItem.Equals(dt.Columns[4].ColumnName))
            {
                categoricComboBox.Enabled = false;
                numberMaxTextBox.Enabled = true;
                numberMinTextBox.Enabled = true;
                stringTextBox.Enabled = false;
            }
            //Categoric type filtering
            else
            {
                categoricComboBox.Enabled = true;
                numberMaxTextBox.Enabled = false;
                numberMinTextBox.Enabled = false;
                stringTextBox.Enabled = false;
            }

        }

        // ------------------------------------------------------------------------------

        //Reset button click method: clears data from filtering fields and resets data view row filter

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetFilteringOptions();
            resetFilteringOptionsVisibility();
            fieldsComboBox.SelectedIndex = -1;
        }
        // ------------------------------------------------------------------------------

        //Reset filtering options

        private void resetFilteringOptions()
        {
            dv.RowFilter = "";
            categoricComboBox.SelectedIndex = -1;
            numberMaxTextBox.Text = "";
            numberMinTextBox.Text = "";
            stringTextBox.Text = "";
        }
        // ------------------------------------------------------------------------------

        //Reset filtering options visibility

        private void resetFilteringOptionsVisibility()
        {
            categoricComboBox.Enabled = false;
            numberMaxTextBox.Enabled = false;
            numberMinTextBox.Enabled = false;
            stringTextBox.Enabled = false;
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
            gMapControl1.ShowCenter = false;
        }

        // ------------------------------------------------------------------------------

        // Load markers method to show in the GMap

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

        // ------------------------------------------------------------------------------

        // Load polygons method

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

                GMapPolygon polygon = new GMapPolygon(points, $"{dr["Name"]} {dr["Last_name"]}");
                polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.OrangeRed));
                polygon.Stroke = new Pen(Color.Red);
                markers.Polygons.Add(polygon);
            }
        }

        // ------------------------------------------------------------------------------

        // Click method of generateChartsButton that opens new window for chart creation

        private void generateChartsButton_Click(object sender, EventArgs e)
        {
            ChartWindow secondForm = new ChartWindow(dv);

            secondForm.Show();
        }
    }
}
