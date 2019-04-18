using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {

        static void Main(string[] args)
        {
            
            List<string> list1 = new List<string>();
            list1.Add("serg");
            list1.Add("sergfg");
            list1.Add("sergqqqqqqqq");
            list1.Add("sergffffffffffff");
            list1.Add("sergfffffffffffffffff");
            list1.Add("sergvvvvvvvvvvvvvvvvv");
            Console.WriteLine("Our List:");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Programmist programmist = new Programmist(list1);
            programmist.Removed +=Show_List;
            programmist.Remove(list1);


            programmist.Mutated += (list, message) => {
                Console.WriteLine(message);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            };
            programmist.Mutate(list1);

            WorksWithStrings str = new WorksWithStrings();
            string string1 = "  /+hello WorLd//.";
            str.Trimed += Show_string;
            str.Trims(string1);

            str.Uppercase += Show;
            str.Uppercased(string1);

        }



        private static void Show_List(List<string> list, string message)
        {

            Console.WriteLine(message);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static string Show_string(string stre)
        {
            Console.WriteLine(stre);
            return stre;

        }
        private static void Show(string stre)
        {
            Console.WriteLine(stre);
        }
    }
}
