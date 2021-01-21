using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BakFietsVerdieping
{
    class Database
    {
        private string connString = string.Format("Server=localhost; database=test; UID=root; password=");
        private MySqlConnection connection = null; // connectie maken met de mysql database

        public bool IsConnect()
        {
            if (connection == null)    //als er geen connectie dan wordt er connectie gemaakt met de database
            {
                connection = new MySqlConnection(connString);
                connection.Open(); 
            }
            return true;
        }


        public void insertKlant(string name, string voornaam, string postcode, string huisnummer, string huisnummer_toevoeging, string opmerkingen)
        {

            if (IsConnect())
            {

                string query1 = "INSERT INTO test.klant (naam,voornaam,postcode,huisnummer,huisnummer_toevoeging,opmerkingen) VALUES('" + name + "','" + voornaam + "','" + postcode + "','" + huisnummer + "','" + huisnummer_toevoeging + "','" + opmerkingen + "')";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Toevoegd");
            }
        }

        public void insertVerhuur(int bakfietsnummer,string verhuurdatum,int aantal_dagen,decimal huurprijstotaal,int klantnummer, int verhuurder)
        {
            if (IsConnect())
            {
                string query2 = "INSERT INTO test.verhuur (bakfietsnummer,verhuurdatum,aantal_dagen,huurprijstotaal,klantnummer, verhuurder) VALUES ('" + bakfietsnummer + "', '" + verhuurdatum + "', '" + aantal_dagen + "','" + huurprijstotaal+ "', '" + klantnummer + "', '" + verhuurder + "' ) ";
                MySqlCommand cmd1 = new MySqlCommand(query2, connection);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Bakfiets verhuurd!");
            }

        }

        public void KlantUpdate(string name, string voornaam, string postcode, string huisnummer, string huisnummer_toevoeging, string opmerkingen,int klantnummer)
        {
            if (IsConnect())
            {
                string query3 = "UPDATE test.klant SET klant.naam='" + name + "' , klant.voornaam='" + voornaam + "', klant.postcode='" + postcode + "', klant.huisnummer='" + huisnummer + "' , klant.huisnummer_toevoeging ='" + huisnummer_toevoeging + "', klant.opmerkingen='" + opmerkingen + "' WHERE klant.klantnummer = '" + klantnummer + "' ";
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                cmd3.ExecuteNonQuery();
                MessageBox.Show ("De klantgegevens zijn geupdate");
            }

        }

        public void verhuurAccesoiresInsert(int aantal)
        {
            if(IsConnect())
            {
                string query4 = "INSERT into test.verhuuraccessoire(aantal) VALUES('" + aantal + "')";
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("De klantgegevens zijn geupdate");
            }

        }

    }
}
