namespace Gestion_Commerciale
{
    partial class frmMenu
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
            this.lblQsvf = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProduits = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.btnSynthèse = new System.Windows.Forms.Button();
            this.btnDéconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQsvf
            // 
            this.lblQsvf.AutoSize = true;
            this.lblQsvf.Location = new System.Drawing.Point(567, 98);
            this.lblQsvf.Name = "lblQsvf";
            this.lblQsvf.Size = new System.Drawing.Size(133, 13);
            this.lblQsvf.TabIndex = 0;
            this.lblQsvf.Text = "Que souhaitez vous faire ?";
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(350, 252);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(108, 23);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Gérer Les Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnProduits
            // 
            this.btnProduits.Location = new System.Drawing.Point(509, 252);
            this.btnProduits.Name = "btnProduits";
            this.btnProduits.Size = new System.Drawing.Size(110, 23);
            this.btnProduits.TabIndex = 2;
            this.btnProduits.Text = "Gérer Les Produits";
            this.btnProduits.UseVisualStyleBackColor = true;
            this.btnProduits.Click += new System.EventHandler(this.btnProduits_Click);
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(678, 252);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(98, 23);
            this.btnDevis.TabIndex = 3;
            this.btnDevis.Text = "Gérer Les Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            // 
            // btnSynthèse
            // 
            this.btnSynthèse.Location = new System.Drawing.Point(819, 252);
            this.btnSynthèse.Name = "btnSynthèse";
            this.btnSynthèse.Size = new System.Drawing.Size(116, 23);
            this.btnSynthèse.TabIndex = 4;
            this.btnSynthèse.Text = "Synthèse Des Clients";
            this.btnSynthèse.UseVisualStyleBackColor = true;
            // 
            // btnDéconnexion
            // 
            this.btnDéconnexion.Location = new System.Drawing.Point(599, 429);
            this.btnDéconnexion.Name = "btnDéconnexion";
            this.btnDéconnexion.Size = new System.Drawing.Size(101, 23);
            this.btnDéconnexion.TabIndex = 5;
            this.btnDéconnexion.Text = "Déconnexion";
            this.btnDéconnexion.UseVisualStyleBackColor = true;
            this.btnDéconnexion.Click += new System.EventHandler(this.btnDéconnexion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 549);
            this.Controls.Add(this.btnDéconnexion);
            this.Controls.Add(this.btnSynthèse);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.btnProduits);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.lblQsvf);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQsvf;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProduits;
        private System.Windows.Forms.Button btnDevis;
        private System.Windows.Forms.Button btnSynthèse;
        private System.Windows.Forms.Button btnDéconnexion;
    }
}