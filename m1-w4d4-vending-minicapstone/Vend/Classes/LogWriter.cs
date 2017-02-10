using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vend.Classes
{
    public class LogWriter
    {
        static string outputFileDir = Environment.CurrentDirectory;
        static string outputFileName = @"TransactionLog.txt";
        string filePath = Path.Combine(outputFileDir, outputFileName);

        VendingMachineFileReader reader = new VendingMachineFileReader();

        public void LogWriterMethod()
        {

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {

                sw.WriteLine($"\nDateTime Product Slot AmountAccepted ChangeTendered\n");

                foreach (var item in reader.Items)
                {
                    sw.WriteLine($"{item.Key},{item.Value}");
                }

            }
            Console.ReadKey();
        }

    }
}
