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
        static string filename = "TransactionLog.txt";
        static string outputFileName = String.Format("{0:yyyy-MM-dd hhmm}__{1}", DateTime.Now, filename);
        string filePath = Path.Combine(outputFileDir, outputFileName);

        VendingMachineFileReader reader = new VendingMachineFileReader();

        public void LogWriterMethod(string machineLog)
        {

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {

                sw.WriteLine(machineLog);

   
            }

        }
    }
}
