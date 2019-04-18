using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    partial class Rectangle
    {
        private int x;
        private int y;
        private static int numberOfObjects = 0;
        public readonly int ID;

        public int X
        {
            get => x;
            set
            {
                if (X > 0)
                {
                    x = X;
                }
                else
                {
                    Console.WriteLine("Ширина задана неверно.");
                }
            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (Y > 0)
                {
                    y = Y;
                }
                else
                {
                    Console.WriteLine("Высота задана неверно.");
                }
            }
        }

        public static int NumberOfObjects { get => numberOfObjects; set => numberOfObjects = value; }
        public int Area => x * y;
        public int Perimeter => (x * 2) + (y * 2);

        public static void getClassInfo()
        {
            Console.WriteLine($"Из класса Rectangle создано {NumberOfObjects} экземпляров.");
        }

        public void calculatePerimeter(ref int x, ref int y, out int Perimeter)
        {
            Perimeter = (2 * x) + (2 * y);
        }
    }
}