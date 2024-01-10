using System;
using System.IO;
using System.IO.Compression;

namespace Part2
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Input path to file:");
            string searchPath = Console.ReadLine();

            Console.WriteLine("Input file name :");
            string searchFileName = Console.ReadLine();

            string[] foundFiles = Directory.GetFiles(searchPath, searchFileName, SearchOption.AllDirectories);

            if (foundFiles.Length == 0)
            {
                Console.WriteLine("File not found");
                return;
            }

            Console.WriteLine($"Found {foundFiles.Length} file(s)");


            foreach (string filePath in foundFiles)
            {
                CompressFile(filePath);
            }
        }
        static void CompressFile(string filePath)
        {
            string compressedFilePath = filePath + ".gz";
            using (FileStream sourceFile = File.OpenRead(filePath))
            {
                using (FileStream compressedFile = File.Create(compressedFilePath))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFile, CompressionMode.Compress))
                    {
                        sourceFile.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}