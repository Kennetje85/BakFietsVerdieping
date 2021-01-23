using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakFietsVerdieping
{
    class verhuur
    {
        private int verhuurnummer;
        public string verhuurdatum;
        public int bakfietsnummer;
        public int aantal_dagen;
        public decimal huurprijstotaal;
        public int klantnummer;
        public int verhuurder;


        public int Verhuurnummer
        {
            set { verhuurnummer = value; }
            get { return verhuurnummer; }

        }
        public string Verhuurdatum
        {
            set { verhuurdatum = value; }
            get { return verhuurdatum; }

        }

        public int Bakfietsnummer
        {
            set { bakfietsnummer = value; }
            get { return bakfietsnummer; }

        }
        public int Aantal_dagen
        {
            set { aantal_dagen = value; }
            get { return aantal_dagen; }

        }

        public decimal Huurprijstotaal
        {
            set { huurprijstotaal = value; }
            get { return huurprijstotaal; }

        }
        public int Klantnummer
        {
            set { klantnummer = value; }
            get { return klantnummer; }

        }
        public int Verhuurder
        {
            set { verhuurder = value; }
            get { return verhuurder; }

        }

        public verhuur(int verhuurnummer,string verhuurdatum,int bakfietsnummer,int aantal_dagen,decimal huurprijstotaal,int klantnummer, int verhuurder)
        {
            this.verhuurnummer = verhuurnummer;
            this.verhuurdatum = verhuurdatum;
            this.bakfietsnummer = bakfietsnummer;
            this.aantal_dagen = aantal_dagen;
            this.huurprijstotaal = huurprijstotaal;
            this.klantnummer = klantnummer;
            this.verhuurder = verhuurder;

        }

    }
}
