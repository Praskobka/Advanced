namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using(StreamReader wordReader = new StreamReader(wordsFilePath))
            {
                string[] words = wordReader.ReadLine().Split();
                Dictionary<string,int> wordsMet = new Dictionary<string,int>();
                foreach(string word in words)
                {
                    wordsMet.Add(word, 0);
                }
                using(StreamReader textReader = new StreamReader(textFilePath))
                {
                    char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-' };
                    while (!textReader.EndOfStream)
                    {
                        string line = textReader.ReadLine();
                        string[] textWords=line.Split(separators,StringSplitOptions.RemoveEmptyEntries);
                        foreach(string word in textWords)
                        {
                            string textWord=word.ToLower();
                            if (wordsMet.ContainsKey(textWord))
                            {
                                wordsMet[textWord]++;
                            }
                        }
                    }
                    using (StreamWriter outputWriter = new StreamWriter(outputFilePath))
                    {
                        Dictionary<string, int> sorted=wordsMet.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
                        foreach(string key in sorted.Keys)
                        {
                            outputWriter.WriteLine($"{key} - {wordsMet[key]}");
                        }
                    }
                    
                }
            }
        }
    }
}
