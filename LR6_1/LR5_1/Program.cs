using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //======================================================
            //LR6
            Console.WriteLine("\n_______LR6______________\n");


            Per obj;
            obj.weather = (int)Date.Summer;
            Console.WriteLine("Struct - " + obj.weather);
            Console.WriteLine("=====================");
            Console.WriteLine();

            Transport_agency tran = new Transport_agency();
            tran.Add("Mazda", 2000, 4, 300);
            tran.Add("Ford", 1700, 3, 220);
            tran.Add("Volga", 500, 13, 60);
            tran.Add("Audi", 5000, 11, 320);
            tran.Add("Zapr", 500, 8, 20);

            tran.Print();

            Console.WriteLine();
            Console.WriteLine();

            Controller contr = new Controller();
            Console.Write("Введите первую скорость ");
            int speed1 = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую скорость ");
            int speed2 = int.Parse(Console.ReadLine());

            contr.SearchSpeed( tran, speed1, speed2);

            Console.WriteLine("\n________________________________");
            contr.PriceAll(tran);

            Console.WriteLine();
            Console.WriteLine();

            tran.Sort();

            //======================================================
            //LR7

            Console.WriteLine("\n_______LR7______________\n");


            try
            {
                int a = 7, b = 0;
                int c = a / b;
            }
            catch (Exception s)
            {
                Console.WriteLine(s.Message + " Time: " + DateTime.Now);
            }

            try
            {
                int[] Arr = new int[4];

                Arr[5] = 7; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Time: " + DateTime.Now);
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }


            try
            {
                string g = null;
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message + " Time: " + DateTime.Now);
            }

            try
            {
                string message = "QWERTYUI";
                if (message.Length > 6)
                {
                    throw new Exception("Длина строки больше 6 символов");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Time: " + DateTime.Now);
            }


            try
            {
                int c = 11;
                if (c > 8 && c < 10)
                    Console.WriteLine(c);
                else
                    throw new Error(2142);
            }
            catch (Error a)
            {
                Console.WriteLine(a.Message + " Time :" + DateTime.Now);
            }

            try
            {
                throw new Error("Bad situation");
            }
            catch (Error a)
            {
                Console.WriteLine(a.Message + " Time :" + DateTime.Now);
            }


            bool k = true;
            Debug.Assert(k = false, "ERROR");

            Console.ReadLine();
        }
    }
}
