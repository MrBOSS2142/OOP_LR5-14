using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace Lab_14
{
    [Serializable]
    public class Clock : Product
    {
        [DataMember]
        public string ClockName { get; set; }
        public Clock()
        {
        }

        public Clock(string name, string clockName, double cost, string expirationDate)
            : base(name, cost, expirationDate)
        {
            ClockName = clockName;
        }

        public void GetClockName()
        {
            Console.WriteLine("Марка часов - " + ClockName);
        }

        public override void GetExpirationDate()
        {
            Console.WriteLine("Срок годности не ограничен");
        }
        public override string ToString()
        {
            return String.Format("Тип объекта: {0}", GetType().Name);

        }
    }
}
