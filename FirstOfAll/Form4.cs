using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FirstOfAll
{
    public partial class Form4 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("server = 192.168.1.24;" +
          "port = 5432;Database = kantin;" +
          " user Id = postgres; password=Okanmert123456");
        public Form4()
        {
            InitializeComponent();
            timer1.Enabled = true;
            con.Open();
            String lister = "select * from eski_siparis order by isim";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lister, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[5].Width = 20;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 150;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Gün sonu alınsın mı?";
            string title = "Gün sonu al";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                NpgsqlCommand gunSonu = new NpgsqlCommand("Delete from eski_siparis", con);
                gunSonu.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String a = DateTime.Now.DayOfWeek.ToString();
            String b;
            DateTime datetime = DateTime.Now;

            this.labelSaat.Text = datetime.ToString();

            switch (a)
            {
                case ("Monday"):
                    b = "Pazartesi";
                    labelGun.Text = b;
                    break;
                case ("Tuesday"):
                    b = "Salı";
                    labelGun.Text = b;
                    break;
                case ("Wendesday"):
                    b = "Çarşamba";
                    labelGun.Text = b;
                    break;
                case ("Thursday"):
                    b = "Perşembe";
                    labelGun.Text = b;
                    break;
                case ("Friday"):
                    b = "Cuma";
                    labelGun.Text = b;
                    break;
                case ("Saturday"):
                    b = "Cumartesi";
                    labelGun.Text = b;
                    break;
                case ("Sunday"):
                    b = "Pazar";
                    labelGun.Text = b;
                    break;
                default:
                    b = "Gun bulunamadi";
                    labelGun.Text = b;
                    break;



            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            con.Open();
            String lister = "select * from eski_siparis order by isim";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lister, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
