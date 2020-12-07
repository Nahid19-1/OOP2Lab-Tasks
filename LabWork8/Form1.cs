using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            //User = new User();
            string Fname = textBoxFirstName.Text;
            string Lname = textBoxLastName.Text;
            string DofB = dateofBirth.Text;
            string grnd = gender.SelectedItem.ToString();
            string email = textBoxEmail.Text;
            string remail = textBoxRemail.Text;
            string pass = textBoxPassword.Text;
            string rpass = textBoxREPassword.Text;
            string squs = comboBoxSecQus.SelectedItem.ToString();
            string sans = textBoxSecAns.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string state = textBoxCity.Text;
            string zcode = textBoxZipCode.Text;
            string phone = textBoxPhone.Text;


            string Output = String.Format("First Name : {0}" +
                "\nLast Name : {1}" +
                "\nDate of Birth : {2}" +
                "\nGender : {3}"+
                "\nEmail :{4}" +
                "\nRepete Email : {5}"+
                "\nPassword : {6}"+
                "\nRepet Password : {7}"+
                "\nSecurity Question : {8}"+
                "\nSecurity Answer : {9}"+
                "\nAddress : {10}"+
                "\nCity : {11}"+
                "\nState : {12}"+
                "\nZip Code : {13}"+
                "\nPhone :{14}", Fname, Lname, DofB, grnd,email,remail,pass,rpass,squs,sans,address,city,state,zcode,phone);
            rTOutput.Text = Output;

            new Dashbord2().Show();
        }
    }
}
