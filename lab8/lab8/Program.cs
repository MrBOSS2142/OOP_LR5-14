using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStack<int> k = new GetStack<int>();
            GetStack<string> k1 = new GetStack<string>();

            Console.WriteLine("--First stack");
            k.Add(7); 
            k.Add(3);
            k.Add(2);
            k.Add(1);
            k.Show();
            Console.WriteLine("--After del");
            k.Del();
            k.Show();
            Console.WriteLine("--Second stack");
            
            k1.Add("blue");
            k1.Add("red");
            k1.Add("green");
            k1.Add("orange");
            k1.Show();
            Console.WriteLine("--After del2");
            k1.Del();
            k1.Show();
            k.WriteFile();
            k.Read();
        }
    }
}
