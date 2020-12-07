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
    public partial class DashBord : Form
    {
        public DashBord(User user)
        {
            InitializeComponent();
            string Output = String.Format("Name : {0}" +
                "\nMobile : {1}" +
                "\nGendre : {2}" +
                "\nProfession : {3}", user.Name, user.Mobile, user.Gender, user.Profession);
            rTOutput.Text = Output;
        }

        /*public DashBord(string name,string mobile,string gender,string profession)
        {
            InitializeComponent();
            string Output = String.Format("Name : {0}" +
                "\nMobile : {1}" +
                "\nGendre : {2}" +
                "\nProfession : {3}", name, mobile, gender, profession);
            rTOutput.Text = Output;
        }
        */
    }
}
