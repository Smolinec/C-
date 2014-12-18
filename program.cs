using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_s_bojovnikama
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int maxZivotHrac1;
            int maxZivotHrac2;
            
            Random kostka1 = new Random();
            maxZivotHrac1 = kostka1.Next(50, 100);

            maxZivotHrac2 = kostka1.Next(50, 100);
            
            

            // vytvoření objektů
            Kostka kostka = new Kostka(10);
            Bojovnik zalgoren = new Bojovnik("Zalgoren", maxZivotHrac1, 20, 10, kostka);
            Bojovnik shadow = new Bojovnik("Shadow", maxZivotHrac2, 18, 15, kostka);
            Arena arena = new Arena(zalgoren, shadow, kostka);
            // zápas
            arena.Zapas();
            Console.ReadKey();

            
        }
    }
}
