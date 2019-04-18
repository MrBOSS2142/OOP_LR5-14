using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train(5, "gray");
            Car car = new Car(5, "Mazda x6");
            Express express = new Express(20, 300);
            Vehicle vehicle = new Vehicle(20, "Normandy", 6);


            car.Open();
            ISopen _car = new Car(5, "Mazda x6"); ;
            _car.Open();

            Console.WriteLine(train.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine(express.ToString());
            Console.WriteLine(vehicle.ToString());

            if (car is ISopen)
            {
                car.Open();
            }

            List<Engine> landlist = new List<Engine>();
            landlist.Add(car);
            landlist.Add(vehicle);
            //landlist.Add(island);

            Console.ReadLine();
        }
    }
}
