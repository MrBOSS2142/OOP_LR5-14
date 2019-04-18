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
    class SSLLog
    {
        public static DateTime now = DateTime.Now;
        public delegate void del(string m, string path);
        public event del EventIO;
        public string path = @"SSLlogfile.txt";

        public void Write(string[] s)
        {
            string buf = "";
            using (StreamWriter file_w = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                foreach (string str in s)
                {
                    file_w.WriteLine(str);
                }
                file_w.Close();
            }
            Type type = typeof(SSLLog);
            foreach (MethodInfo m in type.GetMethods())
            {
                if (m.Name == "Write")
                {
                    buf = m.Name;
                }
            }
            EventIO(buf, path);
        }


        public void Read(string path)
        {
            string buf = "";
            Type type = typeof(SSLLog);
            foreach (MethodInfo meth in type.GetMethods())
            {
                if (meth.Name == "Read")
                {
                    buf = meth.Name;
                }
            }
            EventIO(buf, path);
            using (StreamReader file_r = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = file_r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                file_r.Close();

            }
        }


        public void Search(string search)
        {
            using (StreamReader file_r = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = file_r.ReadLine()) != null)
                {
                    if (line == search)
                    {

                        Console.WriteLine("Найдено совпадение " + line);
                        Console.WriteLine(file_r.ReadLine());

                    }
                }
                file_r.Close();

            }

        }

        public static void OnEvent(string m, string path)
        {
            using (StreamWriter file_w = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                file_w.WriteLine("Пользователь вызвал метод: " + m);
                file_w.WriteLine("Время: " + now);
            }
        }
    }
}
