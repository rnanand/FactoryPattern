using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadtxtData
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputFileName = string.Empty;
            inputFileName = Console.ReadLine();

            IReadTxtRecords factoryResult = TxtFactory.ReadFactoryData(inputFileName);

            Console.WriteLine(factoryResult.ReadTxtRecords());
            Console.ReadLine();
        }
    }
}
