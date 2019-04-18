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
    class SSLFileInfo
    {
        public void InfoOfFiles(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            if (!fileInf.Exists) return;
            Console.WriteLine("Имя файла: {0}", fileInf.Name);
            Console.WriteLine("Путь : {0}", fileInf.FullName);
            Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
            Console.WriteLine("Размер: " + fileInf.Length + " байт");
        }
    }
}
