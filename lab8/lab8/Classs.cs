using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8
{
    class GetStack<T> : Stack<T>, INterface<T>// Stack<T> Представляет коллекцию переменного размера экземпляров одинакового заданного типа (LIFO)
    {
        public static int count = 0;
        public Stack<T> myStack = new Stack<T>();

        public class Z<T> where T : GetStack<T>, new() { }

        public void Add(T a)
        {
            myStack.Push(a);
        }

        public void Del()
        {
            myStack.Pop();//удалить последний доб-й эл-т

        }

        public void Show()
        {
            try
            {
                foreach (var n in myStack)
                {
                    Console.WriteLine(n);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error" + e);
            }
            finally
            {
                Console.WriteLine("**FINALLY**");
            }
        }

        public void WriteFile()
        {
            foreach (var k in myStack)
            {
                File.AppendAllText("D:\\test.txt", Convert.ToString(k) + " ");//Добавляет указанную строку в файл, создавая файл, если он не существует.
            }
        }

        public void Read()

        {
            FileStream s = new FileStream("D:\\test.txt", FileMode.Open);
            StreamReader read = new StreamReader(s);
            Console.WriteLine(read.ReadToEnd());
            read.Close();
            Console.ReadLine();
        }
        
    }
}
