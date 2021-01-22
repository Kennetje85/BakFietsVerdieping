using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakFietsVerdieping
{
    public partial class login : Form
    {
       


        public login()   //Constructor 
        {
            InitializeComponent();
            Database db = new Database();
            string userid = UsernamTxtbox.Text;
            string password = passwrdTxtBox.Text;


        }
      //  string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\login.mdf;Integrated Security=True;";
          string cs = @"Data Source=.\SQLEXPRESS;
                     AttachDbFilename=C:\Users\Kennetje\Desktop\Fontys\ICT SoftwareVerdieping\login.mdf;
                    Integrated Security=True;
                     Connect Timeout=30;
                     User Instance=True";
      
        private void button1_Click(object sender, EventArgs e)
        {

            if (UsernamTxtbox.Text == "" || passwrdTxtBox.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", UsernamTxtbox.Text);
                cmd.Parameters.AddWithValue("@password", passwrdTxtBox.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds); //populate the dataset
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //als count gelijk aan 1 , than show frmMain form

                if (count == 1)
                {
                    Verhuur frm = new Verhuur();
                    frm.Show();
                    MessageBox.Show("Login Successful!");
                

                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void passwrdTxtBox_TextChanged(object sender, EventArgs e)
        {
            passwrdTxtBox.PasswordChar = '*'; //tekstbox alleen ** weergeveni
        }
    }

    

}