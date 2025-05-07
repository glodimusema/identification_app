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
    public partial class frmProjet : Form
    {
        public frmProjet()
        {
            InitializeComponent();
        }

        clsProjet cb = null;

        void Actualiser()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtDescription.Text = "";
            txtDateDebut.Text = "";
            txtDateFin.Text = "";
        }

        void SaveData()
        {
            try
            {
                cb = new clsProjet();
                cb.Nom_projet = txtNom.Text;
                cb.Description_projet = txtDescription.Text;
                cb.Date_debut = DateTime.Parse(txtDateDebut.Text);
                cb.Date_fin = DateTime.Parse(txtDateFin.Text);

                clsGlossaires.Getinstance().SaveProjet(cb);
                liste_projet.DataSource = clsGlossaires.Getinstance().loadData("tprojet");
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
                cb = new clsProjet();
                cb.Id = int.Parse(txtId.Text);
                cb.Nom_projet = txtNom.Text;
                cb.Description_projet = txtDescription.Text;
                cb.Date_debut = DateTime.Parse(txtDateDebut.Text);
                cb.Date_fin = DateTime.Parse(txtDateFin.Text);
                clsGlossaires.Getinstance().updateProjet(cb);
                liste_projet.DataSource = clsGlossaires.Getinstance().loadData("tprojet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void DeleteData()
        {
            clsGlossaires.Getinstance().SupprimerData("tprojet", "id", txtId.Text);
            liste_projet.DataSource = clsGlossaires.Getinstance().loadData("tprojet");
        }


        private void label3_Click(object sender, EventArgs e)
        {

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

        private void frmProjet_Load(object sender, EventArgs e)
        {
            liste_projet.DataSource = clsGlossaires.Getinstance().loadData("tprojet");
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            liste_projet.DataSource = clsGlossaires.Getinstance().searchData("tprojet", "nom_projet", txtRecherche.Text);
        }
    }
}
