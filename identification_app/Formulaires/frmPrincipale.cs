using identification_app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identification_app.Formulaires
{
    public partial class frmPrincipale : Form
    {
        private clsUser utilisateur = null;
        public frmPrincipale()
        {
            InitializeComponent();
            //utilisateur = user;

        }

        private void identificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonne f = new frmPersonne();
            f.ShowDialog();
        }

        private void affectaionProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAffectation f = new frmAffectation();
            f.ShowDialog();
        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRapport f = new frmRapport();
            f.ShowDialog();
        }

        private void lesProjetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjet f = new frmProjet();
            f.ShowDialog();
        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinUp f = new frmSinUp();
            f.ShowDialog();
        }
    }
}
