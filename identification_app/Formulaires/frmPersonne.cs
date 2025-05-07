using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using identification_app.Classes;

namespace identification_app.Formulaires
{
    public partial class frmPersonne : Form
    {
        public frmPersonne()
        {
            InitializeComponent();
        }

        clsPersonne cb = null;

        void Actualiser()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtAdresse.Text = "";
            txtContact.Text = "";
            txtEtatCivil.Text = "";
            txtDateNaissance.Text = "";
            txtNiveauEtude.Text = "";
            txtDomaineEtude.Text = "";
        }

        void SaveData()
        {
            try
            {
                cb = new clsPersonne();
                cb.Noms = txtNom.Text;
                cb.Adresse = txtAdresse.Text;
                cb.Contact = txtContact.Text;
                cb.Etat_civil = txtEtatCivil.Text;
                cb.Date_naissance = DateTime.Parse(txtDateNaissance.Text);
                cb.Niveau_etude = txtNiveauEtude.Text;
                cb.Domaine_etude = txtDomaineEtude.Text;

                clsGlossaires.Getinstance().SavePersonne(cb);
                liste_personne.DataSource = clsGlossaires.Getinstance().loadData("tpersonne");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void UpdateData()
        {
            try
            {
                cb = new clsPersonne();
                cb.Id = int.Parse(txtId.Text);
                cb.Noms = txtNom.Text;
                cb.Adresse = txtAdresse.Text;
                cb.Contact = txtContact.Text;
                cb.Etat_civil = txtEtatCivil.Text;
                cb.Date_naissance = DateTime.Parse(txtDateNaissance.Text);
                cb.Niveau_etude = txtNiveauEtude.Text;
                cb.Domaine_etude = txtDomaineEtude.Text;

                clsGlossaires.Getinstance().updatePersonne(cb);
                liste_personne.DataSource = clsGlossaires.Getinstance().loadData("tpersonne");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void DeleteData()
        {
            clsGlossaires.Getinstance().SupprimerData("tpersonne", "id", txtId.Text);
            liste_personne.DataSource = clsGlossaires.Getinstance().loadData("tpersonne");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void frmPersonne_Load(object sender, EventArgs e)
        {
            liste_personne.DataSource = clsGlossaires.Getinstance().loadData("tpersonne");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            liste_personne.DataSource = clsGlossaires.Getinstance().searchData("tpersonne","noms",txtRecherche.Text);
        }
    }
}
