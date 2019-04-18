using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
   sealed  class Train : Railway_vehicle
    {
        public string color;
        public Train(int count, string color):base(count)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return string.Format("Train with color " + color + " and count of railway vehicle " + count);
        }
    }
}
