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
    public partial class List_adopt : UserControl
    {
        private static List_adopt adoptlist;
        private dbadoptcontext db;

        //creation d'une instance 
        public static List_adopt Instance
        {
            get
            {
                if (adoptlist == null)
                {
                    adoptlist = new List_adopt();
                }
                return adoptlist;
            }
        }
        public List_adopt()
        {
            InitializeComponent();
            db = new dbadoptcontext();
        }

        private void List_adopt_Load(object sender, EventArgs e)
        {

        }

        private void btnaddadopt_Click(object sender, EventArgs e)
        {
            Forms.Frm_detail_adop details = new Forms.Frm_detail_adop();
            details.ShowDialog();
        }

       
    }
}
