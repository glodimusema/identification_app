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
    public partial class frmSinUp : Form
    {
        public frmSinUp()
        {
            InitializeComponent();
        }


        clsUser cb = null;

        void Actualiser()
        {
            txtId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNiveau.Text = "";
        }

        void SaveData()
        {
            try
            {
                cb = new clsUser();
                cb.Username = txtUsername.Text;
                cb.Passwords = txtPassword.Text;
                cb.Niveau = txtNiveau.Text;
                clsGlossaires.Getinstance().SaveUser(cb);
                liste_User.DataSource = clsGlossaires.Getinstance().loadData("tuser");
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
                cb = new clsUser();
                cb.Id = int.Parse(txtId.Text);
                cb.Username = txtUsername.Text;
                cb.Passwords = txtPassword.Text;
                cb.Niveau = txtNiveau.Text;
                clsGlossaires.Getinstance().UpdateUser(cb);
                liste_User.DataSource = clsGlossaires.Getinstance().loadData("tuser");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void DeleteData()
        {
            clsGlossaires.Getinstance().SupprimerData("tuser", "id", txtId.Text);
            liste_User.DataSource = clsGlossaires.Getinstance().loadData("tuser");
        }

        private void frmSinUp_Load(object sender, EventArgs e)
        {
            liste_User.DataSource = clsGlossaires.Getinstance().loadData("tuser");
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            liste_User.DataSource = clsGlossaires.Getinstance().searchData("tuser", "username", txtRecherche.Text);
        }

        private void liste_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = liste_User.Rows[e.RowIndex];
                // Supposons que tu as trois TextBox : txtId, txtUsername, txtNiveau
                txtId.Text = row.Cells["id"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["passwords"].Value.ToString();
                txtNiveau.Text = row.Cells["niveau"].Value.ToString();
            }
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
    }
}
