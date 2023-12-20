using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SparkSystem
{
    public partial class Frm_Register : Form
    {
        public string username = String.Empty;
        DBSYSfinalEntities db;
        public Frm_Register()
        {
            InitializeComponent();
            db = new DBSYSfinalEntities();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFname.Text))
            {
                errorProvider.SetError(txtFname, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtLname.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtLname, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtEmail, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtPassword, "Empty field");
                return;
            }

            UserAccount nUserAccount = new UserAccount();
            nUserAccount.userName = txtUsername.Text;
            nUserAccount.userPassword = txtPassword.Text;
            nUserAccount.roleId = (Int32)cbBoxRole.SelectedValue;
            nUserAccount.userStatus = "Active";
            nUserAccount.userInfLname = txtLname.Text;
            nUserAccount.userInfFname = txtFname.Text;
            nUserAccount.userInfAddress = txtAddress.Text;
            nUserAccount.userInfEmail = txtEmail.Text;


            username = txtUsername.Text;

            db.UserAccount.Add(nUserAccount);
            db.SaveChanges();

            txtPassword.Clear();
            txtUsername.Clear();
            txtLname.Clear();
            txtFname.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            MessageBox.Show("Registered!");

        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.UserRole.ToList();

            cbBoxRole.ValueMember = "roleId";
            cbBoxRole.DisplayMember = "roleName";
            cbBoxRole.DataSource = roles;

        }

        
        //if (String.IsNullOrEmpty(txtIdnum.Text))
        //{
        //    errorProvider.Clear();
        //    errorProvider.SetError(txtIdnum, "Empty field");
        //    return;
        //}
        //if (String.IsNullOrEmpty(txtRepassword.Text))
        //{
        //    errorProvider1.Clear();
        //    errorProvider1.SetError(txtPassword, "Empty field");
        //    return;
        //}

        //if (!txtPassword.Text.Equals(txtRepassword.Text))
        //{
        //    errorProvider1.Clear();
        //    errorProvider1.SetError(txtRepassword, "Password not match");
        //    return;
        //}

        //UserInformation nUserInformation = new UserInformation();
        //nUserInformation.userInfLname = txtLname.Text;
        //nUserInformation.userInfAddress = txtAddress.Text;
        //nUserInformation.userInfEmail = txtEmail.Text;
        //nUserInformation.userId = int.Parse(txtIdnum.Text);

        //db.UserInformations.Add(nUserInformation);
        //db.SaveChanges();

        //txtFname.Clear();
        //txtLname.Clear();
        //txtEmail.Clear();
        //txtAddress.Clear();
        //txtIdnum.Clear();
        //MessageBox.Show("Successfully proceed to the next form!");
        //this.Close();
        //var nextform = new UserAccountRegister();
        //nextform.Show();

    }
    }

