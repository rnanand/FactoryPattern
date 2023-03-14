using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadtxtData
{
    class TxtFactory
    {
        public static IReadTxtRecords ReadFactoryData(string fileName)
        {
            IReadTxtRecords objReadTxtRecords = null;

            if (fileName.ToLower().Equals("soccer"))
            {
                objReadTxtRecords = new Soccer();
            }
            else if (fileName.ToLower().Equals("weather"))
            {
                objReadTxtRecords = new Weather();
            }

            return objReadTxtRecords;
        }
    }
}
