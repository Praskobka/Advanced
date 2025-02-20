﻿namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";
            ZipFileToArchive(inputFile, zipArchiveFile);
            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }
        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (FileStream zipToOpen = new FileStream(zipArchiveFilePath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(inputFilePath, Path.GetFileName(inputFilePath));
                }
            }
        }
        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using (ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                ZipArchiveEntry entry = archive.GetEntry(fileName);
                if (entry != null)
                {
                    entry.ExtractToFile(outputFilePath, overwrite: true);
                }
                else
                {
                    Console.WriteLine($"File {fileName} not found in the archive.");
                }
            }
        }
    }
}
