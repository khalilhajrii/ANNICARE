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
    public partial class connexion : Form
    {

        private Form menu_form;
        //recuperation du class class_connexion
        Class.class_connexion c = new Class.class_connexion();
        public connexion(Form Menu)
        {
            InitializeComponent();
            this.menu_form = Menu;
        }
        //verification des champs obligatoire
        string verif()
        {
            if(txtnom.Text == "" || txtnom.Text == "Nom d'utilisateur")
            {
                return "Entrer votre nom d'utilisateur svp";
            }
            if(txtpass.Text == "" || txtpass.Text == "Mot de passe")
            {
                return "Entrer votre mot de passe SVP";
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text == "Mot de passe") {
                txtpass.Text = "Mot de passe";
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if(txtnom.Text == "Nom d'utilisateur")
            {
                txtnom.Text = "";
                
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
            if(txtpass.Text == "")
            {
                txtpass.Text = "Mot de passe";
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if(txtnom.Text == "")
            {
                txtnom.Text = "Nom d'utilisateur";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(verif() == null)
            {
                //si notre utilisateur est existe
                if(c.Valid(txtnom.Text,txtpass.Text) == true)
                {
                    MessageBox.Show("connexion validé", "connexion", MessageBoxButtons.OK);
                    //appel a la fonction activer pour activer les buttons apres la connexion
                    (menu_form as form_menu).Activer();
                    //fermeture automatique de form connexion
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("connexion invalide", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(verif(), "obligation", MessageBoxButtons.OK);
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
