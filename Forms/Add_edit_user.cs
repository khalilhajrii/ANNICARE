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
    public partial class Add_edit_user : Form
    {
        private UserControl userli;
        public Add_edit_user(UserControl usercont)
        {
            InitializeComponent();
            this.userli = usercont;
        }
        
        //verifications des champs obligatoires
        public string verif()
        {
            if(txtnom.Text == "" || txtnom.Text == "Nom d'utilisateur")
            {
                return "Champ nom d'utilisateur est obligatoire";
            }
            if(txtpass.Text == "" || txtpass.Text == "Mot de passe")
            {
                return "Champ mot de passe est obligatoire";
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if(txtnom.Text == "Nom d'utilisateur")
            {
                txtnom.Text = "";
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if(txtnom.Text == "")
            {
                txtnom.Text = "Nom d'utilisateur";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Mot de passe")
            {
                txtpass.Text = "";
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Mot de passe";
            }
        }

        public int select_id;
        private void button2_Click(object sender, EventArgs e)
        {
            if(verif() != null)
            {
                MessageBox.Show(verif(), "verification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            if(titreuser.Text == "Ajouter utilisateur")
            {
                Class.Class_user C = new Class.Class_user();
                if(C.Ajouter(txtnom.Text, txtpass.Text) == true)
                {
                    MessageBox.Show("Utilisateur ajouter avec succés", "ajout", MessageBoxButtons.OK);
                    //actualisation de datagridview
                    Close();
                    (userli as List_users).actualiser();
                }
                else
                {
                    MessageBox.Show("L' utilisateur est deja existe", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Class.Class_user C1 = new Class.Class_user();
                C1.Modifier(select_id, txtnom.Text, txtpass.Text);
                MessageBox.Show("Client a été modifié", "modification", MessageBoxButtons.OK);
                //actualisation de datagridview
                Close();
                (userli as List_users).actualiser();
            }
        }
    }
}
