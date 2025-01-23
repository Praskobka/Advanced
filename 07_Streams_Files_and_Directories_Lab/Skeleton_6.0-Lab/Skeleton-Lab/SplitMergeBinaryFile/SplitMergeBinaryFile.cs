namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] pngInBytes= File.ReadAllBytes(sourceFilePath);
            int midPoint=pngInBytes.Length/2;
            byte[] part1 = new byte[midPoint];
            byte[] part2 = new byte[pngInBytes.Length-midPoint];
            Array.Copy(pngInBytes,0,part1,0,midPoint);
            Array.Copy(pngInBytes,midPoint,part2,0,part2.Length);
            using(FileStream fileStream1=new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
            {
                fileStream1.Write(part1,0,part1.Length);
            }
            using (FileStream fileStream2 = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
            {
                fileStream2.Write(part2, 0, part2.Length);
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] part1Bytes = File.ReadAllBytes(partOneFilePath);
            byte[] part2Bytes = File.ReadAllBytes(partTwoFilePath);
            byte[] combinedBytes = new byte[part1Bytes.Length + part2Bytes.Length];
            Array.Copy(part1Bytes, 0, combinedBytes, 0, part1Bytes.Length);
            Array.Copy(part2Bytes, 0, combinedBytes, part1Bytes.Length, part2Bytes.Length);
            using(FileStream outputToPng=new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                outputToPng.Write(combinedBytes, 0, combinedBytes.Length);
            }
        }
    }
}