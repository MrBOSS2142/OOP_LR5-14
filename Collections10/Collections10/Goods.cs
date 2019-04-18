using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections10
{
    public class Goods : IComparable<Goods>
    {
        public double Cost { get; set; }
        public string Name { get; set; }


        public Goods() { }
        public Goods(string name, double cost)
        {
            this.Cost = cost;
            this.Name = name;
        }
        public int CompareTo(Goods obj)
        {
            if (this.Cost > obj.Cost)
            {
                return -1;
            }
            if (this.Cost < obj.Cost)
            {
                return 1;
            }
            return 0;
        }

    }
}

