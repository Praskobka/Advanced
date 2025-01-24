namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line;
                    int lineCount = 1;

                    while ((line = reader.ReadLine()) != null)
                    {
                        int punctAmount = 0;
                        int letterAmount = 0;
                        char[] charArray = line.ToCharArray();

                        for (int i = 0; i < charArray.Length; i++)
                        {
                            if (charArray[i] == '.' || charArray[i] == ',' || charArray[i] == '-' || charArray[i] == '!' || charArray[i] == '?' || charArray[i] == '`')
                            {
                                punctAmount++;
                            }
                            else if (char.IsLetter(charArray[i]))
                            {
                                letterAmount++;
                            }
                        }

                        writer.WriteLine($"Line {lineCount}: {line} ({letterAmount})({punctAmount})");
                        lineCount++;
                    }
                }
            }

        }
    }
}
