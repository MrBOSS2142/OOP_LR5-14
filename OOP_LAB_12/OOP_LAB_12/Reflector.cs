using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOP_LAB_12
{
   
    public class Reflector<T>
    {
       string str;
        public void Info(T a)
        {
            Type t =a.GetType();
            MemberInfo[] MArr= t.GetMembers();
            
            foreach (object v in MArr)
            {
                Console.WriteLine(v);
                str+=(v.ToString()+ "\r\n");       
            }
        }
        public void INfille()
        {
                string text = str;
                using (FileStream fstream = new FileStream("d:\\Reflector.txt", FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fstream.Write(array, 0, array.Length);
                    Console.WriteLine("\nТекст записан в файл\n");
                }
        }
        public void Method(T a)
        {
            Type t = a.GetType();
            foreach(MethodInfo v in t.GetMethods())
            {
                Console.WriteLine(v);
            }
                 
        }
        public void metdSP(T a)
        {
            Type t = a.GetType();
            foreach (FieldInfo v in t.GetFields())
            {
                Console.WriteLine(v);
            }
            foreach(PropertyInfo v in t.GetProperties())
            {
                Console.WriteLine(v);
            }
        }
        public void interf(T a)
        {
            Type t = a.GetType();
            foreach(System.Type v in t.GetInterfaces())
            {
                Console.WriteLine(v);
            }
        }
        public void parme(T a,string b)
        {
            Type t = a.GetType();
            MethodInfo[] MArr = t.GetMethods();
            
            
            foreach (MethodInfo m in MArr)
            {
                // Вывести параметры методов
                ParameterInfo[] p = m.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    if ((p[i].ParameterType.Name) == b)
                    {
                        Console.WriteLine(m.Name + " (" + p[i].ParameterType.Name + ")");
                    }
                }
            }
        }
    }
}
