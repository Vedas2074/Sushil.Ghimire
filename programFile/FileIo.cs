using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
           string fileContent= File.ReadAllText(@"C:\Users\sushi\OneDrive\Desktop\C# tuto\vedasLogo\test.txt");//@ is a verveting character
           Console.WriteLine(fileContent);
        }
        public void LearnFileWriting()
        {
            File.WriteAllText("A.txt","I am new file just created");
        }
        public void LearnFileInfo()
        {
            FileInfo fileInfo= new FileInfo("A.txt");
            var x=fileInfo.Length;
            var y=fileInfo.CreationTime;
            var z= fileInfo.DirectoryName;
        
            Console.WriteLine($"File size:{x} bytes");
            Console.WriteLine($"Created:{y}");
            Console.WriteLine($"Directory:{z}");


        }
        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.sushil","This is my one file");
        }
        internal void LearnDirectoryInfo()
        {
           string folderPath= @"C:\Users\sushi\OneDrive\Desktop\C# tuto\vedasLogo\Sushil.Ghimire";
        DirectoryInfo directory = new DirectoryInfo(folderPath);
        var files = Directory.GetFiles();//return array
        Console.WriteLine("File count:"+files.Length);
        }

    }
}