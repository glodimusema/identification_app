using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identification_app.Classes
{
    class clsProjet
    {
        int id;
        string nom_projet;
        string description_projet;
        DateTime date_debut;
        DateTime date_fin;

        public int Id { get => id; set => id = value; }
        public string Nom_projet { get => nom_projet; set => nom_projet = value; }
        public string Description_projet { get => description_projet; set => description_projet = value; }
        public DateTime Date_debut { get => date_debut; set => date_debut = value; }
        public DateTime Date_fin { get => date_fin; set => date_fin = value; }
    }
}
