using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_adoption.Class
{
    class Class_category
    {
        private dbadoptcontext db = new dbadoptcontext();
        private category Cat;

        //Ajouter categorie
        public bool Ajouter(string Nom)
        {
            Cat = new category();
            Cat.name_category = Nom;
        
            //si la categorie n'existe pas dans la base de données
            var exist = db.categories.SingleOrDefault(s => s.name_category == Nom);
            if (exist == null)
            {
                //donc l'ajout dans la base de données
                db.categories.Add(Cat);
                //puis l"enregistrement dans la base de données
                db.SaveChanges();
                return true;
            }

            else
            {
                return false;
            }
        }
        //Modifier categorie
        public void Modifier(int ID, string Nom)
        {
            Cat = new category();
            Cat = db.categories.SingleOrDefault(s => s.id_category == ID);
            //si la categorie existe dans la base de données
            if (Cat != null)
            {
                //initialisation des nouveaux champs
                Cat.name_category = Nom;
                //enregistrement dans la base de données
                db.SaveChanges();
            }
        }
        //Supprimer categorie
        public void Supprimer(int ID)
        {
            Cat = new category();
            Cat = db.categories.SingleOrDefault(s => s.id_category == ID);
            //si le client est existe
            if (Cat != null)
            {
                //Supprimer le client
                db.categories.Remove(Cat);
                //enregistrement sur la base de données
                db.SaveChanges();
            }
        }
    }
}
