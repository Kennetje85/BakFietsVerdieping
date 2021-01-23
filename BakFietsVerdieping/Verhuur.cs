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
        public int aantaldagen;
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
        public int Aantaldagen
        {
            set { aantaldagen = value; }
            get { return aantaldagen; }

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

        public verhuur()
        {

        }

    }
}
