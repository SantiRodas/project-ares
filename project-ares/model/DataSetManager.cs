using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace project_ares.model
{
    class DataSetManager
    {
        private ArrayList[] data;

        public ArrayList[] Data{
            get;set;
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

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');
            }


        }

    }
}
