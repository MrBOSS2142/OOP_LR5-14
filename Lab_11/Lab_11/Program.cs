using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static string[] months = new string[] { "January", "February", "March", "April", "May",
         "June", "July", "August", "September", "October", "November", "December" };

        static void Main(string[] args)
        {
            #region Task 1
            //С помощью LINQ вывести месяцы длиной строки n

            Console.WriteLine("Введите длину строки:");
            var input = Console.ReadLine();
            var n = Convert.ToInt32(input);

            var monthsByLength =
                from month in months
                where month.Length == n
                select month;

            foreach (var item in monthsByLength)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");

            //Вывести летние и зимние месяцы

            var summerWinterMonths =
                from month in months
                where month == "December" || month == "January" || month == "February"
                || month == "June" || month == "July" || month == "August"
                select month;

            Console.WriteLine("\nЛето и зима когда:");

            foreach (var item in summerWinterMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");

            //Вывести в алфавитном порядке

            var monthsByAlphabet =
                from month in months
                orderby month
                select month;

            Console.WriteLine("\nМесяцы в алфавитном порядке:");
            foreach (var item in monthsByAlphabet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");

            //Вывести содержащие букву "u" и длиной имени не менее 4-х символов

            var month_with_u =
                from month in months
                where month.Contains("u") &&
                      month.Length >= 4
                select month;

            Console.WriteLine("\nСодержащие \"u\" и не короче 4-х символов:");
            foreach (var item in month_with_u)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------");
            #endregion

            #region Task 2 - 3


            List<Rectangle> quads = new List<Rectangle>
            {
                new Rectangle(10, 10),
                new Rectangle(20, 20),
                new Rectangle(5, 20),
                new Rectangle(100, 34)
            };

            var squares =
                from rect in quads
                where rect.X == rect.Y
                select rect;

            var squareMin = squares.Min(r => r.Area);
            var squareMax = squares.Max(r => r.Area);

            var rectangle =
                from rect in quads
                where rect.X != rect.Y
                orderby rect.Perimeter
                select rect;

            var rectangleMin = rectangle.Min(r => r.Area);
            var rectangleMax = rectangle.Max(r => r.Area);

            var smallSquares =
                from square in squares
                where square.X <= 15
                select square;

            Console.WriteLine("\nКоллекция из четырёхугольников:");
            foreach (var item in quads)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nКоллекция прямоугльников:");
            foreach (var item in rectangle)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Самый крупный - {rectangleMax}");
            Console.WriteLine($"Самый мелкий - {rectangleMin}");

            Console.WriteLine("\nКоллекция квадратов:");
            foreach (var item in squares)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Самый крупный - {squareMax}");
            Console.WriteLine($"Самый мелкий - {squareMin}");

            Console.WriteLine("\nКвадраты со стороной не больше 15:");
            foreach (var item in smallSquares)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------\n");

            #endregion


        }
    }
}