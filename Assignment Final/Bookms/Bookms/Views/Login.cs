using Bookms.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bookms.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tBUsername.Text;
            string password = tBPassword.Text;
            var result = UserController.AuthenticateUser(username, password);
            if (result != null)
            {
                new Addbook().Show();
            }
            else
                MessageBox.Show("User NOT Valid");
           
        }
    }
}
