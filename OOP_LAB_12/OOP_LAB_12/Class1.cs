using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_12
{
        public delegate int Liambd(ref int a, int b);
        public delegate void G();

    interface INterf
    {
        int Fun();
    }

    class Game:INterf
    {
        static int a = 104;
        string Name;
        int head = 9787;
        int body = 9660;
        int simvol_serdce = 9829;
        int foot = 9576;
        public static int healthpoint = 0;
        public static int hp = 0;
        void f(int a)
        {
            Console.WriteLine("a");
        }
        public virtual int Fun()
            {

            return 0;
            }
        public int sv
        {
            get;
            set;
        }
            public Game(string Name)
            {
                this.Name = Name;
                healthpoint = 175;
                hp = 7;
            }

            public int damage = 25;
            public int health = 25;
            public event G Atack;
            public event G Лечить;
            public void SobtieA()
            {
                Console.WriteLine("Атака");
                if (Atack != null)
                {
                    Atack();
                }
            }
            public void SobtieL()
            {
                Console.WriteLine("Лечить");
                if (Atack != null)
                {
                    Лечить();
                }
            }
            public void info()
            {
                Console.Write(Name + " :");

                if (hp <= 0)
                {
                    Console.WriteLine("статус:мёртв.");
                }

                Console.WriteLine($"Здоровье : {healthpoint} %");
                if (hp > 0)
                {
                    Console.WriteLine("статус: жив.");
                    for (int i = 0; i < hp; i++)
                    {
                        Console.Write((char)simvol_serdce);
                    }
                }


                Console.WriteLine();
                Console.WriteLine("   " + (char)head);
                Console.WriteLine("  -" + (char)body + "-");
                Console.WriteLine("   " + (char)foot);
            }
        }
        class nablud : Game
        {

            public nablud() : base("")
            {

            }
            public delegate int Лямда_выражения(ref int a, ref int b);
            public delegate int Лямда_выражения1(ref int v);
            Лямда_выражения obr_sobA = (ref int a, ref int b) => (a -= b);
            Лямда_выражения1 obr_sobsizeA = (ref int size) => (size--);
            public void onSobitieA()
            {
                Console.WriteLine("Атакую");
                //healthpoint -= damage;
                obr_sobA(ref healthpoint, ref damage);
                //размер_здоровью -= 1;
                obr_sobsizeA(ref hp);
            }
            Лямда_выражения obr_sobL = (ref int a, ref int b) => (a += b);
            Лямда_выражения1 obr_sobsizeL = (ref int size) => (size++);
            public void onSobitieL()
            {
                if (healthpoint < 175 && healthpoint > 0)
                {
                    Console.WriteLine("Лечение");
                    obr_sobsizeL(ref hp);
                    obr_sobL(ref healthpoint, ref health);
                }
                if (healthpoint >= 175)
                {

                    Console.WriteLine("Лечение не возможно здоровье полное.");
                }
                if (healthpoint <= 0)
                {
                    Console.WriteLine("Персонаж мёртв.");
                }
            }
        }
    
}
