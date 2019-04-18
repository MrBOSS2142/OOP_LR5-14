using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    class Vehicle : Car
    {
        public int size;
        public Vehicle(int power,  string name, int size):base(power, name)
        {
            this.size = size;
        }

        public override string ToString()
        {
            return string.Format("Vehicle with name " + name + ", power " + power + " and size " + size);
        }
    }
}
