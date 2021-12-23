using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstOfAll
{
    public partial class Mutfak : Form
    {
        Salatalar salata = new Salatalar();
        Tostlar tost = new Tostlar();
        AnaYemekler yemek = new AnaYemekler();
        Kahveler kahve = new Kahveler();
        Khvlt kahvalti = new Khvlt();
        public Mutfak()
        {
            
            InitializeComponent();
        }
       
        
        private void Mutfak_Load(object sender, EventArgs e)
        {

        }

        private void bpSv_Click(object sender, EventArgs e)
        {


            yemek.Show(); 
        }


        private void Kahvaltı_Click(object sender, EventArgs e)
        {

            
            kahvalti.Show();
        }

        private void Tostlar_Click(object sender, EventArgs e)
        {
            
            tost.Show();

        }

        private void Corba_Click(object sender, EventArgs e)
        {

        }

        private void Kahveler_Click(object sender, EventArgs e)
        {
            
            kahve.Show();
        }

        private void Salatalar_Click(object sender, EventArgs e)
        {
            
            salata.Show();
        }
    }
}
