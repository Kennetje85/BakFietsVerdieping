using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakFietsVerdieping
{

    public class klant1
    {
        private int klantnummer;
        private string naam;
        private string voornaam;
        private string postcode;
        private int huisnummer;
        private string huisnummer_toevoeging;
        private string opmerkingen;

        public int Klantnummer
        {
            set { klantnummer = value; }
            get { return klantnummer; }
        }

        public string Naam
        {
            set { naam = value; }
            get { return naam; }
        }
        public string Voornaam
        {
            set { voornaam = value; }
            get { return voornaam; }
        }
        public string Postcode
        {
            set { postcode = value; }
            get { return postcode; }
        }

        public int Huisnummer
        {
            set { huisnummer = value; }
            get { return huisnummer; }
        }

        public string Huisnummer_toevoeging
        {
            set { huisnummer_toevoeging = value; }
            get { return huisnummer_toevoeging; }
        }

        public string Opmerkingen
        {
            set { opmerkingen = value; }
            get { return opmerkingen; }
        }

        public klant1(int klantnummer,string naam, string voornaam,string postcode, int huisnummer,string huisnummer_toevoeging, string opmerkingen)
        {

            this.klantnummer = klantnummer;
            this.naam = naam;
            this.voornaam = voornaam;
            this.postcode = postcode;
            this.huisnummer = huisnummer;
            this.huisnummer_toevoeging = huisnummer_toevoeging;
            this.opmerkingen = opmerkingen;

        }
    }
}