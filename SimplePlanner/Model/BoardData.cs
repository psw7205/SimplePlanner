using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePlanner.Model
{
    [Serializable]
    class BoardData
    {
        public BoardData(string _name)
        {
            BoardName = _name;
            Tabs = new List<TabData>();
        }

        public string BoardName { get; set; }
        public List<TabData> Tabs { get; set; }
    }
}
