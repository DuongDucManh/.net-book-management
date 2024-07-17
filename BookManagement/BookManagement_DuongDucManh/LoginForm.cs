using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_DuongDucManh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("You have to input both email and password","Input required",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return; //Exit the void method
            }
            //1st step check account
            UserAccountService service = new UserAccountService();
            UserAccount acc = service.CheckLogin(txtEmail.Text, txtPassword.Text);
            //2nd step check role
            if (acc == null)
            {
                MessageBox.Show("Wrong credentials check email and password again.", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;//exit the method
            }

            if (acc.Role == 1)//admin
            {
                BookManager form = new();
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("No permission to access", "Wrong right/privilege", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
