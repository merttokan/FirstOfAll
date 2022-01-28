using System;
using System.Media;


using System.Windows.Forms;

namespace FirstOfAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adminButton.Enabled = false;
            
            hataButon.Visible = false;
        }
        

        
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {

           
            Form2 form2 = new Form2();
            form2.ShowDialog();
           
        }
      

        private void sifreButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox1.Text == "admin")
            {
                adminButton.Enabled = true;
            }
            else { hataButon.Visible = true;
                timer1.Interval = 2000;
                timer1.Enabled = true;
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hataButon.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.ShowDialog();
        }

        private void mutfakSiparis_Click(object sender, EventArgs e)
        {
            Form5 mutfak = new Form5();
            mutfak.Show();
        }

        private void eskiSiparis_Click(object sender, EventArgs e)
        {
            Form4 eskiSiparisler = new Form4();
            eskiSiparisler.ShowDialog();
        }

        private void hataButon_Click(object sender, EventArgs e)
        {

        }

        private void firinSiparis_Click(object sender, EventArgs e)
        {
            Form8 firinSiparis= new Form8();
            firinSiparis.ShowDialog();
        }

        private void kasaSiparis_Click(object sender, EventArgs e)
        {
            Form7 firinSiparis = new Form7();
            firinSiparis.ShowDialog();
        }
    }
}
