using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_adoption.Class
{
    class class_connexion
    {
        //instanciation de table user
        utilisateur user = new utilisateur();
        //instaciation de base 
        dbadoptcontext userr = new dbadoptcontext();
        //verification de connexion
        public bool Valid(string Nom, string Mot_de_passe)
        {
            user.nom_utilisateur = Nom;
            user.mot_de_passe = Mot_de_passe;
            //si l'utilisateur est existe dans la base
            var exist = userr.utilisateurs.SingleOrDefault(s => s.nom_utilisateur == Nom && s.mot_de_passe == Mot_de_passe);
            if (exist!=null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
