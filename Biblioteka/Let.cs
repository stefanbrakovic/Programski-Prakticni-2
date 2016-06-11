using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Let
    {
        private String relacija;
        private DateTime datum;
        private LinkedList<Putnik> spisakPutnika;

        public LinkedList<Putnik> SpisakPutnika
        {
            get { return spisakPutnika; }
            set { spisakPutnika = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }


        public String Relacija
        {
            get { return relacija; }
            set { relacija = value; }
        }

        public Let()
        {
            relacija = "";
            datum = DateTime.Today;
            spisakPutnika = new LinkedList<Putnik>();
        }

        public Let(string relacija, DateTime datum, LinkedList<Putnik> spisakPutnika)
        {
            this.relacija = relacija;
            this.datum = datum;
            this.spisakPutnika = spisakPutnika;
        }

        public string DajPOdatke()
        {
            char prvi=' ';
            char poslednji=' ';

            char[] samoglasnici = { 'A', 'E', 'I', 'O', 'U' };
            foreach (char slovo in relacija.ToUpper().ToCharArray())
            {
                if (slovo != 'A' && slovo != 'E' && slovo != 'I' && slovo != 'O' && slovo != 'U')
                {
                    prvi = slovo;
                    break;
                }
            }
            foreach (char slovo in relacija.ToUpper().ToCharArray())
            {
                if (slovo != 'A' && slovo != 'E' && slovo != 'I' && slovo != 'O' && slovo != 'U')
                {
                    poslednji = slovo;
                }
            }
            string inicijali = prvi.ToString() + poslednji.ToString();

            return string.Format("Datum {0}, inicijali {1}", datum, inicijali);
        }

    }
}