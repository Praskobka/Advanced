namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            int countInput1 = 0;
            int countInput2 = 0;
            using(StreamReader input1=new StreamReader(firstInputFilePath))
            {
                while(input1.ReadLine() != null)
                {
                    countInput1++;
                }
            }
            using (StreamReader input2 = new StreamReader(secondInputFilePath))
            {
                while (input2.ReadLine() != null)
                {
                    countInput2++;
                }
            }
            int lineToMatchTo = 0;
            if(countInput1 > countInput2)
            {
                lineToMatchTo = countInput2;
            }
            else if (countInput2 == countInput1)
            {
                lineToMatchTo = countInput1;
            }
            else
            {
                lineToMatchTo = countInput1;
            }
            using (StreamReader input1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader input2 = new StreamReader(secondInputFilePath))
                {
                    using(StreamWriter output= new StreamWriter(outputFilePath))
                    {
                        for (int i = 0; i < lineToMatchTo; i++)
                        {
                            output.WriteLine(input1.ReadLine());
                            output.WriteLine(input2.ReadLine());
                        }
                        if (countInput1 > countInput2)
                        {
                            while(!input2.EndOfStream)
                            {
                                output.WriteLine(input1.ReadLine());
                            }
                        }
                        else if(countInput2>countInput1)
                        {
                            while (!input2.EndOfStream)
                            {
                                output.WriteLine(input2.ReadLine());
                            }
                        }
                    }
                }
            }
        }
    }
}
