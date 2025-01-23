namespace FolderSize
{
    using System;
    using System.IO;
    using System.Text;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] files = Directory.GetFiles(folderPath);
            long totalBytes = 0;
            foreach (string file in files)
            {
                totalBytes += new FileInfo(file).Length;
            }
            decimal kb = totalBytes / 1024M;
            using (FileStream output = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] sizeBytes = Encoding.UTF8.GetBytes($"{kb} KB");
                output.Write(sizeBytes, 0, sizeBytes.Length);
            }
        }
    }
}
