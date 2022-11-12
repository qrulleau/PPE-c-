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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            frmProduits frmProduits = new frmProduits();
            frmProduits.ShowDialog();
        }

        private void btnDéconnexion_Click(object sender, EventArgs e)
        {
            //this.Close(); (pas encore d'authentification donc this.close fermera le programe)
            frmAuthentification frmAuthentification = new frmAuthentification();
            frmAuthentification.ShowDialog();
        }
    }
}
