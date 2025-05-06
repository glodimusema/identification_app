using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identification_app.Classes
{
    class clsAffectation
    {
        int id;
	    int refPersonne;
	    int refProjet;
        string author;

        public int Id { get => id; set => id = value; }
        public int RefPersonne { get => refPersonne; set => refPersonne = value; }
        public int RefProjet { get => refProjet; set => refProjet = value; }
        public string Author { get => author; set => author = value; }
    }
}
