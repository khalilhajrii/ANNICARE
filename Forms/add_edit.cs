using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace application_adoption.Forms
{
    public partial class add_edit : Form
    {
        private UserControl clientu;

        public add_edit(UserControl clientcontrol)
        {
            InitializeComponent();
            this.clientu = clientcontrol;
        }
        //verification des champs obligatoire
        string verifList()
        {
            if (txtnomc.Text == "" || txtnomc.Text == "Nom et Prenom")
            {
                return "Champ Nom est obligatoire";
            }
            if (txtphone.Text == "" || txtphone.Text == "Telephone")
            {
                return "Champ telephone est obligatoire";
            }
            if(txtsexe.Text == "" || txtsexe.Text == "Sexe")
            {
                return "Champ Sexe est obligatoire";
            }
            if (txtemail.Text != "" || txtemail.Text == "Email")
            {
                try
                {
                    //verification de la forme d'un email si valide ou non
                    new MailAddress(txtemail.Text);
                }
                catch (Exception)
                {
                    return "Champ Email est obligatoire";
                }
            }
            if (txtadress.Text == "" || txtadress.Text == "Adresse")
            {
                return "Champ Adresse est obligatoire";
            }
            if (txtpays.Text == "" || txtpays.Text == "Pays")
            {
                return "Champ Pays est obligatoire";
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnomc_Enter(object sender, EventArgs e)
        {
            if(txtnomc.Text =="Nom et Prenom")
            {
                txtnomc.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

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

        private void txtpays_Enter(object sender, EventArgs e)
        {
            if (txtpays.Text == "Pays")
            {
                txtpays.Text = "";
            }
        }

        private void txtnomc_Leave(object sender, EventArgs e)
        {
            if(txtnomc.Text == "")
            {
                txtnomc.Text = "Nom et Prenom";
            }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "Telephone";
            }
        }

        private void txtsexe_Leave(object sender, EventArgs e)
        {
            if (txtsexe.Text == "")
            {
                txtsexe.Text = "Sexe";
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Email";
            }
        }

        private void txtadress_Leave(object sender, EventArgs e)
        {
            if (txtadress.Text == "")
            {
                txtadress.Text = "Adresse";
            }
        }

        private void txtpays_Leave(object sender, EventArgs e)
        {
            if (txtpays.Text == "")
            {
                txtpays.Text = "Pays";
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        public int select_id;
        private void button2_Click(object sender, EventArgs e)
        {
            if (verifList() != null)
            {
                MessageBox.Show(verifList());
            }

            else
            if(titre.Text == "Ajouter client")
            {



                Class.Class_client Cl = new Class.Class_client();
                if (Cl.Ajouter(txtnomc.Text, int.Parse(txtphone.Text), txtsexe.Text, txtemail.Text, txtadress.Text, txtpays.Text) == true)
                {
                    MessageBox.Show("Client ajouter avec succés", "ajout", MessageBoxButtons.OK);
                        //actualisation de datagridview
                    (clientu as List_client).actualiser();
                }
                else
                {
                    MessageBox.Show("Le client est deja existe", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                Class.Class_client C1 = new Class.Class_client();
                C1.Modifier(select_id, txtnomc.Text, int.Parse(txtphone.Text), txtsexe.Text, txtemail.Text, txtadress.Text, txtpays.Text);
                MessageBox.Show("Client a été modifié", "modification", MessageBoxButtons.OK);
                //actualisation de datagridview
                (clientu as List_client).actualiser();

            }
        }

        private void add_edit_Load(object sender, EventArgs e)
        {

        }
    }
}
