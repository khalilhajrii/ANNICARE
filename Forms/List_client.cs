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
    public partial class List_client : UserControl
    {
        private static List_client user;
        private dbadoptcontext db;
        //creation d'une instance de user controle
        public static List_client instance
        {
            get
            {
                if(user == null) 
                {
                    user = new List_client();
                }
                return user;
            }
        }
        public List_client()
        {
            InitializeComponent();
            db = new dbadoptcontext();
            //desactivation des textbox 
        }

        //l'ajout des données dans le DataGridView
        public void actualiser()
        {
            db = new dbadoptcontext();
            //vider le datagridview si il ya des données
            dataanimal.Rows.Clear();
            //ajout dans les Rows
            foreach(var client in db.clients)
            {
                dataanimal.Rows.Add(false, client.id_client, client.nom_client, client.telephone_client, client.sexe_client, client.email_client, client.adresse_client, client.pays_client);
            }
        }

        //verification des lignes selectionnes
        public String selection()
        {
            int nbrselect = 0;
            for (int i = 0; i < dataanimal.Rows.Count; i++)
            {
                if ((bool)dataanimal.Rows[i].Cells[0].Value == true)
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

        private void List_client_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            db = new dbadoptcontext();
            //recuperation de listes des clients
            var listclient = db.clients.ToList();
            if(txtsearch.Text != null)
            {

                switch (comboanimal.Text)
                {
                    case "Nom":
                //StringComparison.CurrentCultureIgnoreCase soit j'ai ecrit en majus ou miniscule
                //-1 existe dans la base de données
                listclient = listclient.Where(s => s.nom_client.IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                 listclient = listclient.Where(s => s.telephone_client.ToString().IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Sexe":
                        listclient = listclient.Where(s => s.sexe_client.ToString().IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listclient = listclient.Where(s => s.email_client.ToString().IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Adresse":
                        listclient = listclient.Where(s => s.adresse_client.ToString().IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listclient = listclient.Where(s => s.pays_client.ToString().IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }

            }
            //il faut vider la liste 
            dataanimal.Rows.Clear();
            //l'ajout de la list dans le datagidview
            foreach (var list in listclient)
            {
                dataanimal.Rows.Add(false, list.id_client, list.nom_client, list.telephone_client, list.sexe_client, list.email_client, list.adresse_client, list.pays_client);
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Rechercher")
            {
                txtsearch.Text = "";
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            add_edit ae = new add_edit(this);
            ae.ShowDialog();
        }
        
        //lID selectionné
        private void button1_Click(object sender, EventArgs e)
        {
            Forms.add_edit addedit = new Forms.add_edit(this);
            if (selection() == null) 
            { 
                //affichage de l'informations par client
                for(int i=0;i < dataanimal.Rows.Count; i++)
                {
                    if ((bool)dataanimal.Rows[i].Cells[0].Value == true)
                    {
                        addedit.select_id = (int)dataanimal.Rows[i].Cells[1].Value;
                        addedit.txtnomc.Text = dataanimal.Rows[i].Cells[2].Value.ToString();
                        addedit.txtphone.Text = dataanimal.Rows[i].Cells[3].Value.ToString();
                        addedit.txtsexe.Text = dataanimal.Rows[i].Cells[4].Value.ToString();
                        addedit.txtemail.Text = dataanimal.Rows[i].Cells[5].Value.ToString();
                        addedit.txtadress.Text = dataanimal.Rows[i].Cells[6].Value.ToString();
                        addedit.txtpays.Text = dataanimal.Rows[i].Cells[7].Value.ToString();
                    }
                }
            addedit.titre.Text = "Modifier client";
            addedit.ShowDialog();
            }
            else
            {
                MessageBox.Show(selection(),"modification",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class.Class_client Sup = new Class.Class_client();
            //suppression des clients selctionnées
            int select = 0;
            for(int i=0; i<dataanimal.Rows.Count; i++)
            {
                if((bool)dataanimal.Rows[i].Cells[0].Value == true)
                {
                    //combien de ligne a ete selectionné
                    select++; 

                }

            }
            if(select == 0)
            {
                MessageBox.Show("Selecter un champ a supprimer SVP");
            }
            else
            {
                DialogResult S = MessageBox.Show("Voulez vous vraiment supprimer ?", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(S == DialogResult.Yes)
                {
                    for (int i = 0; i < dataanimal.Rows.Count; i++)
                    {
                        if ((bool)dataanimal.Rows[i].Cells[0].Value == true)
                        {
                            Sup.Supprimer(int.Parse(dataanimal.Rows[i].Cells[1].Value.ToString()));
                        }

                    }
                    //actualisation de datagridview
                    actualiser();
                    MessageBox.Show("Client suprimé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression anulé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
