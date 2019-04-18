using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    public class Transport_agency//класс-Контейнер
    {
        public static int count = 0;
        public List<int> price = new List<int>();
        public List<string> list = new List<string>();
        public List<int> fuel_consumption = new List<int>();
        public List<int> speed = new List<int>();

        public List<string> GetList
        {
            get
            {
                return this.list;
            }
            set
            {
                this.list = value;
            }
        }

        public List<int> GetPrice
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public List<int> GetFuel
        {
            get
            {
                return this.fuel_consumption;
            }
            set
            {
                this.fuel_consumption = value;
            }
        }

        public List<int> GetSpeed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public void Add(string name, int price, int fuel_consumption, int speed)
        {
            list.Add(name);
            this.price.Add(price);
            this.fuel_consumption.Add(fuel_consumption);
            this.speed.Add(speed);
            count++;
        }

        public void Delete(string obj)
        {
            int count = list.IndexOf(obj);
            list.Remove(obj);
            price.RemoveAt(count);
            fuel_consumption.RemoveAt(count);
            speed.RemoveAt(count);
            count--;
        }

        public void Print()
        {
            int i = 0;
            foreach (string item in this.list)
            {
                Console.WriteLine("Name: " + list[i]);
                Console.WriteLine("Price: " + price[i]);
                Console.WriteLine("Fuel consumption: " + this.fuel_consumption[i]);
                Console.WriteLine("Speed: " + speed[i]);
                i++;
                Console.WriteLine("-------------------");
            }
        }

        public void Sort()
        {
            fuel_consumption.Sort();

            int i = 0;
            foreach (string item in list)
            {
                Console.WriteLine("Fuel consumption: " + fuel_consumption[i]);
                i++;
            }
        }
    }
}
