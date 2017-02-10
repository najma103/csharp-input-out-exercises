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
        string filePath = Path.Combine(outputFileDir, outputFileDir);

        VendingMachineFileReader reader = new VendingMachineFileReader();

        public void LogWriterMethod()
        {

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {

                foreach (var item in reader.Items)
                {
                    sw.WriteLine($"{0},{1}", item.Key, item.Value);
                }

            }
            Console.ReadKey();
        }

    }
}
