using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePlanner.Model
{
    [Serializable]
    public class WorkData
    {
        public WorkData(string _name = "", string _content = "")
        {
            WorkName = _name;
            WorkContent = _content;
        }

        public string WorkName { get; set; }
        public string WorkContent { get; set; }

    }
}
