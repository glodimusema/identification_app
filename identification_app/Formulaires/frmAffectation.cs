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
    public partial class frmAffectation : Form
    {
        public frmAffectation()
        {
            InitializeComponent();
        }

        clsAffectation cb = null;

        void Actualiser()
        {
            txtId.Text = "";
            txtEnqueteur.Text = "";
            txtProjet.Text = "";
            txtAutresDetails.Text = "";
        }

        void SaveData()
        {
            try
            {
                cb = new clsAffectation();
                cb.RefPersonne = int.Parse(clsGlossaires.Getinstance().getcode_Combo("tpersonne", "id", "noms", txtEnqueteur.Text));
                cb.RefProjet = int.Parse(clsGlossaires.Getinstance().getcode_Combo("tprojet", "id", "nom_projet", txtProjet.Text));
                cb.Date_affectation = DateTime.Now;
                cb.Autres_details = txtAutresDetails.Text;

                clsGlossaires.Getinstance().SaveAffectation(cb);
                liste_affectation.DataSource = clsGlossaires.Getinstance().loadData("vAffectation");
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
                cb = new clsAffectation();
                cb.Id = int.Parse(txtId.Text);
                cb.RefPersonne = int.Parse(clsGlossaires.Getinstance().getcode_Combo("tpersonne", "id", "noms", txtEnqueteur.Text));
                cb.RefProjet = int.Parse(clsGlossaires.Getinstance().getcode_Combo("tprojet", "id", "nom_projet", txtProjet.Text));
                cb.Date_affectation = DateTime.Now;
                cb.Autres_details = txtAutresDetails.Text;
                clsGlossaires.Getinstance().UpdateAffectation(cb);
                liste_affectation.DataSource = clsGlossaires.Getinstance().loadData("vAffectation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void DeleteData()
        {
            clsGlossaires.Getinstance().SupprimerData("taffectation_projet", "id", txtId.Text);
            liste_affectation.DataSource = clsGlossaires.Getinstance().loadData("vAffectation");
        }

        private void frmAffectation_Load(object sender, EventArgs e)
        {
            liste_affectation.DataSource = clsGlossaires.Getinstance().loadData("vAffectation");
            clsGlossaires.Getinstance().loadCombo("tpersonne", "noms", txtEnqueteur);
            clsGlossaires.Getinstance().loadCombo("tprojet", "nom_projet", txtProjet);
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

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            liste_affectation.DataSource = clsGlossaires.Getinstance().searchData("vAffectation", "noms", txtRecherche.Text);
        }

        private void liste_affectation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = liste_affectation.Rows[e.RowIndex];
                // Supposons que tu as trois TextBox : txtId, txtUsername, txtNiveau
                txtId.Text = row.Cells["id"].Value.ToString();
                txtEnqueteur.SelectedItem = row.Cells["noms"].Value.ToString();
                txtProjet.SelectedItem = row.Cells["nom_projet"].Value.ToString();
                txtAutresDetails.Text = row.Cells["autres_details"].Value.ToString();
            }
        }
    }
}
