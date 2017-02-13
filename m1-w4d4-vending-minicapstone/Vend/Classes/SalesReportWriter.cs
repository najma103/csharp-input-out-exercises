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


        public void SaleReportWriterMethod(Dictionary<string, VendingMachineItems> salesReportDict)
        {
            double totalSales = 0.0;

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                foreach (KeyValuePair<string, VendingMachineItems> kvp in salesReportDict)
                {
                    //sw.WriteLine(kvp.Key + ", " + kvp.Value);
                    string name = kvp.Value.Name.ToString();
                    int quantity = kvp.Value.Quantity;
                    double price = kvp.Value.Price;
                   
                    if (quantity == 5)
                    {
                        sw.WriteLine(name + ", " + 0);
                    }
                    else
                    {
                        quantity = 5 - quantity;
                        totalSales += quantity * price;
                        sw.WriteLine(name + ", " + quantity);
                    }
                   
                }
                sw.WriteLine();
                sw.WriteLine("Total Sales: " + "," + "$" + totalSales);


            }

        }
    }
}

