using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class BindingClass
    {
        public string BoardName { get; set; }
        public List<BindingTab> Tabs { get; set; }
    }

    [Serializable]
    public class BindingTab
    {
        public string TabName { get; set; }
        public List<BindingWork> Works { get; set; }
    }

    [Serializable]
    public class BindingWork
    {
        public BindingWork(string _name, string _content)
        {
            WorkName = _name;
            WorkContent = _content;
        }

        public string WorkName { get; set; }
        public string WorkContent { get; set; }
    }

    class DataSave
    {
        private string Filename = @"./test.dat";
        public void SerializeData(BindingClass data)
        {
            BinaryFormatter binFmt = new BinaryFormatter();
            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                binFmt.Serialize(fs, data);
            }
        }

        public BindingClass DeserializeData()
        {
            BindingClass p;
            BinaryFormatter binFmt = new BinaryFormatter();

            try
            {
                using (FileStream rdr = new FileStream(Filename, FileMode.Open))
                {
                    p = (BindingClass)binFmt.Deserialize(rdr);
                }
            }
            catch (Exception)
            {

                return null;
            }
            

            return p;
        }

    }
}
