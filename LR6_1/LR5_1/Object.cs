using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    enum Date { Spring=1, Summer, Autumn, Winter };

    public struct Per
    {
       public int weather;
    }

    partial class Controller
    {
        public void PriceAll(Transport_agency obj)
        {
            int priceall = 0;
            for (int i = 0; i < obj.GetPrice.Count; i++)
            {
                priceall = priceall + obj.GetPrice[i];
            }
            Console.WriteLine("Цена всех автоммобилей: " + priceall + "$");
        }
    }
}
