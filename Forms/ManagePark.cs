using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkSystem.Forms
{
    public partial class Manage_Park : Form
    {
        DBSYSfinalEntities db;
        public Manage_Park()
        {
            InitializeComponent();
            db = new DBSYSfinalEntities();
        }

        private void ManagePark_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Parking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
