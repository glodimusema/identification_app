using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identification_app.Classes
{
    class clsPersonne
    {
        int id;
	    string noms;
	    string adresse;
	    string contact;
	    string etat_civil;
	    DateTime date_naissance;
        string niveau_etude;
	    string domaine_etude;
	    string author;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Etat_civil { get => etat_civil; set => etat_civil = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Niveau_etude { get => niveau_etude; set => niveau_etude = value; }
        public string Domaine_etude { get => domaine_etude; set => domaine_etude = value; }
        public string Author { get => author; set => author = value; }
    }
}
