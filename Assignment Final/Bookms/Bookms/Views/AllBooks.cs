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
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
           
        }

        private void AllBooks_Load(object sender, EventArgs e)
        {

        }

        private void bunSearch_Click(object sender, EventArgs e)
        {
            string name = tBSraech.Text;
            dynamic book = UserController.GetBook(name);
            if (book != null)
            {
                tBbookinfo.Text = book.Name;
              
                MessageBox.Show("Book found");

            }
            else
            {

                MessageBox.Show("Book not found");
            }
        }

        private void btnBookDetail_Click(object sender, EventArgs e)
        {
            new Book_DetailsForm().Show();
        }
    }
}
