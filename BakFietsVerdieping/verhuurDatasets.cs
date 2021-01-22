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
    public partial class verhuurDatasets : Form
    {
        public verhuurDatasets()
        {
            InitializeComponent();
        }

        private void verhuurDatasets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'verhuur._verhuur' table. You can move, or remove it, as needed.
       //     this.verhuurTableAdapter1.Fill(this.verhuur._verhuur);
            // TODO: This line of code loads data into the 'klant.verhuuraccessoire' table. You can move, or remove it, as needed.
            this.verhuuraccessoireTableAdapter.Fill(this.klant.verhuuraccessoire);
            // TODO: This line of code loads data into the 'klant.verhuur' table. You can move, or remove it, as needed.
            this.verhuurTableAdapter.Fill(this.klant.verhuur);

        }
    }
}
