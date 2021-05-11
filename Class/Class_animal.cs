using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_adoption.Class
{
    class Class_animal
    {
        private dbadoptcontext db = new dbadoptcontext();
        private animal Animal;

        //ajouter un animal
        public bool Ajouter (string Nom, int Quantite, string Type, string Sexe, int idcat)
        {
            Animal = new animal();
            Animal.nom_animal = Nom;
            Animal.quantite_animal = Quantite;
            Animal.type_animal = Type;
            Animal.sexe_animal = Sexe;
            Animal.id_category = idcat;

            //si l'animal existe dans la base de données
            var exist = db.animals.SingleOrDefault(s => s.nom_animal == Nom);
            if(exist == null)
            {
                //l'ajout dans la base de données
                db.animals.Add(Animal);
                //sauvgarde de base
                db.SaveChanges();
                db.GetValidationErrors();
                return true;
            }
            else
            {
                return false;
            }



        }

        //Modifier un animal
        public void Modifier (int ID, string Nom, int Quantite, string Type, string Sexe, int idcat)
        {
            Animal = new animal();
            Animal = db.animals.SingleOrDefault(s => s.id_animal == ID);
            //si l'animal existe dans la base
            if(Animal != null) 
            { 
            Animal.id_animal = ID;
            Animal.nom_animal = Nom;
            Animal.quantite_animal = Quantite;
            Animal.type_animal = Type;
            Animal.sexe_animal = Sexe;
            Animal.id_category = idcat;
                //enregistrement dans la base 
                db.SaveChanges();
            }
        }

        //Supprimer un animal
        public void Supprimer (int ID)
        {
            Animal = new animal();
            Animal = db.animals.SingleOrDefault(s => s.id_animal == ID);
            //si le client est existe
            if (Animal != null)
            {
                //Supprimer le client
                db.animals.Remove(Animal);
                //enregistrement sur la base de données
                db.SaveChanges();
            }
        }
    }
}
