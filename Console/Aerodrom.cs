using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;

namespace Console
{
    
   public class Aerodrom
    {

        // TODO nisu uradjeni delegati!!! 
        public delegate void  dodatBiznis();
        public dodatBiznis DodatBiznisPutnikPovecajBroj = null;

        public String Naziv;
        public LinkedList<Let> SpisakLetova;
        public int BrojPutnika;

        public Aerodrom()
        {
            Naziv = "";
            SpisakLetova = new LinkedList<Let>();
            BrojPutnika = 0;
        }
        public Aerodrom(string Naziv,LinkedList<Let> SpisakLetova,int BrojPutnika)
        {
            this.Naziv = Naziv;
            this.BrojPutnika = BrojPutnika;
            this.SpisakLetova = SpisakLetova;
        }
        public string DajPodatke()
        {

            //moglo je sve da se strpa u jedan loop kasno sam video...-.-'
            BrojPutnika = 0;
            foreach (Let l in SpisakLetova)
            {
                foreach (Putnik p  in l.SpisakPutnika)
                {
                    BrojPutnika++;
                }
            }
            string info = "";
            info = string.Format("{0}, {1} \n\t", Naziv, BrojPutnika);

            foreach (Let l in SpisakLetova)
            {
                info += string.Format("{0}. let \n\t\t", l.DajPOdatke());

                foreach (Putnik p in l.SpisakPutnika)
                {
                    if (p.Sediste.Klasa == Klasa.Biznis)
                    {
                        info += string.Format("Putnik {0} na {1} u biznis klasi \n\t\t", p.DajPodatke(), l.Relacija);
                    }
                    
                } 
            }

            return info;

        }
        
        public Putnik UcitajPutnika()
        {
            Klasa klasa;

            System.Console.WriteLine("Uneti ime putnika:");
            string ime = System.Console.ReadLine();
            System.Console.WriteLine("Uneti prezime putnika:");
            string prezime = System.Console.ReadLine();
            int broj = 0;
            do
            {
                System.Console.WriteLine("Uneti broj sedista:");
           
            } while (!Int32.TryParse(System.Console.ReadLine(),out broj));


            int brojK;
            do
            {
                System.Console.WriteLine("Uneti broj klase: 0 za Ekonomska, 1 za Biznis:");

            } while (!Int32.TryParse(System.Console.ReadLine(), out brojK)&&(brojK!=1 || brojK!=0));

            if (brojK == 0)
            {
                klasa = Klasa.Ekonomska;

            }
            else
            {
                klasa = Klasa.Biznis;
            }

            Putnik putnik = new Putnik(ime, prezime, new Sediste(broj, klasa));

            return putnik;
        }


        public Let UcitajLet()
        {
            Let let = new Let();



            //naveli su da mora da bude u obliku odrediste - destinacija pa sad neznam da li treba da se to odvaja
            //jer u klasi Let imam samo relaciju...
            System.Console.WriteLine("Uneti relaciju leta:");
            string relacija = System.Console.ReadLine();
            let.Relacija = relacija;

            System.Console.WriteLine("Ucitaj datum");
            DateTime datum = DateTime.Now;
            let.Datum = datum;

            while(true)
            {
                System.Console.WriteLine("Ucitati putnika? y/n");
                string odgovor = System.Console.ReadLine();
                if (odgovor=="y")
                {
                    Putnik p  = UcitajPutnika();
                    let.DodajPutnika(p);              
                }
                if(odgovor=="n")
                {
                    break;
                }

            }

           
            return let;
        }

        static void Main(string[] args)
        {
            Aerodrom a1 = new Aerodrom();
            System.Console.WriteLine("Uneti naziv aerodroma");
            a1.Naziv = System.Console.ReadLine();

            a1.SpisakLetova.AddLast(a1.UcitajLet());
            a1.SpisakLetova.AddLast(a1.UcitajLet());
            System.Console.WriteLine(a1.DajPodatke());
            System.Console.ReadLine();
            System.Console.WriteLine("broj putnika je: "+a1.BrojPutnika);




        }


    }
}
