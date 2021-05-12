using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_adoption.Class
{
    class Class_user
    {
        private dbadoptcontext db = new dbadoptcontext();
        private utilisateur User;

        //Fonction ajouter utilisateur
        public bool Ajouter(string Nom, string Mdp)
        {
            User = new utilisateur();
            User.nom_utilisateur = Nom;
            User.mot_de_passe = Mdp;


            //si l'utilisateur n'existe pas dans la base de données
            var exist = db.utilisateurs.SingleOrDefault(s => s.nom_utilisateur == Nom);
            if (exist == null)
            {
                //donc l'ajout dans la base de données
                db.utilisateurs.Add(User);
                //puis l"enregistrement dans la base de données
                db.SaveChanges();
                return true;
            }

            else
            {
                return false;
            }
        }
        //Fonction modifier utilisateur
        public void Modifier(int ID, string Nom, string Mdp)
        {
            User = new utilisateur();
            User = db.utilisateurs.SingleOrDefault(s => s.id_utilisateur == ID);
            //si le client existe dans la base de données
            if (User != null)
            {
                //initialisation des nouveaux champs
                User.nom_utilisateur = Nom;
                User.mot_de_passe = Mdp;
                //enregistrement dans la base de données
                db.SaveChanges();
            }

        }
        //Fonction supprimer utilisateur
        public void Supprimer(int ID)
        {
            User = new utilisateur();
            User = db.utilisateurs.SingleOrDefault(s => s.id_utilisateur == ID);
            //si le client est existe
            if (User != null)
            {
                //Supprimer le client
                db.utilisateurs.Remove(User);
                //enregistrement sur la base de données
                db.SaveChanges();
            }
        }


    }
}
