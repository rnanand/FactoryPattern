using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadtxtData
{
    class Weather : IReadTxtRecords
    {
        public string ReadTxtRecords()
        {
            List<WeatherModel> weatherList = new List<WeatherModel>();

          // System.IO.File.ReadAllLines(CommonConst.weatherTextFile);

            string[] lines = CommonOperations.ReadTxtFile(CommonConst.weatherTextFile);
            for (int j = 2; j < lines.Length - 1; j++)
            {
                if (!string.IsNullOrEmpty(lines[j]))
                {
                    var cols = lines[j].Split(' ');
                    cols = cols.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                    WeatherModel weatherModel = new WeatherModel();
                    weatherModel.Dy = cols[0];
                    weatherModel.MxT = cols[1].Contains("*") ? cols[1].Replace("*", "") : cols[1];
                    weatherModel.MnT = cols[2].Contains("*") ? cols[2].Replace("*", "") : cols[2];

                    weatherList.Add(weatherModel);
                }
            }

          //  var minimumTemp = weatherList.MinBy(p => p.MnT);

            var minimumTemp = weatherList.OrderBy(p => p.MnT).First();

            return "Dy : " + minimumTemp.Dy + " \nMnt : " + minimumTemp.MnT;
        }
    }
}
