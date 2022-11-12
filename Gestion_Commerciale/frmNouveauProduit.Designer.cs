namespace Gestion_Commerciale
{
    partial class frmNouveauProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNouveauproduit = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLibellé = new System.Windows.Forms.TextBox();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.cmbCatégorie = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnCréerInventaire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNouveauproduit
            // 
            this.lblNouveauproduit.AutoSize = true;
            this.lblNouveauproduit.Location = new System.Drawing.Point(336, 49);
            this.lblNouveauproduit.Name = "lblNouveauproduit";
            this.lblNouveauproduit.Size = new System.Drawing.Size(87, 13);
            this.lblNouveauproduit.TabIndex = 0;
            this.lblNouveauproduit.Text = "Nouveau Produit";
            this.lblNouveauproduit.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(215, 138);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "Code";
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(417, 138);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 2;
            this.txtLibellé.Text = "Libellé";
            // 
            // txtPdv
            // 
            this.txtPdv.Location = new System.Drawing.Point(417, 208);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(100, 20);
            this.txtPdv.TabIndex = 3;
            this.txtPdv.Text = "Prix De Vente";
            // 
            // cmbCatégorie
            // 
            this.cmbCatégorie.FormattingEnabled = true;
            this.cmbCatégorie.Location = new System.Drawing.Point(215, 208);
            this.cmbCatégorie.Name = "cmbCatégorie";
            this.cmbCatégorie.Size = new System.Drawing.Size(121, 21);
            this.cmbCatégorie.TabIndex = 4;
            this.cmbCatégorie.Text = "Catégorie";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(417, 318);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(276, 318);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnCréerInventaire
            // 
            this.btnCréerInventaire.Location = new System.Drawing.Point(312, 84);
            this.btnCréerInventaire.Name = "btnCréerInventaire";
            this.btnCréerInventaire.Size = new System.Drawing.Size(125, 23);
            this.btnCréerInventaire.TabIndex = 7;
            this.btnCréerInventaire.Text = "Créer Inventaire";
            this.btnCréerInventaire.UseVisualStyleBackColor = true;
            this.btnCréerInventaire.Click += new System.EventHandler(this.btnCréerInventaire_Click);
            // 
            // frmNouveauProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCréerInventaire);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbCatégorie);
            this.Controls.Add(this.txtPdv);
            this.Controls.Add(this.txtLibellé);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblNouveauproduit);
            this.Name = "frmNouveauProduit";
            this.Text = "frmNouveauProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouveauproduit;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtLibellé;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.ComboBox cmbCatégorie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCréerInventaire;
    }
}