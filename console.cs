using System;
using System.Collections.Generic;
using System.IO;
 
 
namespace RunBeckApp
{
    public class dataObject
    {
        public string fileName { get; set; }
        public string filePath { get; set; }
        public List<string> goodLines { get; set; }
        public List<string> badLines { get; set; }
        public int numFields { get;set;}
        public string fileType { get; set; }
 
        public dataObject()
        {
            fileName = "";
            goodLines = new List<string>();
            badLines = new List<string>();
            numFields = 0;
            fileType = "C";
        }
    }
 
    class Program
    {      
        static void Main(string[] args)
        {
            dataObject obj = new dataObject();
 
            int retCode = 0;
 
            while (retCode == 0)               
            {
                Console.Write("Please enter the file name/location to process or (Q) to Quit? ");
                string filePath = Console.ReadLine();
                retCode = isValidInputFile(filePath);
 
                if (retCode == 0)
                {
                    Console.WriteLine("Invalid file");
                } else if (retCode == -1)
                {
                    break;
                } else
                {
                    obj.fileName = Path.GetFileName(filePath);
                    obj.filePath = Path.GetDirectoryName(filePath);
                }
            }
 
            if (retCode > 0)
            {
                retCode = 0;
                while (retCode == 0)
                {
                    Console.Write("Is this a (T)ab Delimited or (C)omma Delimited file? ");
                    obj.fileType = Console.ReadLine();
 
                    if ((obj.fileType.ToUpper().Equals("T")) || (obj.fileType.ToUpper().Equals("C")))
                    {
                        retCode = 1;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect type picked");
                    }
                }
            }
 
            if (retCode > 0)
            {
                retCode = 0;
                while (retCode == 0)
                {
                    Console.Write("How fields are in this file? ");
                    string numFields = Console.ReadLine();
 
                    int iNumFields;
                    if (!int.TryParse(numFields, out iNumFields))
                    {
                        Console.WriteLine("Incorrect type picked");
                    }
                    else if (iNumFields <=0)
                    {
                        Console.WriteLine("Must have at least one field");
                    } else
                    {
                        obj.numFields = iNumFields;
                        retCode = 1;
                    }
                }
            }
 
            if (retCode > 0)
            {
                processInputFile(obj);
                outputSuccessResults(obj);
                outputFailureResults(obj);
            }
 
        }
 
        static int isValidInputFile(string filePath)
        {
            if (String.IsNullOrEmpty(filePath)) return 0;
            if (filePath.ToUpper().Equals("Q")) return -1;
            if (!File.Exists(filePath)) return 0;
 
            return 1;
        }
 
        static void processInputFile(dataObject obj)
        {
            string seperator = ",";
 
            if (obj.fileType.ToUpper().Equals("T"))
            {
                seperator = "\t";
            }
 
            int iRows = 0;
 
            IEnumerable<String> lines = File.ReadLines(obj.filePath + @"\\" + obj.fileName);
           
            foreach (string line in lines)
            {
                iRows++;
                Console.WriteLine($"Processing Row #{iRows}");
 
                if (iRows > 1)
                {
                    string[] cols = line.Split(seperator);
                    if (cols.Length != obj.numFields)
                    {
                        obj.badLines.Add(line);
                    }
                    else
                    {
                        obj.goodLines.Add(line);
                    }
                }
 
            }
        }
 
        static void outputSuccessResults(dataObject obj)
        {
            if (obj.goodLines.Count > 0)
            {
                StreamWriter sw = new StreamWriter($"{obj.filePath}\\successes_{obj.fileName}");
                foreach (var line in obj.goodLines)
                {
                    sw.WriteLine(line);
                }
                sw.Dispose();
            }
        }
 
        static void outputFailureResults(dataObject obj)
        {
            if (obj.badLines.Count > 0)
            {
                StreamWriter sw = new StreamWriter($"{obj.filePath}\\failures_{obj.fileName}");
                foreach (var line in obj.badLines)
                {
                    sw.WriteLine(line);
                }
                sw.Dispose();
            }
        }
    }
}