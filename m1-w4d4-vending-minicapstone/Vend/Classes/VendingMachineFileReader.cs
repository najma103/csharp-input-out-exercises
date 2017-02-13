using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendingMachineFileReader
    {
        Dictionary<string, VendingMachineItems> items = new
                Dictionary<string, VendingMachineItems>();

        static string fileDir = Environment.CurrentDirectory;
        static string fileName = @"vendingmachine.csv";
        string filePath = Path.Combine(fileDir, fileName);


        public VendingMachineFileReader()
        {
            //VendingMachineItems vmi = new VendingMachineItems();
            items = readAndLoadFile(filePath, items);
        }
        public Dictionary<string, VendingMachineItems> Items
        {
            get { return items; }
        }

        public Dictionary<string,VendingMachineItems> readAndLoadFile(string filePath, Dictionary<string,VendingMachineItems> items)
        {
            bool srcExists = File.Exists(filePath);
            if (srcExists)
            {

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        // Read the file until the end of the stream is reached
                        while (!sr.EndOfStream)
                        {
                            // Read in a single line
                            string[] line = sr.ReadLine().Split('|');
                            VendingMachineItems item = new VendingMachineItems();
                            string itemKey = line[0];
                            item.Name = line[1];
                            item.Price = Double.Parse(line[2]);
                            item.Quantity = 5;
                            items[itemKey] = item;

                        } //go to the next line until the end is reached
                    }
                }
                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error invalid FilePath given ");
                Console.ReadKey();
            }
            return items;


      }
  }
}
