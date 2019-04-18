using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    class Railway_vehicle 
    {
        public int count;

        public Railway_vehicle(int count)
        {
            this.count = count;
        }

        public override string ToString()
        {
            return string.Format("Count of Railway vehicle" + count);
        }
    }
}
