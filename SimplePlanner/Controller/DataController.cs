using SimplePlanner.Model;
using SimplePlanner.View;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimplePlanner.Controller
{
    // 데이터를 저장하고 불러오는 클래스
    public class DataController
    {
        // 파일의 기본 저장 위치
        private readonly string Filename = @"./Data.dat";

        // 처음 실행 시 불러온 데이터에 맞게 탭, 일정 생성
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
        
        // 데이터 직렬화 
        public void SerializeData(BoardData data)
        {
            BinaryFormatter binFmt = new BinaryFormatter();
            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                binFmt.Serialize(fs, data);
            }
        }

        // 보드 데이터가 없거나 잘못 되었다면 null 반환
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
