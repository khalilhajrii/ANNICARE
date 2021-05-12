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
    public partial class client_adopt : Form
    {
        private dbadoptcontext db;
        internal object dataanimal;

        public client_adopt()
        {
            InitializeComponent();
            db = new dbadoptcontext();
        }

        //remlissage de datagrid par client
        public void Remplirgridclient()
        {
            db = new dbadoptcontext();
            foreach (var P in db.clients)
            {
                gridclient.Rows.Add(P.id_client, P.nom_client, P.telephone_client, P.sexe_client, P.email_client, P.adresse_client, P.pays_client);
            }
        }

        public void dataanimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void client_adopt_Load(object sender, EventArgs e)
        {
            Remplirgridclient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridclient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
