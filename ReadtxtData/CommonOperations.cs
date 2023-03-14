using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadtxtData
{
  static  class CommonOperations
    {
        public static string[] ReadTxtFile(string filePath)
        {
            return System.IO.File.ReadAllLines(filePath);
        }
    }
}
