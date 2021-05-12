using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_adoption.Forms
{
    public partial class List_users : UserControl
    {
        private static List_users users;
        private dbadoptcontext db;

        //creation d'une instance de user controle
        public static List_users instance
        {
            get
            {
                if (users == null)
                {
                    users = new List_users();
                }
                return users;
            }
        }
        public List_users()
        {
            InitializeComponent();
            db = new dbadoptcontext();
        }

        //l'ajout des données dans le DataGridView
        public void actualiser()
        {
            db = new dbadoptcontext();
            //vider le datagridview si il ya des données
            griduser.Rows.Clear();
            //ajout dans les Rows
            foreach (var user in db.utilisateurs)
            {
                griduser.Rows.Add(false, user.id_utilisateur, user.nom_utilisateur, user.mot_de_passe);
            }
        }

        //Selection des lignes pour modifier
        public String selection()
        {
            int nbrselect = 0;
            for (int i = 0; i < griduser.Rows.Count; i++)
            {
                if ((bool)griduser.Rows[i].Cells[0].Value == true)
                {
                    nbrselect++;
                }
            }
                if(nbrselect == 0)
                {
                    return "Selectionner le nombre de lignes a modifier SVP !";
                }
                if (nbrselect > 1)
                {
                    return "Selectionner un seul ligne SVP !";
                }

            
            return null;
        }

        private void List_users_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_user addedituser = new Add_edit_user(this);
            addedituser.ShowDialog();
        }

        private void moduser_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_user addedit = new Forms.Add_edit_user(this);
            if (selection() == null)
            {
                //affichage de l'informations par client
                for (int i = 0; i < griduser.Rows.Count; i++)
                {
                    if ((bool)griduser.Rows[i].Cells[0].Value == true)
                    {
                        addedit.select_id = (int)griduser.Rows[i].Cells[1].Value;
                        addedit.txtnom.Text = griduser.Rows[i].Cells[2].Value.ToString();
                        addedit.txtpass.Text = griduser.Rows[i].Cells[3].Value.ToString();
                    }
                }
                addedit.titreuser.Text = "Modifier client";
                addedit.ShowDialog();
            }
            else
            {
                MessageBox.Show(selection(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteuuser_Click(object sender, EventArgs e)
        {
            Class.Class_user Sup = new Class.Class_user();
            //suppression des clients selctionnées
            int select = 0;
            for (int i = 0; i < griduser.Rows.Count; i++)
            {
                if ((bool)griduser.Rows[i].Cells[0].Value == true)
                {
                    //combien de ligne a ete selectionné
                    select++;

                }

            }
            if (select == 0)
            {
                MessageBox.Show("Selecter un champ a supprimer SVP");
            }
            else
            {
                DialogResult S = MessageBox.Show("Voulez vous vraiment supprimer ?", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (S == DialogResult.Yes)
                {
                    for (int i = 0; i < griduser.Rows.Count; i++)
                    {
                        if ((bool)griduser.Rows[i].Cells[0].Value == true)
                        {
                            Sup.Supprimer(int.Parse(griduser.Rows[i].Cells[1].Value.ToString()));
                        }

                    }
                    //actualisation de datagridview
                    actualiser();
                    MessageBox.Show("Utilisateur suprimé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression anulée", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            db = new dbadoptcontext();
            //recuperation de listes des clients
            var listusers = db.utilisateurs.ToList();
            if (txtsearch.Text != null)
            {

                switch (combouser.Text)
                {
                    case "Nom":
                        //StringComparison.CurrentCultureIgnoreCase soit j'ai ecrit en majus ou miniscule
                        //-1 existe dans la base de données
                        listusers = listusers.Where(s => s.nom_utilisateur.IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }

            }
            //il faut vider la liste 
            griduser.Rows.Clear();
            //l'ajout de la list dans le datagidview
            foreach (var list in listusers)
            {
                griduser.Rows.Add(false, list.id_utilisateur, list.nom_utilisateur, list.mot_de_passe);
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if(txtsearch.Text == "Rechercher")
            {
                txtsearch.Text = "";
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if(txtsearch.Text == "")
            {
                txtsearch.Text = "Rechercher";
            }
        }
    }
}
