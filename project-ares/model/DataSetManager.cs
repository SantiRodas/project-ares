using System;
using System.Collections;
using System.IO;
using System.Globalization;

namespace project_ares.model
{
    class DataSetManager
    {
        /*Stores data as follows: 5 position array for each column, each column is an arraylist 
         * with the data values correpsonding to that column, first value being the column name        
        */
        private ArrayList[] data;

        public ArrayList[] Data{
            get { return data; }
        }

        public DataSetManager()
        {
            data = new ArrayList[5];
        
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = new ArrayList();                
            }       

        }

        public void Load(string path)
        {
            StreamReader sr  = new StreamReader(File.OpenRead(path));

            if (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');
                data[0].Add(line[0]);
                data[1].Add(line[1]);
                data[2].Add(line[2]);
                data[3].Add(line[3]);
                data[4].Add(line[4]);

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(',');
                    data[0].Add(line[0]);
                    data[1].Add(line[1]);

                    string[] splitHour = line[2].Split(':');

                    int hour = int.Parse(splitHour[0] + "00");

                    int minute = int.Parse(splitHour[1].Substring(0,2));

                    string dayMoment = splitHour[1].Substring(3,2);

                    hour = dayMoment.Equals("PM") ? (hour < 1200?  hour + 1200 : hour): (hour < 1200? hour : hour - 1200);

                    int time = hour + minute;

                    data[2].Add(time);
                    data[3].Add(Double.Parse(line[3],CultureInfo.InvariantCulture));
                    data[4].Add(Double.Parse(line[4], CultureInfo.InvariantCulture));
                }
            }

        }

    }
}
