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
    public partial class Frm_Teacher : Form
    {
        public Frm_Teacher()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Manage_Park frm = new Manage_Park();
            frm.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Booking_Teacher frm = new Booking_Teacher();
            frm.ShowDialog();
        }
    }
}
