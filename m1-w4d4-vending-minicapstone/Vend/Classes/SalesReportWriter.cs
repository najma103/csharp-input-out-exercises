using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vend.Classes
{
    public class SalesReportWriter
    {
        static string outputFileDir = Environment.CurrentDirectory;
        static string filename = "salesReport.csv";
        static string outputFileName = String.Format("{0:yyyy-MM-dd hhmm}__{1}", DateTime.Now, filename);
        string filePath = Path.Combine(outputFileDir, outputFileName);

        VendingMachineFileReader reader = new VendingMachineFileReader();

        public void SaleReportWriterMethod(Dictionary<string, int> salesReportDict, double totalSales)
        {

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                foreach (KeyValuePair<string, int> kvp in salesReportDict)
                {
                    sw.WriteLine(kvp.Key + ", " + kvp.Value);
                }
                sw.WriteLine();
                sw.WriteLine("Total Sales: " + "," + "$" + totalSales);


            }

        }
    }
}

