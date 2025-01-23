namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            HashSet<byte> specialBytes = new HashSet<byte>();
            using (StreamReader byteReader = new StreamReader(bytesFilePath))
            {
                while (!byteReader.EndOfStream)
                {
                    byte currentByte = byte.Parse(byteReader.ReadLine());
                    specialBytes.Add(currentByte);
                }
            }
            
            using (FileStream inputStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int readBytes;
                    while ((readBytes = inputStream.Read(buffer)) != 0)
                    {
                        int specialBytesCount = 0;
                        for(int i = 0; i < readBytes; i++)
                        {
                            if (specialBytes.Contains(buffer[i]))
                            {
                                buffer[specialBytesCount++]=buffer[i];
                            }
                        }
                        outputStream.Write(buffer,0,specialBytesCount);
                    }
                }
                
            }
        }
    }
}
