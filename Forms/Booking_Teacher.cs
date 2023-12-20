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
    public partial class Booking_Teacher : Form
    {
        DBSYSfinalEntities db;
        public Booking_Teacher()
        {
            InitializeComponent();
            db = new DBSYSfinalEntities();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "********************************************\n";
            txtResult.Text += "*******         Parking Receipt      *******\n";
            txtResult.Text += "********************************************\n";
            txtResult.Text += "Date : " + DateTime.Now + "\n\n";
            txtResult.Text += "Name : " + txtName.Text + "\n\n";
            txtResult.Text += "Plate number : " + txtPlatenum.Text + "\n\n";
            txtResult.Text += "Vechile Type : " + txtVecType.Text + "\n\n";
            txtResult.Text += "Gate number : " + txtGateNum.Text + "\n\n";
            txtResult.Text += "Parking number : " + txtParkNum.Text + "\n\n";
            txtResult.Text += "\n\n\n";
            txtResult.Text += "***   In spark we make parking easy   ***\n";
            txtResult.Text += "********************************************\n";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                errorProvider.SetError(txtName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPlatenum.Text))
            {
                errorProvider.SetError(txtPlatenum, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtParkNum.Text))
            {
                errorProvider.SetError(txtParkNum, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtVecType.Text))
            {
                errorProvider.SetError(txtVecType, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtGateNum.Text))
            {
                errorProvider.SetError(txtGateNum, "Empty field");
                return;
            }

            UserParking nUserParking = new UserParking();
            nUserParking.userFullName = txtName.Text;
            nUserParking.userParkGate = txtGateNum.Text;
            nUserParking.userPlatenum = txtPlatenum.Text;
            nUserParking.userVechile = txtVecType.Text;

            db.UserParking.Add(nUserParking);
            db.SaveChanges();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;

            DialogResult result = printdialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPlatenum.Text = "";
            txtParkNum.Text = "";
            txtVecType.Text = "";
        }

        private void rdGate3Car_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGate3Car.Checked == true)
            {
                PictureBox.Image = Properties.Resources.Gate_3_car;
            }
        }

        private void rdGate3Motor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGate3Motor.Checked == true)
            {
                PictureBox.Image = Properties.Resources.Gate_3_motorcycle;
            }
        }

        private void rdGate4Car_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGate4Car.Checked == true)
            {
                PictureBox.Image = Properties.Resources.Gate_4_car;
            }
        }

        private void rdGate5Motor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGate5Motor.Checked == true)
            {
                PictureBox.Image = Properties.Resources.Gate_5_motorcycle;
            }
        }

        private void rdGate8Car_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGate8Car.Checked == true)
            {
                PictureBox.Image = Properties.Resources.Gate_8_car;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Teacher frm = new Frm_Teacher();
            frm.ShowDialog();
            this.Close();
        }

        private void Booking_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}
