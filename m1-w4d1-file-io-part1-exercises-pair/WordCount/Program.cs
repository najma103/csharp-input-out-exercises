﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCount.Classes;
using System.IO;

namespace WordCount
{ }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the filepath ?");
            string filePath = Console.ReadLine();
            //filePath = "@" + filePath;
            //filePath = @"C:\WordSearch";
            string filename = @"alices_adventures_in_wonderland.txt";

            // Generating a full path from a folder and a file name
            string fullPath = Path.Combine(filePath, filename);

            bool directoryExists = Directory.Exists(filePath);

            if (directoryExists)
            {
                ReadAndProcessWord.ReadACharacterFile(fullPath);
                ReadAndProcessWord.printTotalCount();
            }


        }
    
