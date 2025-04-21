using System.Windows.Forms;

namespace SIA_NI_SIR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.DarkOliveGreen;


            // Create an instance of Form2
            Form3 form3 = new Form3();

            // Show Form2
            form3.Show();

            // Optionally, hide Form1 (if you want Form1 to disappear)
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Optionally, hide Form1 (if you want Form1 to disappear)
            this.Hide();
        }

    }
}


