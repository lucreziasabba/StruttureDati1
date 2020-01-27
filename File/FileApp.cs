using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace File
{
    class FileApp
    {
        private const string file = "file.txt";
        private const string file2 = "finito.txt";
        static void Main(string[] args)
        {
            List<double> numeri = new List<double>();
            using (StreamReader x = new StreamReader(file, Encoding.UTF8))
            {
                string sline;
                while((sline = x.ReadLine()) != null)
                {
                    double y = Convert.ToDouble(sline);
                    
                    numeri.Add(y);
                }
            }
            using (StreamWriter f = new StreamWriter(file2, true))
            {
                for (int i= numeri.Count-1; i>=0; i--)
                {
                    f.WriteLine(numeri[i]);
                }
            }

        }
    }
        
}
