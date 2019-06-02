using SimplePlanner.Model;
using SimplePlanner.View;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimplePlanner.Controller
{
    public class DataController
    {
        private readonly string Filename = @"./test.dat";

        public void Init(BoardForm BoardForm)
        {
            BoardData board = BoardForm.CBoardForm.BoardData;

            int i = 0, j = 0;
            foreach (var tab in board.Tabs)
            {
                BoardForm.CBoardForm.BoardData.AddTab(BoardForm, tab.TabName);
                foreach (var item in tab.Works)
                {
                    BoardForm.CBoardForm.BoardData.Tabs[i].InitWorkLabel(BoardForm, item, j);
                    j++;
                }
                j = 0;
                i++;
            }
        }

        public void SerializeData(BoardData data)
        {
            BinaryFormatter binFmt = new BinaryFormatter();
            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                binFmt.Serialize(fs, data);
            }
        }

        public BoardData DeserializeData()
        {
            BoardData p;
            BinaryFormatter binFmt = new BinaryFormatter();

            try
            {
                using (FileStream rdr = new FileStream(Filename, FileMode.Open))
                {
                    p = (BoardData)binFmt.Deserialize(rdr);
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
