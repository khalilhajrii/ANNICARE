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
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
            formmenu.Size = new Size(223, 450);
            showbar.Visible = false;
        }

       //desactivation de menu hors authentification
       public void Desactiver()
        {
            btnclient.Enabled = false;
            btnanimal.Enabled = false;
            btncategory.Enabled = false;
            btnadopt.Enabled = false;
            btndisconnect.Enabled = false;
            btnuser.Enabled = false;
            //lors de connection la button disparu
            btnconnect.Visible = true;
        }

        //activation de menu apres authentification
        public void Activer()
        {
            btnclient.Enabled = true;
            btnanimal.Enabled = true;
            btncategory.Enabled = true;
            btnadopt.Enabled = true;
            btnuser.Enabled = true;
            btndisconnect.Enabled = true;
            //lors de deconntion le button apercu
            btnconnect.Enabled = false;
            showbar.Visible = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!pnlshow.Controls.Contains(List_client.instance))
            {
                pnlshow.Controls.Add(List_client.instance);

            }
            else
            {
                List_client.instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(formmenu.Width== 223)
            {
                formmenu.Size = new Size(61, 450);
            }
            else
            {
                formmenu.Size = new Size(223, 450);
            }
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showbar.Size = new Size(284, 147);
            showbar.Visible = !showbar.Visible;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //l'affichage de partie connexion
            //this pour dire cette menu
            connexion fc = new connexion(this);
            fc.ShowDialog();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {
            Desactiver();
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            Desactiver();
        }
    }
}
