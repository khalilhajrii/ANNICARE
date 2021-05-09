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
        }

        private void List_client_Load(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

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
            add_edit ae = new add_edit();
            ae.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_edit ae = new add_edit();
            ae.ShowDialog();
        }
    }
}
