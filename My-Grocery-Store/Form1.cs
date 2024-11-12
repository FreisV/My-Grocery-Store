using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the "Add Products" menu
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the "Shopping Menu" menu
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close Button
            this.Close();
        }
    }
}
