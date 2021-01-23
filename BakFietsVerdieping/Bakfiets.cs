using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakFietsVerdieping
{
    public partial class Bakfiets : Form
    {
        //declareren
        Database db = new Database();

     
        string verhuurdatum = DateTime.Now.ToString("yyyy-MM-dd");
        int Aantaldagen;

        readonly string errorTotalMsg = @" Optie not a number";
        readonly string errorOptionOutOfRange = @"Option needs to be between 1 and 4";
        readonly string errorOngeldigWaarde = @"Ongeldig waarde";
        readonly string BabyStoeltje = @"BabyStoeltje";
        readonly string RegenDak = @"RegenDak";
        readonly string Smartphone = @"Smartphone";
        readonly string Kaarthouder = @"Kaarthouder";
        readonly string Helm = @"Helm";
        readonly string Zonnedak = @"Zonnedak";
        int optionBike;
        List<verhuur> verhuren;
        List<Klant> klanten;
        double[] AccesoiresPrice = new double[7]; //array
        decimal[] huurprijs = new decimal[3]; //huurprijs bike
       
        List<Accesoires> checkBoxItems = new List<Accesoires>();
        
        public Bakfiets()
        {
            
            //constructor , heeft dezelfde naam als de klasse (initialiseren)
            InitializeComponent();

            huurprijs[0] = 0;
            huurprijs[1] = 20;
            huurprijs[2] = 40;

            AccesoiresPrice[0] = 0;
            AccesoiresPrice[1] = 2.50; //regendak
            AccesoiresPrice[2] = 2.00; //zonnedak
            AccesoiresPrice[3] = 3.00; //Babystoeltje
            AccesoiresPrice[4] = 1.00; //smarthome hoesje
            AccesoiresPrice[5] = 1.00; //Kaarthouder
            AccesoiresPrice[6] = 1.50; //Helm


        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klant1._klant' table. You can move, or remove it, as needed.
            this.klantTableAdapter.Fill(this.klant1._klant);
            //De TableAdapter is een snelle manier om een DataTable te vullen met gegevens uit een database.
        }

      
        private void KlantAddBtn_Click(object sender, EventArgs e)
        {
                validate();  //functie methode aanroepen
        }

        public void getString(decimal prijs) //argument prijs gegeven om parameter door te geven
        {
            Totaal.Text = string.Format("Totale Kosten met accesoires {0}", prijs);
            
        }

      


        public void showHuidigeHuur(decimal prijs)
        {
           
            Totaal.Text = string.Format("Huidige huurkosten {0}", prijs);
        }

  


        public decimal prijscalculeren()
        {
            decimal result = 0;

            Aantaldagen = Convert.ToInt32(aantaldagen.Value);
            var isValid = Int32.TryParse(selectBikeTxtbox.Text, out optionBike); // fix datatype conversion here

            result = Aantaldagen * huurprijs[optionBike];

            foreach (var item in checkBoxItems)
            {
                result = result + item.Bedrag;
            }

            return result;
        }




        private bool ValidateOption(string value)
        {
            int option;
            //var lol = Int32.TryParse(OptieBikeTxt.Text, out  option);

            try
            {
                option = Convert.ToInt32(selectBikeTxtbox.Text);

                if ((option > 2) || option < 1)
                {
                    Totaal.Text = errorOptionOutOfRange;
                    return false;
                }


            }
            catch
            {
                Totaal.Text = errorTotalMsg;
                return false;
            }
            return true;
        }

        public void validate()
        {

            if (NameTxtbox.Text == "")
            {
                errorProvider1.SetError(NameTxtbox, "Vul u naam in");

            }
            else if (VoornaamTxtBox.Text == "")
            {
                errorProvider2.SetError(VoornaamTxtBox, "Vul u voornaam in");
            }
            else if (PostCodeTxtBox.Text == "")
            {
                errorProvider3.SetError(PostCodeTxtBox, "Vul u postcode in");
            }
            else if (HuisnrTxtBox.Text == "")
            {
                errorProvider4.SetError(HuisnrTxtBox, "Vul u huisnr in");
            } 
            else {

                db.klantToevoegen(NameTxtbox.Text, VoornaamTxtBox.Text, PostCodeTxtBox.Text, HuisnrTxtBox.Text, ToevoegingTxtBox.Text, OpmerkingTxtBox.Text);
                
               
            }


        }

    
        private void selectBikeTxtbox_TextChanged(object sender, EventArgs e)
        {
            //get value
            if (ValidateOption(selectBikeTxtbox.Text))
            {
                showHuidigeHuur(prijscalculeren());
            }
            else
            {
                Totaal.Text = errorOngeldigWaarde;
            }
        }

        private void aantaldagen_ValueChanged(object sender, EventArgs e)
        {
            if (ValidateOption(selectBikeTxtbox.Text))
            {
                showHuidigeHuur(prijscalculeren());
            }
            else
            {
                Totaal.Text = errorOngeldigWaarde;
            }
        }

  

        private void bakfietsverhuren()
        {

           

            if (selectBikeTxtbox.Text == "" || klantnummerTxtbox.Text == "")
            {
                MessageBox.Show("Kies een bike 1 of 2 en vul ook de klantnummer in om te huren");
            }
            else
            {
            //    db.verhuurAccesoiresInsert(Count);
                db.bakfietsHuren(Convert.ToInt32(selectBikeTxtbox.Text), verhuurdatum  , Aantaldagen, prijscalculeren(), Convert.ToInt32(klantnummerTxtbox.Text), Convert.ToInt32(verhuurnrValue.Value));
            
            }
         }


        private void AddToAccessoryList(string name, decimal bedrag)
        {
            var accessoire = new Accesoires
            {
                Name = name,
                Bedrag = bedrag

            };
            checkBoxItems.Add(accessoire);
            
        }

       
      
        
        
        private void RemoveFromAccessoryList(string name)
        {
        
            checkBoxItems.RemoveAll((x) => x.Name == name);
        }
        private void regendakChkbox_CheckedChanged(object sender, EventArgs e)
        {
          

            if (regendakChkbox.Checked)
            {
                AddToAccessoryList(RegenDak, Convert.ToDecimal(AccesoiresPrice[1]));
                showHuidigeHuur(prijscalculeren());

            }
            else
            {
                RemoveFromAccessoryList(RegenDak);
                showHuidigeHuur(prijscalculeren());
            }
        }

        private void ZonnedakChkBox_CheckedChanged(object sender, EventArgs e)
        { 

            if (ZonnedakChkBox.Checked)
            {
                AddToAccessoryList(Zonnedak, Convert.ToDecimal(AccesoiresPrice[2]));
                showHuidigeHuur(prijscalculeren());

            }
            else
            {
                RemoveFromAccessoryList(Zonnedak);
                showHuidigeHuur(prijscalculeren());
            }
        }

        private void BabystoelChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (BabystoelChkbox.Checked)
            {
                AddToAccessoryList(BabyStoeltje, Convert.ToDecimal(AccesoiresPrice[3]));
                showHuidigeHuur(prijscalculeren());

            }
            else
            {
                RemoveFromAccessoryList(BabyStoeltje);
                showHuidigeHuur(prijscalculeren());
            }
        }

        private void SmarthomeChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SmarthomeChkbox.Checked)
            {
                AddToAccessoryList(Smartphone, Convert.ToDecimal(AccesoiresPrice[4]));
                showHuidigeHuur(prijscalculeren());

            }
            else
            {
                RemoveFromAccessoryList(Smartphone);
                showHuidigeHuur(prijscalculeren());
            }
        }

        private void KaarthouderChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (KaarthouderChkbox.Checked)
            {
                AddToAccessoryList(Kaarthouder, Convert.ToDecimal(AccesoiresPrice[5]));
                showHuidigeHuur(prijscalculeren());

            }
            else
            {
                RemoveFromAccessoryList(Kaarthouder);
                showHuidigeHuur(prijscalculeren());
            }
        }

        private void helmChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (helmChkbox.Checked)
            {
                AddToAccessoryList(Helm, Convert.ToDecimal(AccesoiresPrice[6]));
                showHuidigeHuur(prijscalculeren());

            }
            else
            {
                RemoveFromAccessoryList(Helm);
                showHuidigeHuur(prijscalculeren());
            }
        }

        private void klantnummerTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (klantnummerTxtbox.Text == "")
            {
                MessageBox.Show("Vul klantnummer in om te huren");
            }
        }

        private void getKlantgegevens(object sender, EventArgs e)  //Klantdata weergeven
        {
            //  klantDataset klantdata = new klantDataset();
            //  klantdata.Show();
            getKlant();
        }

        public void getKlant()
        {
            klanten = db.getKlant();
            foreach (Klant st in klanten)
            {

                Console.WriteLine("Klantnummer:"+st.Klantnummer + " klantnaam: " + st.naam + " klantvoornaam: " + st.voornaam + " Postcode:" + st.postcode + " huisnummer:" + st.huisnummer + " huisnummertoevoeging:" + st.huisnummer_toevoeging + " Opmerkingen:" + st.opmerkingen);

            }

        }
            public void getVerhuur()
            {
                verhuren = db.getVerhuur();
                foreach (verhuur st in verhuren)
                {

                    Console.WriteLine("Verhuurnummer:"+st.Verhuurnummer+ " verhuurdatum:" + st.verhuurdatum +" bakfietsnummer:"+ st.bakfietsnummer + " aantaldagen:" + st.aantal_dagen + " huurprijstotaal:" + st.huurprijstotaal + " klantnummer: " + st.klantnummer + " verhuurder: " + st.verhuurder);
            }

            }



            private void klantAanpassen()    //Klant update 
        {


            if (klantnummerTxtbox.Text == "")
            {
                MessageBox.Show("Vul de klantnummer in die je wilt aanpassen");
            }
            else
            {
                db.KlantUpdate(NameTxtbox.Text, VoornaamTxtBox.Text, PostCodeTxtBox.Text, HuisnrTxtBox.Text, ToevoegingTxtBox.Text, OpmerkingTxtBox.Text, Convert.ToInt32(klantnummerTxtbox.Text));

            }
        }


        private void VerhuurBtn_Click_1(object sender, EventArgs e)
        {
            getVerhuur();
        }

        private void textBox1_TextChanged(object sender)
        {
           
        }

        private void KlantWijzigen_Click(object sender, EventArgs e)
        {
            klantAanpassen();
           
        }

        private void bakfietsverhurenTxtbox_Click(object sender, EventArgs e)
        {
            bakfietsverhuren();
        }

        private void getKlantdata_Click(object sender, EventArgs e)
        {
            getKlant();
        }
    }
}
