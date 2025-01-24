namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            string[] files = Directory.GetFiles(inputPath);
            using(FileStream writer=new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            {
                foreach(string file in files)
                {
                    byte[] bytes= File.ReadAllBytes(file);
                    writer.Write(bytes,0,bytes.Length);
                }
            }
        }
    }
}
