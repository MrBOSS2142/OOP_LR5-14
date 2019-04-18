using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string ExpirationDate { get; set; }
        public Product()
        {

        }
        public Product(string name, double cost, string expirationDate)
        {
            Name = name;
            Cost = cost;
            ExpirationDate = expirationDate;
        }

        public virtual void GetExpirationDate()
        {
            Console.WriteLine("Срок годности " + ExpirationDate + " месяца(ев)");
        }
    }
}
