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
    public partial class Category_list : UserControl
    {
        private static Category_list categorylist;
        private dbadoptcontext db;

        //creation d'une instance de l'interface userControl category List
        public static Category_list Instance
        {
            get
            {
                if (categorylist == null)
                {
                    categorylist = new Category_list();
                }
                return categorylist;
            }
        }
        public Category_list()
        {
            InitializeComponent();
        }

        //l'ajout des données dans le DataGridView
        public void actualiser()
        {
            db = new dbadoptcontext();
            //vider le datagridview si il ya des données
            gridcategory.Rows.Clear();
            //ajout dans les Rows
            foreach (var category in db.categories)
            {
                gridcategory.Rows.Add(false, category.id_category, category.name_category);
            }
        }

        //verification des lignes selectionnes
        public String selection()
        {
            int nbrselect = 0;
            for (int i = 0; i < gridcategory.Rows.Count; i++)
            {
                if ((bool)gridcategory.Rows[i].Cells[0].Value == true)
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

        private void Category_list_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_category frmanimal = new Forms.Add_edit_category(this);
            frmanimal.ShowDialog();
        }

        private void btnmodcategory_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_category addedit = new Forms.Add_edit_category(this);
            if (selection() == null)
            {
                //affichage de l'informations par client
                for (int i = 0; i < gridcategory.Rows.Count; i++)
                {
                    if ((bool)gridcategory.Rows[i].Cells[0].Value == true)
                    {
                        addedit.ID_selected = (int)gridcategory.Rows[i].Cells[1].Value;
                        addedit.txtnomc.Text = gridcategory.Rows[i].Cells[2].Value.ToString();
                    }
                }
                addedit.titreacat.Text = "Modifier client";
                addedit.ShowDialog();
            }
            else
            {
                MessageBox.Show(selection(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndeletecategory_Click(object sender, EventArgs e)
        {
            Class.Class_category Sup = new Class.Class_category();
            //suppression des clients selctionnées
            int select = 0;
            for (int i = 0; i < gridcategory.Rows.Count; i++)
            {
                if ((bool)gridcategory.Rows[i].Cells[0].Value == true)
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
                    for (int i = 0; i < gridcategory.Rows.Count; i++)
                    {
                        if ((bool)gridcategory.Rows[i].Cells[0].Value == true)
                        {
                            Sup.Supprimer(int.Parse(gridcategory.Rows[i].Cells[1].Value.ToString()));
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

        private void txtrecherche1_TextChanged(object sender, EventArgs e)
        {
            db = new dbadoptcontext();
            //recuperation de listes des clients
            var listcat = db.categories.ToList();
            if (txtrecherche1.Text != null)
            {

                switch (combocategory.Text)
                {
                    case "Nom":
                        //StringComparison.CurrentCultureIgnoreCase soit j'ai ecrit en majus ou miniscule
                        //-1 existe dans la base de données
                        listcat = listcat.Where(s => s.name_category.IndexOf(txtrecherche1.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }

            }
            //il faut vider la liste 
            gridcategory.Rows.Clear();
            //l'ajout de la list dans le datagidview
            foreach (var list in listcat)
            {
                gridcategory.Rows.Add(false, list.id_category, list.name_category);
            }
        }

        private void txtrecherche1_Enter(object sender, EventArgs e)
        {
            if(txtrecherche1.Text == "Rechercher")
            {
                txtrecherche1.Text = "";
            }
        }

        private void txtrecherche1_Leave(object sender, EventArgs e)
        {
            if(txtrecherche1.Text == "")
            {
                txtrecherche1.Text = "Rechercher";
            }
        }
    }
}
