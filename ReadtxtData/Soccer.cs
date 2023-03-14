using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadtxtData
{
    class Soccer : IReadTxtRecords
    {
        public string ReadTxtRecords()
        {

            var soccerTextData = ReadTxtInList(CommonConst.soccerTextFile);

            Dictionary<string, int> doc = new Dictionary<string, int>();

            foreach (var soccerText in soccerTextData)
            {
                int diff = Math.Abs(Convert.ToInt32(soccerText.F) - Convert.ToInt32(soccerText.A));
                doc.Add(soccerText.Team, diff);
            }

            var item = doc.Where(e => e.Value == doc.Min(e2 => e2.Value)).First();

            return "Team name: " + item.Key + "\nMin Score: " + item.Value;
        }

        private List<SoccerModel> ReadTxtInList(string filePath)
        {
            List<SoccerModel> soccerModelList = new List<SoccerModel>();

            string[] lines = CommonOperations.ReadTxtFile(CommonConst.soccerTextFile);

            for (int j = 2; j < lines.Length; j++)
            {
                if (!string.IsNullOrEmpty(lines[j]))
                {
                    var cols = lines[j].Split(' ');
                    cols = cols.Where(x => !string.IsNullOrEmpty(x) && x != "-").ToArray();
                    if (!cols[0].Contains("-"))
                    {
                        SoccerModel soccerModel = new SoccerModel();
                        soccerModel.SNo = cols[0];
                        soccerModel.Team = cols[1];
                        soccerModel.P = cols[2];
                        soccerModel.W = cols[3];
                        soccerModel.L = cols[4];
                        soccerModel.D = cols[5];
                        soccerModel.F = cols[6];
                        soccerModel.A = cols[7];
                        soccerModel.Pts = cols[8];

                        soccerModelList.Add(soccerModel);
                    }
                }
            }
            return soccerModelList;
        }
    }
}
