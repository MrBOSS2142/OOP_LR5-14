using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP_LAB_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Reflector<Game> a1 = new Reflector<Game>();
            Game z = new Game("Персонаж 1");
            a1.Info(z);
            a1.INfille();
            //2
            Reflector<Game> a2 = new Reflector<Game>();
            Game z1 = new Game("Персонаж 2");
            a2.Method(z1);
            //3
            Reflector<Game> a3 = new Reflector<Game>();
            Game z2 = new Game("Персонаж 3");
            a3.metdSP(z2);
            //4
            Reflector<Game> a4 = new Reflector<Game>();
            Game z3 = new Game("Персонаж 4");
            a4.interf(z3);
            //5
            Reflector<Game> a5 = new Reflector<Game>();
            Game z4 = new Game("Персонаж 5");
            a5.parme(z4, "Int32");
           
        }
    }
}
