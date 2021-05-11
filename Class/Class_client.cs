using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_adoption.Class
{
    class Class_client
    {
        private dbadoptcontext db = new dbadoptcontext();
        private client Client;

        //fonction ajouter client
        public bool Ajouter (string Nom, int Tel, string Sexe, string Email, string Adresse, string Pays)
        {
            Client = new client();
            Client.nom_client = Nom;
            Client.telephone_client = Tel;
            Client.sexe_client = Sexe;
            Client.email_client = Email;
            Client.adresse_client = Adresse;
            Client.pays_client = Pays;

            //si le client n'existe pas dans la base de données
            var exist = db.clients.SingleOrDefault(s => s.nom_client == Nom);
            if(exist == null)
            {
                //donc l'ajout dans la base de données
                db.clients.Add(Client); 
                //puis l"enregistrement dans la base de données
                db.SaveChanges();
                return true;
            }
            
            else
            {
                return false;
            }
        }
        //fonction modifier client
        public void Modifier(int ID, string Nom, int Tel, string Sexe, string Email, string Adresse, string Pays)
        {
            Client = new client();
            Client = db.clients.SingleOrDefault(s => s.id_client == ID);
            //si le client existe dans la base de données
            if(Client != null) 
            { 
                //initialisation des nouveaux champs
            Client.nom_client = Nom;
            Client.telephone_client = Tel;
            Client.sexe_client = Sexe;
            Client.email_client = Email;
            Client.adresse_client = Adresse;
            Client.pays_client = Pays;
                //enregistrement dans la base de données
                db.SaveChanges();
            }

        }
        //fonction supprimer clent
        public void Supprimer (int ID)
        {
            Client = new client();
            Client = db.clients.SingleOrDefault(s => s.id_client == ID);
            //si le client est existe
            if(Client != null)
            {
                //Supprimer le client
                db.clients.Remove(Client);
                //enregistrement sur la base de données
                db.SaveChanges();
            }
        }
    }

}
