using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_1
{
    public partial class Controller//Класс-контроллер
    {
        public void SearchSpeed(Transport_agency obj, int speed1, int speed2)
        {
            for (int i = 0; i < obj.GetSpeed.Count; i++)
            {
                if (obj.GetSpeed[i] >= speed1 && obj.GetSpeed[i] <= speed2)
                {
                    Console.WriteLine(obj.GetList[i] + " " + obj.GetSpeed[i]);
                }
            }
        }
    }
}
