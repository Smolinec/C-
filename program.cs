using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_s_bojovnikama
{
    class Program
    {

        public int maxZivotHrac1;
        public int maxZivotHrac2;

        static void Main(string[] args)
        {
            
            Zivot1();
            Zivot2();
            
            

            // vytvoření objektů
            Kostka kostka = new Kostka(10);
            Bojovnik zalgoren = new Bojovnik("Zalgoren", maxZivotHrac1, 20, 10, kostka);
            Bojovnik shadow = new Bojovnik("Shadow", maxZivotHrac2, 18, 15, kostka);
            Arena arena = new Arena(zalgoren, shadow, kostka);
            // zápas
            arena.Zapas();
            Console.ReadKey();

            public void Zivot1()
            {
                Kostka zivot1 = new Kostka(100);
                zivot1 = maxZivotHrac1;
            }
        }
    }
}
