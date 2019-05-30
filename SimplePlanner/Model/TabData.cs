using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePlanner.Model
{
    [Serializable]
    class TabData
    {
        public TabData(string _name)
        {
            TabName = _name;
            Works = new List<WorkData>();
        }

        public string TabName { get; set; }
        public List<WorkData> Works { get; set; }
    }
}
