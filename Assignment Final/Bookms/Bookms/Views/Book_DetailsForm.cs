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
    public partial class Book_DetailsForm : Form
    {
        public Book_DetailsForm()
        {
            InitializeComponent();
            var ds = UserController.GetAllBooks();
            dGrid.DataSource = ds;
        }
    }
}
