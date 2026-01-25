using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "log.txt";
        string outputFile = "error.txt";

        using (StreamReader sr = new StreamReader(inputFile))
        using (StreamWriter sw = new StreamWriter(outputFile))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("ERROR"))
                    sw.WriteLine(line);
            }
        }
    }
}
