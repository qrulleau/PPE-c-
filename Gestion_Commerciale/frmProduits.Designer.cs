namespace Gestion_Commerciale
{
    partial class frmProduits
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnDétails = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cbxCatégorie = new System.Windows.Forms.ComboBox();
            this.txtLibellé = new System.Windows.Forms.TextBox();
            this.txtPdv = new System.Windows.Forms.TextBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(712, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(45, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Produits";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(1319, 45);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(110, 53);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnDétails
            // 
            this.btnDétails.AutoSize = true;
            this.btnDétails.Location = new System.Drawing.Point(1113, 216);
            this.btnDétails.Name = "btnDétails";
            this.btnDétails.Size = new System.Drawing.Size(39, 13);
            this.btnDétails.TabIndex = 2;
            this.btnDétails.Text = "Détails";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(1039, 397);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(1208, 397);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(1027, 255);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 5;
            this.txtCode.Text = "Code";
            // 
            // cbxCatégorie
            // 
            this.cbxCatégorie.AutoCompleteCustomSource.AddRange(new string[] {
            "réseau",
            "consommables",
            "pièces détachées",
            "PC"});
            this.cbxCatégorie.FormattingEnabled = true;
            this.cbxCatégorie.Location = new System.Drawing.Point(1027, 316);
            this.cbxCatégorie.Name = "cbxCatégorie";
            this.cbxCatégorie.Size = new System.Drawing.Size(121, 21);
            this.cbxCatégorie.TabIndex = 6;
            this.cbxCatégorie.Text = "Catégorie";
            // 
            // txtLibellé
            // 
            this.txtLibellé.Location = new System.Drawing.Point(1208, 255);
            this.txtLibellé.Name = "txtLibellé";
            this.txtLibellé.Size = new System.Drawing.Size(100, 20);
            this.txtLibellé.TabIndex = 7;
            this.txtLibellé.Text = "Libellé";
            // 
            // txtPdv
            // 
            this.txtPdv.Location = new System.Drawing.Point(1208, 317);
            this.txtPdv.Name = "txtPdv";
            this.txtPdv.Size = new System.Drawing.Size(100, 20);
            this.txtPdv.TabIndex = 8;
            this.txtPdv.Text = "Prix De Vente";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(1125, 462);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 35);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(12, 216);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.Size = new System.Drawing.Size(635, 423);
            this.dgvProduits.TabIndex = 10;
            // 
            // frmProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 778);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.txtPdv);
            this.Controls.Add(this.txtLibellé);
            this.Controls.Add(this.cbxCatégorie);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDétails);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmProduits";
            this.Text = "frmPoduits";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label btnDétails;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cbxCatégorie;
        private System.Windows.Forms.TextBox txtLibellé;
        private System.Windows.Forms.TextBox txtPdv;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.DataGridView dgvProduits;
    }
}