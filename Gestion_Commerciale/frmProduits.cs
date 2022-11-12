using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Commerciale
{
    public partial class frmProduits : Form
    {
        public frmProduits()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmNouveauProduit frmNouveauProduit = new frmNouveauProduit();
            frmNouveauProduit.ShowDialog();
        }
    }
}
