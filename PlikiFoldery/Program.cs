using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlikiFoldery
{
    class Program
    {
        static void Main(string[] args)
        {

            CopyDir(@"C:\tmp", @"C:\tmp2");

            String path = @"C:\tmp\plik.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
            StreamWriter sw = File.CreateText(path);
            sw.Close();

            File.WriteAllText(path, "Ala ma kota, a kot ma kleszcze.");

            String s = File.ReadAllText(path);

            File.Copy(path, @"c:\tmp\dest.txt", true);

            //File.Move(path, @"c:\tmp\dest1.txt");

            //Metody operujace na folderach
            String folderName = @"c:\test\alx";
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            Directory.Move(folderName, @"c:\test\csharp\");
            Directory.Delete(@"c:\test\csharp\", true);

            Console.WriteLine(s);
            Console.ReadKey();
        }

        static void CopyDir(string sourceDir, string targetDir)
        {
            // normalizacja ścieżek folderów
            if (!sourceDir.EndsWith(@"\"))
            {
                sourceDir += @"\";
            }
            if (!targetDir.EndsWith(@"\"))
            {
                targetDir += @"\";
            }

            //pobierz wszystkie pliki i nazwy podfolderow z sourceDir
            string[] files = Directory.GetFileSystemEntries(sourceDir);

            // utwórz folder docelowy
            Directory.CreateDirectory(targetDir);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
                FileAttributes attrs = File.GetAttributes(files[i]);
                String srcFile = Path.GetFileName(files[i]);

                if (attrs == FileAttributes.Directory)
                {
                    //obsluga rekurencyjna folderow
                    String newFolder = targetDir + srcFile;
                    if (!Directory.Exists(newFolder)) {
                        Directory.CreateDirectory(newFolder);
                    }
                    CopyDir(files[i], newFolder);

                } else
                {
                    //skopiowanie pliku
                    File.Copy(files[i], targetDir + srcFile);
                }
            }
        }
    }
}
