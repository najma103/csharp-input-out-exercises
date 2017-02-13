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

        public void LogWriterMethod(string machineLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {

                    sw.WriteLine(machineLog);

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error Writing to the file" + e);
            }
 

        }
    }
}
