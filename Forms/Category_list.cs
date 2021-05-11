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
    public partial class Category_list : UserControl
    {
        private static Category_list categorylist;
        private dbadoptcontext db;

        //creation d'une instance de l'interface userControl category List
        public static Category_list Instance
        {
            get
            {
                if (categorylist == null)
                {
                    categorylist = new Category_list();
                }
                return categorylist;
            }
        }
        public Category_list()
        {
            InitializeComponent();
        }

        private void Category_list_Load(object sender, EventArgs e)
        {

        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_category frmanimal = new Forms.Add_edit_category();
            frmanimal.ShowDialog();
        }

        private void btnmodcategory_Click(object sender, EventArgs e)
        {
            Forms.Add_edit_category addedit = new Forms.Add_edit_category();
            addedit.titreacat.Text = "Modifier categorie";
            addedit.ShowDialog();
        }
    }
}
