using SparkSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkSystem
{
    public partial class Frm_Admin : Form
    {
        DBSYSfinalEntities db;
        public Frm_Admin()
        {
            InitializeComponent();
            db = new DBSYSfinalEntities();
        }



        public void loadAccs()
        {
            dgv_View.DataSource = db.UserAccount.ToList();
        }

        public void loadParking()
        {
            dgv_View.DataSource = db.UserParking.ToList();
        }

        private void btnuserlogs_Click(object sender, EventArgs e)
        {
            loadAccs();
        }

        private void btnParkinglogs_Click(object sender, EventArgs e)
        {
            loadParking();
        }
    }
}
