using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Globalization;

namespace project_ares.model
{
    class DataSetManager
    {
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
                    data[2].Add(line[2]);
                    data[3].Add(Double.Parse(line[3],CultureInfo.InvariantCulture));
                    data[4].Add(Double.Parse(line[4], CultureInfo.InvariantCulture));
                }
            }

        }

    }
}
