using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Collections10
{
    class Program
    {
        static void ShowColl(SortedSet<float> ss, string s)
        {
            Console.WriteLine(s);
            foreach (float ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");

        }
        private static void CollectionChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Goods newGoods = e.NewItems[0] as Goods;
                    Console.WriteLine("Добавлен новый объект: {0}", newGoods.Name);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Goods oldGoods = e.OldItems[0] as Goods;
                    Console.WriteLine("Удален объект: {0}", oldGoods.Name);
                    break;

            }
        }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Random rand = new Random();
            Console.WriteLine("Original List");
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(100));
            }

            list.AddRange(new string[] { "string", "string1" });
            foreach (object i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("List after Delite <string>");
            list.Remove("string");
            foreach (object i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("List after Delite Last Element");
            list.RemoveAt(list.Count - 1);
            foreach (object i in list)
            {
                Console.WriteLine(i);
            }

            Console.Write("Eneter Element,which you want Search:");
            object deliteElement = Int32.Parse(Console.ReadLine());
            if (list.IndexOf(deliteElement) == -1)
            {
                Console.WriteLine(list.IndexOf("Not Found"));
            }
            else
            {
                Console.Write("Your Element Is Found:");
                Console.WriteLine(list[list.IndexOf(deliteElement)]);
                Console.Write("Index of Element:");
                Console.WriteLine(list.IndexOf(deliteElement));

            }
            SortedSet<float> sortedSet = new SortedSet<float>() { 0.1F, 15.96F, -0.3F, -19.6F };
            sortedSet.Add(-5.2F);
            sortedSet.Add(5.2F);
            sortedSet.Add(5.3F);

            ShowColl(sortedSet, " SortedSet Collection");
            sortedSet.Remove(0.1F);
            sortedSet.RemoveWhere(x => x > 0);
            ShowColl(sortedSet, "Remove few elements in SortSet");

            Queue<float> queue = new Queue<float>();
            foreach (float f in sortedSet)
            {
                queue.Enqueue(f);
            }
            Console.WriteLine("Queue Collection");
            foreach (float f in queue)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            Console.Write("Eneter Element,which you want Search:");
            float searchElementOfQueue = Convert.ToSingle(Console.ReadLine());
            bool isFound = false;
            foreach (float f in queue)
            {
                if (f == searchElementOfQueue)
                {
                    isFound = true;
                    Console.WriteLine("Element {0} is Found", searchElementOfQueue);

                }
            }

            if (isFound == false)
            {
                Console.WriteLine("Element {0} isn't Found", searchElementOfQueue);
            }

            Console.WriteLine();
            Console.WriteLine("_______Nubmer 3_______");
            Console.WriteLine("SortedSet with Class <Goods>");
            SortedSet<Goods> sortedSet1 = new SortedSet<Goods>();
            sortedSet1.Add(new Goods("Case", 15));
            sortedSet1.Add(new Goods("Clock", 10));
            sortedSet1.Add(new Goods("Cake", 40));
            sortedSet1.Add(new Goods("Cake", 40));

            foreach (Goods item in sortedSet1)
            {
                Console.WriteLine(item.Name + " " + item.Cost);

            }
            Console.WriteLine("  ");
            Console.WriteLine("Queue with Class <Goods>");
            Queue<Goods> queue1 = new Queue<Goods>();

            foreach (Goods item in sortedSet1)
            {
                queue1.Enqueue(item);
            }

            foreach (Goods item in queue1)
            {
                Console.WriteLine(item.Name + " " + item.Cost);
            }

            Console.WriteLine("_______Nubmer 4_______");
            ObservableCollection<Goods> goods = new ObservableCollection<Goods>
            {
                new Goods{Name = "flowers",Cost = 55},
                 new Goods{Name = "Book",Cost = 55}
            };
            Console.WriteLine("ObservableCollection Before Event");
            foreach (Goods item in goods)
            {
                Console.WriteLine(item.Name + " " + item.Cost);
            }
            goods.CollectionChanged += CollectionChange;
            goods.Add(new Goods { Name = "clock", Cost = 8 });
            goods.RemoveAt(0);
            Console.WriteLine("ObservableCollection After Event");
            foreach (Goods item in goods)
            {
                Console.WriteLine(item.Name + " " + item.Cost);
            }

        }
    }
}
