using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_s_bojovnikama
{
    class Bojovnik
    {
        /// <summary>
        /// Jméno bojovníka
        /// </summary>
        private string jmeno;
        /// <summary>
        /// Život v HP
        /// </summary>
        private int zivot;
        /// <summary>
        /// Maximální zdraví
        /// </summary>
        private int maxZivot;
        /// <summary>
        /// Útok v HP
        /// </summary>
        private int utok;
        /// <summary>
        /// Obrana v HP
        /// </summary>
        private int obrana;
        /// <summary>
        /// Instance hrací kostky
        /// </summary>
        private Kostka kostka;

        private string zprava;

        public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kostka = kostka;
        }

        public override string ToString()
        {
 	        return jmeno;
        }
        
        public bool Nazivu()
        {
            if (zivot > 0)
                return true;
            else
                return false;
        }

        public void Utoc(Bojovnik souper)
        {
            int uder = utok + kostka.hod();
            NastavZpravu(String.Format("{0} útočí s úderem za {1} hp", jmeno, uder));
            souper.BranSe(uder);
        }

        public string GrafickyZivot()
        {
            string s = "[";
            int celkem = 20;
            double pocet = Math.Round(((double)zivot / maxZivot) * celkem);
            if ((pocet == 0) && (Nazivu()))
                pocet = 1;
            for (int i = 0; i < pocet; i++)
                s += "#";
            s = s.PadRight(celkem + 1);
            s += "] " + zivot + " hp / " + maxZivot + " hp";
            return s;
        }

            
        private void NastavZpravu(string zprava)
        {
            this.zprava = zprava;
        }

        public string VratPosledniZpravu()
        {
            return zprava;
        }

        public void BranSe(int uder)
        {
            int zraneni = uder - (obrana + kostka.hod());
            if (zraneni > 0)
            {
                zivot -= zraneni;
                zprava = String.Format("{0} utrpěl poškození {1} hp", jmeno, zraneni);
                if (zivot <= 0)
                {
                    zivot = 0;
                    zprava += " a zemřel";
                }

            }
            else
                zprava = String.Format("{0} odrazil útok", jmeno);
            NastavZpravu(zprava);
        }

        
    }
}

