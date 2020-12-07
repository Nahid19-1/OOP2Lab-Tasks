using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AppearReg(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Authencate(object sender, EventArgs e)
        {
            string name = "";
            string password = "";
            string errMeg = "";
            bool hasError = false;
            if (textBoxUserName.Text.Equals( ""))
            {
                errMeg += "Username Required\n";
                hasError = true;
            }
            else
            {
                name = textBoxUserName.Text;
            }

            if (textBoxPassword.Text.Equals(""))
            {
                errMeg += "Password Required\n";
                hasError = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }

            if (!hasError)
            {
                if(name.Equals("Nahid") && password.Equals("12345"))
                {
                    User u = new User();

                    u.Name = name;
                    u.Password = password;
                    //other fiellds from Deta Base
                    new DashBord(u).Show();
                }
                else
                {
                    MessageBox.Show("Invalid User or Password");
                }
            }
            else
            {
                MessageBox.Show(errMeg);
            }
        }
    }
}
