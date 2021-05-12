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
    public partial class Frm_detail_adop : Form
    {
        private dbadoptcontext db;
        public Frm_detail_adop()
        {
            InitializeComponent();
            db = new dbadoptcontext();
        }

        //Fonction remplir datagrid animal
        public void Remplirgridanimal()
        {
            db = new dbadoptcontext();
            foreach (var P in db.animals)
            {
                gridanimaldetail.Rows.Add(P.id_animal, P.nom_animal, P.quantite_animal);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_detail_adop_Load(object sender, EventArgs e)
        {
            Remplirgridanimal();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            db = new dbadoptcontext();
            //recuperation de listes des clients
            var listanimal = db.animals.ToList();

            //StringComparison.CurrentCultureIgnoreCase soit j'ai ecrit en majus ou miniscule
            //-1 existe dans la base de données
            listanimal = listanimal.Where(s => s.nom_animal.IndexOf(txtsearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

            gridanimaldetail.Rows.Clear();

            foreach (var P in listanimal)
            {
                gridanimaldetail.Rows.Add(P.id_animal, P.nom_animal, P.quantite_animal);
            }




        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Rechercher")
            {
                txtsearch.Text = "";
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "Rechercher";
            }
        }

        private void txtnomc_Enter(object sender, EventArgs e)
        {
            if (txtnomc.Text == "Nom et Prenom")
            {
                txtnomc.Text = "";
            }
        }

        private void txtnomc_Leave(object sender, EventArgs e)
        {
            if (txtnomc.Text == "")
            {
                txtnomc.Text = "Nom";
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "Telephone")
            {
                txtphone.Text = "";
            }
        }

        private void txtsexe_Enter(object sender, EventArgs e)
        {
            if (txtsexe.Text == "Sexe")
            {
                txtsexe.Text = "";
            }
        }

        private void txtsexe_Leave(object sender, EventArgs e)
        {
            if (txtsexe.Text == "")
            {
                txtsexe.Text = "Sexe";
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Email")
            {
                txtemail.Text = "";
            }
        }

        private void txtadress_Enter(object sender, EventArgs e)
        {
            if (txtadress.Text == "Adresse")
            {
                txtadress.Text = "";
            }
        }

        private void txtadress_Leave(object sender, EventArgs e)
        {
            if (txtadress.Text == "")
            {
                txtadress.Text = "Adresse";
            }
        }

        private void txtpays_Enter(object sender, EventArgs e)
        {
            if (txtpays.Text == "Pays")
            {
                txtpays.Text = "";
            }
        }

        private void gridanimaldetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.client_adopt CA = new Forms.client_adopt();
            CA.ShowDialog();
            //affichage informations clients
            txtnomc.Text = CA.gridclient.CurrentRow.Cells[1].Value.ToString();
            txtphone.Text = CA.gridclient.CurrentRow.Cells[2].Value.ToString();
            txtsexe.Text = CA.gridclient.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = CA.gridclient.CurrentRow.Cells[4].Value.ToString();
            txtadress.Text = CA.gridclient.CurrentRow.Cells[5].Value.ToString();
            txtpays.Text = CA.gridclient.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
