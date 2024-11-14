using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace My_Grocery_Store
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the "Add Products" menu
            AddProduct frm = new AddProduct();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the "Shopping Menu" menu
            ShoppingPage frm = new ShoppingPage();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close Button
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
