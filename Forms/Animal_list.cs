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
    public partial class Animal_list : UserControl
    {
        private static Animal_list animallist;
        private dbadoptcontext db;

        public static Animal_list Instance
        {
            get
            {
                if(animallist == null)
                {
                    animallist = new Animal_list();
                }
                return animallist;
            }
        }
        public Animal_list()
        {
            InitializeComponent();
            db = new dbadoptcontext();
        }
        //actualisation de datagrid
        public void actualiser()
        {
            db = new dbadoptcontext();
            //vider le datagridview si il ya des données
            gridanimal.Rows.Clear();
            //ajout dans les Rows
            foreach (var animal in db.animals)
            {
                gridanimal.Rows.Add(false, animal.id_animal, animal.nom_animal, animal.quantite_animal, animal.type_animal, animal.sexe_animal, animal.id_category);
            }
        }

        //selection des Id
        public String selection()
        {
            int nbrselect = 0;
            for (int i = 0; i < gridanimal.Rows.Count; i++)
            {
                if ((bool)gridanimal.Rows[i].Cells[0].Value == true)
                {
                    nbrselect++;
                }
            }
            if (nbrselect == 0)
            {
                return "Selectionner le nombre de lignes a modifier SVP !";
            }
            if (nbrselect > 1)
            {
                return "Selectionner un seul ligne SVP !";
            }


            return null;
        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_animal frmanimal = new Forms.Add_edit_animal(this);
            frmanimal.ShowDialog();
        }

        private void comboclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if(txtrecherche.Text == "Rechercher")
            {
                txtrecherche.Text = "";

            }
        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {
            if(txtrecherche.Text == "")
            {
                txtrecherche.Text = "Rechercher";
            }
        }

        private void btnmodanimal_Click(object sender, EventArgs e)
        {
            animal Animal = new animal();
            if(selection() != null)
            {
                MessageBox.Show(selection(), "selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Forms.Add_edit_animal frmanimal = new Forms.Add_edit_animal(this);
                frmanimal.titreanimal.Text = "Modifier Animal";
                for(int i=0; i<gridanimal.Rows.Count; i++)
                {
                    //si la ligne est selectionné
                    if((bool)gridanimal.Rows[i].Cells[0].Value == true)
                    {
                        if(Animal != null)
                        {

                        
                        frmanimal.ID_animal = (int)gridanimal.Rows[i].Cells[1].Value;
                        frmanimal.txtnoma.Text = gridanimal.Rows[i].Cells[2].Value.ToString();
                        frmanimal.txtquantité.Text = gridanimal.Rows[i].Cells[3].Value.ToString();
                        frmanimal.txttype.Text = gridanimal.Rows[i].Cells[4].Value.ToString();
                        frmanimal.txtsexea.Text = gridanimal.Rows[i].Cells[5].Value.ToString();
                        frmanimal.combocategoriey.Text = gridanimal.Rows[i].Cells[6].Value.ToString();
                        }
                    }
                }
                frmanimal.ShowDialog();
            }
            
        }

        private void Animal_list_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btndeleteanimal_Click(object sender, EventArgs e)
        {
            Class.Class_animal supp = new Class.Class_animal();
            //suppression d'un animal selectionné
            int select = 0;
            for(int i = 0; i<gridanimal.Rows.Count; i++)
            {
                if ((bool)gridanimal.Rows[i].Cells[0].Value == true)
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
                    for (int i = 0; i < gridanimal.Rows.Count; i++)
                    {
                        if ((bool)gridanimal.Rows[i].Cells[0].Value == true)
                        {
                            supp.Supprimer(int.Parse(gridanimal.Rows[i].Cells[1].Value.ToString()));
                        }

                    }
                    //actualisation de datagridview
                    actualiser();
                    MessageBox.Show("Animal suprimé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression anulé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbadoptcontext();
            //recuperation de listes des clients
            var listanimal = db.animals.ToList();
            if (txtrecherche.Text != null)
            {

                switch (comboanimal.Text)
                {
                    case "Nom":
                        //StringComparison.CurrentCultureIgnoreCase soit j'ai ecrit en majus ou miniscule
                        //-1 existe dans la base de données
                        listanimal = listanimal.Where(s => s.nom_animal.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Categorie":
                        listanimal = listanimal.Where(s => s.id_category.ToString().IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                   
                }

            }
            //il faut vider la liste 
            gridanimal.Rows.Clear();
            //l'ajout de la list dans le datagidview
            foreach (var list in listanimal)
            {
                gridanimal.Rows.Add(false, list.id_animal, list.nom_animal, list.quantite_animal, list.type_animal, list.sexe_animal, list.id_category);
            }
        }
    }
}
