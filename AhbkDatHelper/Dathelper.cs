using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

using System.Security.Principal;

namespace AhbkDatHelper
{
    public class Dathelper
    {
        private string path;
        public Dathelper()
        {
             path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Ahbk SoftTech\Data\WGCore.dat";
            checkFile();
        }

        public void addFormat(string format)
        {
            checkFile();

            using (StreamWriter fs = new StreamWriter(path, true))
            {
                fs.WriteLine(format);
                fs.Close();
                
            }
          
        }
        public List<string> GetFormats()
        {
            checkFile();
            List<string> formats = new List<string>();

            using (StreamReader okuyucu = new StreamReader(path))
            {
                string satir;
                while ((satir = okuyucu.ReadLine()) != null)
                {
                   

                    formats.Add(satir);
                }
            }

            return formats;
        }

        public  void checkFile()
        {
            if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Ahbk SoftTech\Data"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Ahbk SoftTech\Data");
            if (!File.Exists(path))                
                File.Create(path).Close();
          
        }
    }
}
