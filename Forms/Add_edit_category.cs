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
    public partial class Add_edit_category : Form
    {
        public Add_edit_category()
        {
            InitializeComponent();
        }

        string verif()
        {
            if(txtnomc.Text == "" || txtnomc.Text == "Nom categorie")
            {
                return "Champ nom categorie est obligatoire";
            }
            return null;
        }

        private void Add_edit_category_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnoma_Enter(object sender, EventArgs e)
        {
            if(txtnomc.Text == "Nom categorie")
            {
                txtnomc.Text = "";
            }
        }

        private void txtnomc_Leave(object sender, EventArgs e)
        {
            if(txtnomc.Text == "")
            {
                txtnomc.Text = "Nom categorie";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(verif() != null)
            {
                MessageBox.Show(verif(), "verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if(titreacat.Text == "Ajouter categorie")
            {
                //appel a la fonction ajouter categorie
                Class.Class_category C1 = new Class.Class_category();
                if(C1.Ajouter(txtnomc.Text) == true)
                {
                    MessageBox.Show("Categorie ajouter avec succés", "ajout", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Categorie est deja existe", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
    }
}
