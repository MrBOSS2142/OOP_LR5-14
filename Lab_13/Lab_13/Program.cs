using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Reflection;


//SSL - Sukharevich Sergey Leonidovich
namespace Lab_13
{
    class Program
    { 
        static void Main(string[] args)
        {
            string buf = "";
            SSLLog sslLog = new SSLLog();

            sslLog.EventIO += SSLLog.OnEvent;

            sslLog.Write(
                new string[] {
                    "123456789",
                    "qwertyuiopasdfhjklzxcvbnm",
                    "Sergey2142",
                    "HeHeHeHe"
                }
            );
            Console.WriteLine("\nПострочный вывод из файла: " + sslLog.path + "\n");
            sslLog.Read(sslLog.path);
            Console.WriteLine("Введите строку для поиска");
            buf = Console.ReadLine();
            Console.WriteLine("Поиск по строке");
            sslLog.Search(buf);
            Console.WriteLine("-------------------------------------------------------------\n");

            SSLDiskInfo info = new SSLDiskInfo();
            info.InfoOfDrivers();

            SSLFileInfo fileInfo = new SSLFileInfo();
            fileInfo.InfoOfFiles(sslLog.path);

            SSLFileManager manager = new SSLFileManager();

            manager.ListOfFiles();
            manager.Task_1();

            manager.Task_2(@"D:\", "txt");

            manager.Task_3();
            Console.ReadLine();
        }
    }
}