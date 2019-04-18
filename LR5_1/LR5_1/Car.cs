using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
   class Car : Engine, ISopen
    {
        public string name;
        public Car(int power, string name):base(power)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("Car with name " + name + " and power " + power);
        }

        void ISopen.Open()
        {
            Console.WriteLine("This car have a power(INTERFACE) " + power);
        }

        public void Open()
        {
            Console.WriteLine("This car have a power " + power);
        }
    }
}
