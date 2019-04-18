using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    class Express : Railway_vehicle
    {
        public int speed;
        public Express(int count, int speed):base(count)
        {
            this.speed = speed;
        }

        public override string ToString()
        {
            return string.Format("Express with speed " + speed +" and count of railway vehicle " + count);
        }
    }
}
