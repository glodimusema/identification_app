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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUser user = clsGlossaires.Getinstance().Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Bienvenue user.Username !", "Connexion réussie");

                // Ouvre le formulaire d'accueil
                //frmPrincipale accueil = new frmPrincipale(user);
                frmPrincipale accueil = new frmPrincipale();
                accueil.Show();

                this.Hide(); // ou this.Close() si tu veux fermer le login
            }
            else
            { MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
