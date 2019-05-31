using SimplePlanner.Model;
using SimplePlanner.View;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimplePlanner.Controller
{
    public class DataController
    {
        private string Filename = @"./test.dat";

        public void init(BoardForm BoardForm)
        {
            BoardData board = BoardForm.CBoardForm.BoardData;

            foreach (var tab in board.Tabs)
            {
                BoardForm.CBoardForm.BoardData.AddTab(BoardForm);
                int i = 0;
                foreach (var item in tab.Works)
                {
                    BoardForm.CBoardForm.BoardData.Tabs[i].InitWorkLabel(BoardForm, item, i);
                    i++;
                }
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
