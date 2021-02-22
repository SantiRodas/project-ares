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

        public ChartWindow(DataView dv)
        {
            InitializeComponent();

            dataTable = dv.ToTable();

            for (int i = 65; i <= 90; i++)
            {

                nameOptionsComboBox.Items.Add((char)i);
                lastnameOption1CB.Items.Add((char)i);
                lastnameOption2CB.Items.Add((char)i);
                lastnameOption3CB.Items.Add((char)i);

            }

        }

        // ------------------------------------------------------------------------------

        // Button 1 click method

        private void filterNameButton_Click(object sender, EventArgs e)
        {

            if (nameOptionsComboBox.SelectedItem != null)
            {

                firstNameLetterChart.Series.Clear();

                firstNameLetterChart.Titles.Clear();

                char l = (char)nameOptionsComboBox.SelectedItem;

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

                firstNameLetterChart.Titles.Add("Lost people with the letter " + l);

                for (int i = 0; i < series.Length; i++)
                {
                    Series serie = firstNameLetterChart.Series.Add(series[i]);

                    serie.Label = valores[i].ToString();

                    serie.Points.Add(valores[i]);
                }

            } else
            {
                MessageBox.Show("Select one item", "Attention");
            }

        }

        // ------------------------------------------------------------------------------

        private void filterLastnameButton_Click(object sender, EventArgs e)
        {

            if (lastnameOption1CB.SelectedItem != null || lastnameOption2CB.SelectedItem != null || lastnameOption3CB.SelectedItem != null)
            {
                firstLastnameLetterChart.Series.Clear();

                firstLastnameLetterChart.Titles.Clear();

                char l1 = (char)lastnameOption1CB.SelectedItem;
                char l2 = (char)lastnameOption2CB.SelectedItem;
                char l3 = (char)lastnameOption3CB.SelectedItem;

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

                firstLastnameLetterChart.Titles.Add("Lost people with the letter's " + l1 + ", " + l2 + ", " + l3 + ",  in the firts chart of the last name");

                firstLastnameLetterChart.Series.Add("Series2");

                firstLastnameLetterChart.Series["Series2"].ChartType = SeriesChartType.Pie;

                for (int i = 0; i < series.Length; i++)
                {
                    firstLastnameLetterChart.Series["Series2"].Points.AddXY(series[i], valores[i]);
                }

                int t = count - (sl1 + sl2 + sl3);

                firstLastnameLetterChart.Series["Series2"].Points.AddXY("Others", t);

                firstLastnameLetterChart.Series["Series2"].Label = "#VALY";

                firstLastnameLetterChart.Series["Series2"].LegendText = "#VALX";

            } else
            {
                MessageBox.Show("Attention", "Select three item's");
            }

        }

        // ------------------------------------------------------------------------------

        // Button 3 click method

        private void filterTimeButton_Click(object sender, EventArgs e)
        {
            timeFilterChart.Series.Clear();

            timeFilterChart.Titles.Clear();

            if (timeOption1.Checked || timeOption2.Checked || timeOption3.Checked || timeOption4.Checked)
            {
                DataRowCollection rows = dataTable.Rows;

                int[] counts = new int[6];

                int limitMin;

                if (timeOption1.Checked)
                {
                    limitMin = 0;
                }
                else if (timeOption2.Checked)
                {
                    limitMin = 600;
                }
                else if (timeOption3.Checked)
                {
                    limitMin = 1200;
                }
                else
                {
                    limitMin = 1800;
                }

                foreach (DataRow dr in rows)
                {
                    int position = (int)(((int)dr["Time"] - limitMin) / 100);

                    if (position >= 0 && position <= 5)
                    {
                        counts[position]++;
                    }

                }

                timeFilterChart.Series.Add("Series3");
                timeFilterChart.Series["Series3"].ChartType = SeriesChartType.Line;

                for (int i = 0; i < counts.Length; i++)
                {
                    timeFilterChart.Series["Series3"].Points.AddXY(limitMin + i * 100, counts[i]);
                }

                timeFilterChart.Series["Series3"].Label = "#VALY";

            }
            else
            {
                MessageBox.Show("Select one item to filter", "Attention");
            }

        }

        // ------------------------------------------------------------------------------

    }
}
