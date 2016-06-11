using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
namespace Console
{
    class Aerodrom
    {
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





        static void Main(string[] args)
        {
        }


    }
}
