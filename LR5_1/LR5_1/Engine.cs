using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    public abstract class Engine
    {
        public int power;

        public Engine(int power)
        {
            this.power = power;
        }

        public override string ToString()
        {
            return string.Format("Engine with power" + power);
        }
    }
}
