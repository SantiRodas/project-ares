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

            if (comboBox1.SelectedItem != null)
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


                string[] series = { l.ToString() };
                int[] valores = { size };

                chart1.Titles.Add("Lost people with the letter " + l);

                for (int i = 0; i < series.Length; i++)
                {

                    Series serie = chart1.Series.Add(series[i]);

                    serie.Label = valores[i].ToString();

                    serie.Points.Add(valores[i]);

                }

            } else
            {

                MessageBox.Show("Select one item", "Attention");

            }

        }

        // ------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedItem != null || comboBox3.SelectedItem != null || comboBox4.SelectedItem != null)
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

                int count = 0;

                foreach (DataRow dr in rows)
                {

                    count++;

                    object[] data = dr.ItemArray;

                    word = (string)data[1];

                    if (word[0].Equals(l1))
                    {
                        sl1++;

                    }
                    else if (word[0].Equals(l2))
                    {
                        sl2++;

                    }
                    else if (word[0].Equals(l3))
                    {
                        sl3++;

                    }

                }

                string[] series = {l1.ToString(), l2.ToString(), l3.ToString()};
                int[] valores = {sl1, sl2, sl3};

                chart2.Titles.Add("Lost people with the letter's " + l1 + ", " + l2 + ", " + l3 + ",  in the firts chart of the last name");

                chart2.Series.Add("Series2");

                chart2.Series["Series2"].ChartType = SeriesChartType.Pie;

                for (int i = 0; i < series.Length; i++)
                {

                    chart2.Series["Series2"].Points.AddXY(series[i], valores[i]);

                }

                int t = count - (sl1 + sl2 + sl3);

                chart2.Series["Series2"].Points.AddXY("Others", t);

                chart2.Series["Series2"].Label = "#VALY";

                chart2.Series["Series2"].LegendText = "#VALX";

            } else
            {

                MessageBox.Show("Attention", "Select three item's");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            chart3.Series.Clear();

            chart3.Titles.Clear();

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {

                DataRowCollection rows = dataTable.Rows;

                int[] counts = new int[6];

                int limitMin = 0;
                int limitMax = 0;

                int validation = 0;

                if (radioButton1.Checked)
                {
                    limitMax = 559;

                    validation = 1;

                }
                else if (radioButton2.Checked)
                {
                    limitMin = 600;
                    limitMax = 1159;

                    validation = 2;

                }
                else if (radioButton3.Checked)
                {
                    limitMin = 1200;
                    limitMax = 1759;

                    validation = 3;

                }
                else
                {
                    limitMin = 1800;
                    limitMax = 2259;

                    validation = 4;

                }

                foreach (DataRow dr in rows)
                {
                    int position = (int)(((int)dr["Time"] - limitMin) / 100);

                    if (position >= 0 && position <= 5)
                    {
                        counts[position]++;
                    }

                }

                chart3.Series.Add("Series3");
                chart3.Series["Series3"].ChartType = SeriesChartType.Line;

                for (int i = 0; i < counts.Length; i++)
                {

                    chart3.Series["Series3"].Points.AddXY(limitMin + i * 100, counts[i]);

                }

                chart3.Series["Series3"].Label = "#VALY";

            }
            else
            {

                MessageBox.Show("Select one item to filter", "Attention");

            }

        }

        // ------------------------------------------------------------------------------

    }
}
