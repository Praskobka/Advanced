namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            using (StreamReader sr = new StreamReader(inputFilePath))
            {          
                int rowNumber = 1;
                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {                 
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        sw.WriteLine($"{rowNumber}. {line}");
                        rowNumber++;
                    }    
                }
            }
        }
    }
}
