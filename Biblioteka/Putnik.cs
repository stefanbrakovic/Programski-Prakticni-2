using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Putnik : Osoba
    {
        private int sediste;

        public int Sediste
        {
            get { return sediste; }
            set { sediste = value; }
        }

        public Putnik()
        {
            sediste = 0;
        }

        public Putnik(string ime, string prezime, int sediste) : base(ime, prezime)
        {
            this.sediste = sediste;
        }

        new public string DajPodatke()
        {
            return string.Format("Broj sedista : {0} {1}", sediste, base.DajPodatke());
        }
    }
}