using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIA_NI_SIR
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        { }
            private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form5 form5 = new Form5();

            // Show Form2
            form5.Show();

            // Optionally, hide Form1 (if you want Form1 to disappear)
            this.Hide();
        }

    }
}

