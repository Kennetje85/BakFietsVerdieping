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
    public partial class klantDataset : Form
    {
        public klantDataset()
        {
            InitializeComponent();
        }

        private void klantDataset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'klant1._klant' table. You can move, or remove it, as needed.
            this.klantTableAdapter.Fill(this.klant1._klant);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
