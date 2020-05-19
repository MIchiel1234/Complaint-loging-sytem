using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prove_of_concept
{
    class filehandeler
    {
      
        public void insertdata(string refnumber)
        {

            FileStream fs = new FileStream("demo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(refnumber);
            sw.Close();
            fs.Dispose();
           

        }
        public List<string> readdata()
        {
            FileStream fs = new FileStream("demo.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            List<string> readbledata = new List<string>();
            using (sr)
            {
                while (line != null)
                {
                    readbledata.Add(line);
                    line = sr.ReadLine();
                }
            }
            sr.Close();
            fs.Dispose();
            return readbledata;

        }
    }
}
