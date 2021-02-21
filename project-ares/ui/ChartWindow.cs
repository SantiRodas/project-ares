using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace project_ares.ui
{
    public partial class ChartWindow : Form
    {

        // ------------------------------------------------------------------------------

        // Attributes of the system

        private DataTable dataTable;

        // ------------------------------------------------------------------------------

        // Constructor method of the chart window

        public ChartWindow(DataTable dt)
        {
            InitializeComponent();

            dataTable = dt;

            for (int i = 65; i <= 90; i++)
            {

                comboBox1.Items.Add((char)i);
                comboBox2.Items.Add((char)i);
                comboBox3.Items.Add((char)i);
                comboBox4.Items.Add((char)i);

            }

        }

        // ------------------------------------------------------------------------------

        // Button 1 click method

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();

            chart1.Titles.Clear();

            char l = (char)comboBox1.SelectedItem;

            int size = 0;

            DataRowCollection rows = dataTable.Rows;

            string word = "";

            foreach (DataRow dr in rows)
            {

                object[] data = dr.ItemArray;

                word = (string)data[0];

                if (word[0].Equals(l))
                {
                    size++;

                }

            }


            string[] series = {l.ToString()};
            int[] valores = {size};

            chart1.Titles.Add("Lost people with the letter " + l);

            for (int i = 0; i < series.Length; i++)
            {

                Series serie = chart1.Series.Add(series[i]);

                serie.Label = valores[i].ToString();

                serie.Points.Add(valores[i]);

            }

        }

        // ------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {

            chart2.Series.Clear();

            chart2.Titles.Clear();

            char l1 = (char)comboBox2.SelectedItem;
            char l2 = (char)comboBox3.SelectedItem;
            char l3 = (char)comboBox4.SelectedItem;

            int sl1 = 0;
            int sl2 = 0;
            int sl3 = 0;

            DataRowCollection rows = dataTable.Rows;

            string word = "";

            foreach (DataRow dr in rows)
            {

                object[] data = dr.ItemArray;

                word = (string)data[0];

                if (word[0].Equals(l1))
                {
                    sl1++;

                } else if (word[0].Equals(l2))
                {
                    sl2++;

                } else if (word[0].Equals(l3))
                {
                    sl3++;

                }

            }

            chart2.Titles.Add("Lost people with the letter's " + l1 + ", " + l2 + ", " + l3);

            chart2.Series.Add("s1");
            chart2.Series["s1"].Points.AddXY(sl1, 0.2);
            chart2.Series["s1"].Points.AddXY(sl2, 0.5);
            chart2.Series["s1"].Points.AddXY(sl3, 0.3);

        }

        // ------------------------------------------------------------------------------

    }
}
