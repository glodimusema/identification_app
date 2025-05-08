using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identification_app.Classes
{
    class clsGlossaires
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter dt = null;
        SqlDataReader dr = null;
        public static clsGlossaires _glos = null;

        public static clsGlossaires Getinstance()
        {
            if (_glos == null)
                _glos = new clsGlossaires();
            return _glos;
        }

        public void InnitialiseConnexion()
        {
            try
            {
                con = new SqlConnection(clsConnexion.chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void setParameter(SqlCommand cmd, string name, DbType type, int length, object paramValue)
        {
            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;

            if (paramValue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;
                }
                a.Value = DBNull.Value;
            }
            else
                a.Value = paramValue;
            cmd.Parameters.Add(a);
        }

        public void loadCombo(string nomTable, string nomchamp, System.Windows.Forms.ComboBox comb1)
        {
            InnitialiseConnexion();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("SELECT " + nomchamp + " FROM " + nomTable + "", con);
            try
            {
                DataTable dt1 = new DataTable();
                dt.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    comb1.Items.Add(dr[nomchamp]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }

            con.Close();
        }

        public string getcode_Combo(string nomTable, string nomChampId, string nomChamp, string valeur)
        {
            string IdData = "";
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select " + nomChampId + " from " + nomTable + " where " + nomChamp + "=@a", con);
                cmd.Parameters.AddWithValue("@a", valeur);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdData = (dr[nomChampId].ToString());
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return IdData;
        }

        public DataSet get_Report_All(string nomTable,string ordre)
        {
            DataSet dst;
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " order by "+ordre+"", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public DataSet get_Report_Trier(string nomTable, string nomchamp, DateTime val1, DateTime val2)
        {
            DataSet dst;
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " between @date1 and @date2 ", con);
                setParameter(cmd, "@date1", DbType.DateTime, 30, val1);
                setParameter(cmd, "@date2", DbType.DateTime, 30, val2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }


        public DataSet get_Report_TrierField(string nomTable, string nomchamp, DateTime val1, DateTime val2,string nomchamp2,string valeur)
        {
            DataSet dst;
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE (" + nomchamp + " between @date1 and @date2) and ("+nomchamp2+" = @valeurs) ", con);
                setParameter(cmd, "@date1", DbType.DateTime, 30, val1);
                setParameter(cmd, "@date2", DbType.DateTime, 30, val2);
                setParameter(cmd, "@valeurs", DbType.String, 30, valeur);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public DataSet get_Report_One(string nomTable, string nomchamp, string val1,string ordre)
        {
            DataSet dst;
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " = @val1 order by "+ordre+"", con);
                setParameter(cmd, "@val1", DbType.String, 30, val1);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        

        public DataSet get_Report_Two(string nomTable, string nomchamp, string val1, string nomchamp2, string val2)
        {
            DataSet dst;
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " WHERE " + nomchamp + " = @val1 and " + nomchamp2 + " = @val2", con);
                setParameter(cmd, "@val1", DbType.String, 30, val1);
                setParameter(cmd, "@val2", DbType.String, 30, val2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }




        public DataTable loadData(string nomTable)
        {
            InnitialiseConnexion();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select * from " + nomTable + "", con);
            dt.Fill(table);
            con.Close();

            return table;
        }


        public bool Login_bool(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(clsConnexion.chemin))
            {
                string query = "SELECT COUNT(*) FROM tuser WHERE username = @username AND passwords = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }


        public clsUser Login(string username, string password)
        {
            string connectionString = clsConnexion.chemin;
            clsUser utilisateur = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT id, username, niveau FROM tuser WHERE username = @username AND passwords = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        utilisateur = new clsUser
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Niveau = reader.GetString(2)
                        };
                    }
                }
            }

            return utilisateur;
        }



        public DataTable searchData(string nomTable,string nomChmap,string datas)
        {
            InnitialiseConnexion();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select * from " + nomTable + " where "+nomChmap+" like '%"+datas+"%'", con);
            dt.Fill(table);
            con.Close();

            return table;
        }

        public void SupprimerData(string nomTable, string nomChamp, string value)
        {
            con = new SqlConnection(clsConnexion.chemin);
            con.Open();
            cmd = new SqlCommand("delete from " + nomTable + " where " + nomChamp + "=@id", con);
            cmd.Parameters.AddWithValue("@id", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void SavePersonne(clsPersonne cl)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("insert into tpersonne (noms,adresse,contact,etat_civil,date_naissance,niveau_etude,domaine_etude,author) values " +
                "(@noms,@adresse,@contact,@etat_civil,@date_naissance,@niveau_etude,@domaine_etude,@author)", con);
            cmd.Parameters.AddWithValue("@noms", cl.Noms);
            cmd.Parameters.AddWithValue("@adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@contact", cl.Contact);
            cmd.Parameters.AddWithValue("@etat_civil", cl.Etat_civil);
            cmd.Parameters.AddWithValue("@date_naissance", cl.Date_naissance);
            cmd.Parameters.AddWithValue("@niveau_etude", cl.Niveau_etude);
            cmd.Parameters.AddWithValue("@domaine_etude", cl.Domaine_etude);
            cmd.Parameters.AddWithValue("@author", "Admin");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updatePersonne(clsPersonne cl)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("update tpersonne set noms=@noms,adresse=@adresse,contact=@contact,etat_civil=@etat_civil,date_naissance=@date_naissance,niveau_etude=@niveau_etude,domaine_etude=@domaine_etude where id=@id", con);
            cmd.Parameters.AddWithValue("@id", cl.Id);
            cmd.Parameters.AddWithValue("@noms", cl.Noms);
            cmd.Parameters.AddWithValue("@adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@contact", cl.Contact);
            cmd.Parameters.AddWithValue("@etat_civil", cl.Etat_civil);
            cmd.Parameters.AddWithValue("@date_naissance", cl.Date_naissance);
            cmd.Parameters.AddWithValue("@niveau_etude", cl.Niveau_etude);
            cmd.Parameters.AddWithValue("@domaine_etude", cl.Domaine_etude);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SaveProjet(clsProjet cat)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("insert into tprojet (nom_projet,description_projet,date_debut,date_fin) values (@nom_projet,@description_projet,@date_debut,@date_fin)", con);
            cmd.Parameters.AddWithValue("@nom_projet", cat.Nom_projet);
            cmd.Parameters.AddWithValue("@description_projet", cat.Description_projet);
            cmd.Parameters.AddWithValue("@date_debut", cat.Date_debut);
            cmd.Parameters.AddWithValue("@date_fin", cat.Date_fin);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateProjet(clsProjet cat)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("update tprojet set nom_projet=@nom_projet,description_projet=@description_projet,date_debut=@date_debut,date_fin=@date_fin where id=@id", con);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@nom_projet", cat.Nom_projet);
            cmd.Parameters.AddWithValue("@description_projet", cat.Description_projet);
            cmd.Parameters.AddWithValue("@date_debut", cat.Date_debut);
            cmd.Parameters.AddWithValue("@date_fin", cat.Date_fin);
            cmd.ExecuteNonQuery();
            con.Close();
        }



        public void SaveAffectation(clsAffectation cat)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("insert into taffectation_projet (refPersonne,refProjet,date_affectation,autres_details,author) values (@refPersonne,@refProjet,@date_affectation,@autres_details,@author)", con);
            cmd.Parameters.AddWithValue("@refPersonne", cat.RefPersonne);
            cmd.Parameters.AddWithValue("@refProjet", cat.RefProjet);
            cmd.Parameters.AddWithValue("@date_affectation", cat.RefProjet);
            cmd.Parameters.AddWithValue("@autres_details", cat.RefProjet);
            cmd.Parameters.AddWithValue("@author", "Admin");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateAffectation(clsAffectation cat)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("update taffectation_projet set refPersonne=@refPersonne,refProjet=@refProjet,date_affectation=@date_affectation,autres_details=@autres_details where id=@id", con);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@refPersonne", cat.RefPersonne);
            cmd.Parameters.AddWithValue("@refProjet", cat.RefProjet);
            cmd.Parameters.AddWithValue("@date_affectation", cat.Date_affectation);
            cmd.Parameters.AddWithValue("@autres_details", cat.Autres_details);
            //cmd.Parameters.AddWithValue("@author", cat.Author);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void SaveUser(clsUser cat)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("insert into tuser (username,passwords,niveau) values (@username,@passwords,@niveau)", con);
            cmd.Parameters.AddWithValue("@username", cat.Username);
            cmd.Parameters.AddWithValue("@passwords", cat.Passwords);
            cmd.Parameters.AddWithValue("@niveau", cat.Niveau);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateUser(clsUser cat)
        {
            InnitialiseConnexion();
            con.Open();
            cmd = new SqlCommand("update tuser set username=@username,passwords=@passwords,niveau=@niveau id = @id", con);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@username", cat.Username);
            cmd.Parameters.AddWithValue("@passwords", cat.Passwords);
            cmd.Parameters.AddWithValue("@niveau", cat.Niveau);
            cmd.ExecuteNonQuery();
            con.Close();
        }




    }
}
