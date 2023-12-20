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
    public partial class Frm_Student : Form
    {
        public Frm_Student()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Booking_Student frm = new Booking_Student();
            frm.Show();
            this.Close();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Manage_Park frm = new Manage_Park();
            frm.Show();
        }
    }
}
