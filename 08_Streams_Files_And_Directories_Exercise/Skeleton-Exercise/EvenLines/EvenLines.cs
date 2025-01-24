namespace EvenLines
{
    using System;
    using System.IO;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;
                int lineCount = 0;
                string result = "";
                //'-', ', ', '. ', '! ', '? '
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineCount % 2 ==0)
                    {
                        char[] charArray = line.ToCharArray();
                        for (int i = 0; i < charArray.Length; i++)
                        {
                            if (charArray[i] == '.' || charArray[i] == ',' || charArray[i] == '-' || charArray[i] == '!' || charArray[i] == '?')
                            {
                                charArray[i] = '@';
                            }
                        }
                        string proccesedLine=new string(charArray);
                        string[] words = proccesedLine.Split();
                        Array.Reverse(words);
                        proccesedLine=string.Join(" ", words);
                        result += proccesedLine + Environment.NewLine;
                    }
                    lineCount++;
                }
                return result.TrimEnd();
            }
          
        }
    }
}
