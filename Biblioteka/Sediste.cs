using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
   public enum Klasa
    {
        Ekonomska,
        Biznis
    }
    public class Sediste
    {
        private int broj;
        Klasa klasa;
        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }

        public Sediste()
        {
            broj = 0;
            klasa = Klasa.Biznis;

        }
        public Klasa Klasa { get { return this.klasa; } set { this.klasa = value; } }
        public Sediste(int broj, Klasa klasa)
        {
            this.broj = broj;
            this.klasa = klasa;
        }
    }
}
