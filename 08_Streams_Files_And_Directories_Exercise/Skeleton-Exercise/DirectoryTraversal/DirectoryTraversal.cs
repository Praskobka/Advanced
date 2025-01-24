using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension.ToLower();
                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension[extension] = new List<FileInfo>();
                }
                filesByExtension[extension].Add(fileInfo);
            }
            var reportContent = new System.Text.StringBuilder();
            var orderedExtensions = filesByExtension
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToList();
            foreach (var extensionGroup in orderedExtensions)
            {
                reportContent.AppendLine(extensionGroup.Key);
                var sortedFiles = extensionGroup.Value.OrderBy(x => x.Length).ToList();
                foreach (var file in sortedFiles)
                {
                    reportContent.AppendLine($"--{file.Name} - {file.Length / 1024.0:F3}kb");
                }
                reportContent.AppendLine();
            }
            return reportContent.ToString();
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportFilePath = Path.Combine(desktopPath, reportFileName);
            File.WriteAllText(reportFilePath, textContent);
        }
    }
}
