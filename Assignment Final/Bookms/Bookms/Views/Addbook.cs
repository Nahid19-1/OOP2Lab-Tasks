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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var book = new
            {

                Name = tBName.Text,
                Authorname = tBAuthorname.Text,
                Edition = tBEdition.Text
            };
            var result = UserController.AddBook(book); 
            if (result)
            {
                MessageBox.Show("Book Added");
            }
            else
            {
                MessageBox.Show("Could Not add Book");
            }
           
        }

        private void btnAllbooks_Click(object sender, EventArgs e)
        {
            new AllBooks().Show();
           
        }
    }
}
