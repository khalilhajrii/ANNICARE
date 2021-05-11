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
    public partial class Add_edit_animal : Form
    {
        private dbadoptcontext db;
        private UserControl useranimal;
        public Add_edit_animal(UserControl user)
        {
            InitializeComponent();
            db = new dbadoptcontext();
            this.useranimal = user;
            //affichages des categories dans combobox
            combocategoriey.DataSource = db.categories.ToList();
            //filtrages par noms
            combocategoriey.DisplayMember = "name_category";
            combocategoriey.ValueMember = "id_category";
        }

        string verif()
        {
            if(txtnoma.Text == "" || txtnoma.Text == "Nom animal")
            {
                return "Champ Nom est obligatoire";
            }
            if (txtquantité.Text == "" || txtquantité.Text == "Quantité")
            {
                return "Champ Quantité est obligatoire";
            }
            if (txtsexea.Text == "" || txtsexea.Text == "Sexe")
            {
                return "Champ Sexe est obligatoire";
            }
            if (txttype.Text == "" || txttype.Text == "Type")
            {
                return "Champ Type est obligatoire";
            }
            if (combocategoriey.Text == "")
            {
                return "Champ categorie est obligatoire";
            }
            return null;
        }
        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void combocategoriey_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnoma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnoma_Leave(object sender, EventArgs e)
        {
            if(txtnoma.Text == "")
            {
                txtnoma.Text = "Nom";
            }
        }

        private void txtquantité_Enter(object sender, EventArgs e)
        {
            if(txtquantité.Text == "Quantité")
            {
                txtquantité.Text = "";
            }
        }

        private void txtquantité_Leave(object sender, EventArgs e)
        {
            if (txtquantité.Text == "")
            {
                txtquantité.Text = "Qantité";
            }
        }

        private void txtnoma_Enter(object sender, EventArgs e)
        {
            if (txtnoma.Text == "Nom animal")
            {
                txtnoma.Text = "";
            }
        }

        private void txtsexea_Enter(object sender, EventArgs e)
        {
            if(txtsexea.Text == "Sexe")
            {
                txtsexea.Text = "";
            }
        }

        private void txtsexea_Leave(object sender, EventArgs e)
        {
            if (txtsexea.Text == "")
            {
                txtsexea.Text = "Sexe";
            }
        }

        private void txttype_Enter(object sender, EventArgs e)
        {
            if(txttype.Text == "Type")
            {
                txttype.Text = "";
            }
        }

        private void txttype_Leave(object sender, EventArgs e)
        {
            if (txttype.Text == "")
            {
                txttype.Text = "Type";
            }
        }

        private void Add_edit_animal_Load(object sender, EventArgs e)
        {

        }

        public int ID_animal;
        private void button2_Click(object sender, EventArgs e)
        {
            if(verif() != null)
            {
                MessageBox.Show(verif(), "verification", MessageBoxButtons.OK);
            }
            else { 
            {
                 if(titreanimal.Text == "Ajouter animal") { 
                Class.Class_animal A = new Class.Class_animal();
                        if (A.Ajouter(txtnoma.Text, int.Parse(txtquantité.Text), txttype.Text, txtsexea.Text, Convert.ToInt32(combocategoriey.SelectedValue)) == true)
                        {
                            MessageBox.Show("Animal ajouter avec succés", "ajout", MessageBoxButtons.OK);
                            //actualisation de datagrid
                            (useranimal as Animal_list).actualiser();
                        }
                        else
                        {
                            MessageBox.Show("Animal est deja existe", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                 //modification
                    else
                    {
                        Class.Class_animal A1 = new Class.Class_animal();
                        A1.Modifier(ID_animal, txtnoma.Text, int.Parse(txtquantité.Text), txttype.Text, txtsexea.Text, Convert.ToInt32(combocategoriey.SelectedValue));
                        MessageBox.Show("Animal modifée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //actualisation de data grid
                        (useranimal as Animal_list).actualiser();
                        Close();
                    }
                }
            }
        }
    }
}
