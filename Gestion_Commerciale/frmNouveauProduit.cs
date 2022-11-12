using LibProduits;
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
    public partial class frmNouveauProduit : Form
    {
        Inventaire_Produits monInventaire;

        public frmNouveauProduit()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCréerInventaire_Click(object sender, EventArgs e)
        {

            monInventaire = new Inventaire_Produits();
            MessageBox.Show("Votre inventaire à été créé");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit unProduit = new Produit(txtCode.Text, txtLibellé.Text, cmbCatégorie.Text, txtPdv.Text);
            monInventaire.AjouterProduit(unProduit);
        }
    }
}
