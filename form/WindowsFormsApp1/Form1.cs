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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButClick(object sender, EventArgs e)
        {
            User user = new User();
                
            user.Name = textBoxUserName.Text;
            user.Mobile = textBoxMobile.Text;

            RadioButton b = groupGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            user.Gender = b.Text;
            user.Profession = comboBoxProfession.SelectedItem.ToString();
            /*
            string name = textBoxUserName.Text;
            string mobile = textBoxMobile.Text;

            RadioButton b = groupGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            string gender = b.Text;
            string profession = comboBoxProfession.SelectedItem.ToString();

            //string Output = String.Format("Name : {0}\nMobile : {1}\nGendre : {2}\nProfession : {3}", name, mobile,gender,profession);
           // rTOutput.Text = Output;
            
            new DashBord(name,mobile,gender,profession).Show();
            */
            new DashBord(user).Show();
        }
    }
}
