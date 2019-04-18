using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    partial class Rectangle
    {
        //Конструкторы
        public Rectangle(int x, int y = 1)
        {
            if (x > 0 && y > 0)
            {
                this.x = x;
                this.y = y;
            }
            NumberOfObjects++;
            ID = GetHashCode();
        }

        static Rectangle()
        {
            Console.WriteLine("Создан первый прямоугольник.");
        }

        private Rectangle() { }

        //Переопределение методов
        public override string ToString()
        {
            return $"Прямоугольник шириной {X} и высотой {Y}";
        }
    }
}