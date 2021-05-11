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
    }
}
