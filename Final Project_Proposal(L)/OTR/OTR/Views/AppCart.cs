using OTR.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTR.Views
{
    public partial class AppCart : Form
    {
        public AppCart()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            new UserTask().Show();
        }

        private void dGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var products = InventoryController.GetSelectedProducts();
            dGridCart.DataSource = products;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginFormUser().Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AppviewForm().Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AppviewForm().Show();
        }
    }
}
