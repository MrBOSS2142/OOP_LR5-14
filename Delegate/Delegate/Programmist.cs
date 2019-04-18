//делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы
//invoke нужен для того, чотобы обр к методу через делегат
//event - событие(именнованный делегат)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace Delegate
{
    public class Programmist
    {
        public delegate void ProgrammDelegate(List<string> list, string message);
        public event ProgrammDelegate Removed; //удалить
        public event ProgrammDelegate Mutated; //мутировать
            

        public Programmist(List<string> list)
        {

        }
        public void Remove(List<string> list)
        {
            if (list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
                if (Removed != null)
                    Removed(list, "\nElement of list is removed\n");
            }
            else
            {
                if (Removed != null)
                {
                    Removed(list, "List is empty");
                }
            }
        }
        public void Mutate(List<string> list)
        {
            Random rnd = new Random();


            for (int k = 0; k < list.Count; k++)
            {

                int j = rnd.Next(0, list.Count);
                list[k] = list[j];
            }
            if (Mutated != null)
            {
                Mutated(list, "\nElement of list is mutated\n");
            }
            else
            {
                if (Mutated != null)
                {
                    Mutated(list, "List is empty");
                }
            }
        }
    }
}
