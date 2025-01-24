namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using(FileStream fileStream=new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes=File.ReadAllBytes(inputFilePath);
                using(FileStream fileWriter=new FileStream(outputFilePath,FileMode.Create, FileAccess.Write))
                {
                    fileWriter.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}
