namespace identification_app.Formulaires
{
    partial class frmPrincipale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enqueteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectaionProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesProjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.enqueteurToolStripMenuItem,
            this.rapportToolStripMenuItem,
            this.parametreToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.acceuilToolStripMenuItem.Text = "Acceuil";
            // 
            // enqueteurToolStripMenuItem
            // 
            this.enqueteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificationToolStripMenuItem,
            this.affectaionProjetToolStripMenuItem});
            this.enqueteurToolStripMenuItem.Name = "enqueteurToolStripMenuItem";
            this.enqueteurToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.enqueteurToolStripMenuItem.Text = "Enqueteur";
            // 
            // identificationToolStripMenuItem
            // 
            this.identificationToolStripMenuItem.Name = "identificationToolStripMenuItem";
            this.identificationToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.identificationToolStripMenuItem.Text = "Identification";
            this.identificationToolStripMenuItem.Click += new System.EventHandler(this.identificationToolStripMenuItem_Click);
            // 
            // affectaionProjetToolStripMenuItem
            // 
            this.affectaionProjetToolStripMenuItem.Name = "affectaionProjetToolStripMenuItem";
            this.affectaionProjetToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.affectaionProjetToolStripMenuItem.Text = "Affectaion/Projet";
            this.affectaionProjetToolStripMenuItem.Click += new System.EventHandler(this.affectaionProjetToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportsToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            this.rapportsToolStripMenuItem.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesProjetsToolStripMenuItem});
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.parametreToolStripMenuItem.Text = "Parametre";
            // 
            // lesProjetsToolStripMenuItem
            // 
            this.lesProjetsToolStripMenuItem.Name = "lesProjetsToolStripMenuItem";
            this.lesProjetsToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.lesProjetsToolStripMenuItem.Text = "Les Projets";
            this.lesProjetsToolStripMenuItem.Click += new System.EventHandler(this.lesProjetsToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 506);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOMULAIRE PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enqueteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectaionProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesProjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
    }
}