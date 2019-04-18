using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Reflection;

namespace Lab_13
{
    class SSLFileManager
    {
        public void ListOfFiles()
        {
            string dirName = @"C:\";
            string[] dirs = Directory.GetDirectories(dirName);
            string[] files = Directory.GetFiles(dirName);
            if (!Directory.Exists(dirName)) return;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Подкаталоги:");

            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("/n-----------------------------------------");
            Console.WriteLine("Файлы:");

            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
        }

        public void Task_1()
        {
            string dirName = @"C:\";
            string prefPath = @"";
            string[] dirs = Directory.GetDirectories(dirName);
            string[] files = Directory.GetFiles(dirName);
            DirectoryInfo directory = new DirectoryInfo(prefPath + @"SSLInspect");
            directory.Create();

            string path = prefPath + @"SSLInspect\SSLdirinfo.txt";

            using (StreamWriter file_w = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                file_w.WriteLine("Подкаталоги:");

                foreach (string s in dirs)
                {
                    file_w.WriteLine(s);
                }
                file_w.WriteLine();
                file_w.WriteLine("Файлы:");

                foreach (string s in files)
                {
                    file_w.WriteLine(s);
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Запись прошла успешно");
            }

            string newPath = prefPath + @"SSLInspect\NEWSSLdirinfo.txt"; ;
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
            }
            File.Delete(prefPath + @"SSLInspect\SSLdirinfo.txt");
        }

        public void Task_2(string dirName, string txt)
        {
            string prefPath = @"";
            DirectoryInfo directory = new DirectoryInfo(prefPath + "SSLFiles");
            directory.Create();

            string[] files = Directory.GetFiles(dirName, "*." + txt);

            foreach (var s in files)
            {
                FileInfo fileInf = new FileInfo(s);
                if (fileInf.ToString() == s)
                {
                    Console.WriteLine(s);

                    fileInf.CopyTo(prefPath + @"SSLFiles\" + fileInf.Name, true);
                }
            }

            DirectoryInfo dirInfo = new DirectoryInfo(prefPath + @"SSLInspect");
            dirInfo.Delete(true);
            Directory.Move(prefPath + @"SSLFiles", prefPath + @"SSLInspect\");
        }

        public void Task_3()
        {
            string prefPath = @"";
            string startPath = prefPath + @"SSLInspect";
            string zipPath = prefPath + @"SSLFiles.zip";
            string extractPath = prefPath + @"result";

            ZipFile.CreateFromDirectory(startPath, zipPath);
        }
    }
}
