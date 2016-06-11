using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Osoba
    {
        private String ime;

        public String Ime 
        {
            get { return ime; }
            set { ime = value; }
        }

        private String prezime;

        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public Osoba()
        {
            ime = "";
        }

        public Osoba(String ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        public string DajPodatke()
        {


            return string.Format("Ime:{0} Prezime:{1}", ime, prezime);

        }
    }
}
