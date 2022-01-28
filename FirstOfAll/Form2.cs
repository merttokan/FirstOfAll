using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace FirstOfAll
{
    public partial class Form2 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("server = 192.168.1.24;" +
          "port = 5432;Database = kantin;" +
          " user Id = postgres; password=Okanmert123456");
        public Form2()
        {
           
            InitializeComponent();
            con.Open();
            String lister = "select * from buton order by id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lister, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 50;


        }
      

       

        private void ekle_Click(object sender, EventArgs e)
        {
            string message = "Yeni ürün eklensin mi?";
            string title = "Ürün Ekle";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                NpgsqlCommand comEkle =
                    new NpgsqlCommand("insert into buton (isim,fiyat,tip) values (@p1,@p2,@p3)", con);
                comEkle.Parameters.AddWithValue("@p1", newIsim.Text);
                comEkle.Parameters.AddWithValue("@p2", double.Parse(newFiyat.Text));
                comEkle.Parameters.AddWithValue("@p3", newText.SelectedValue.ToString());
                comEkle.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();
                MessageBox.Show("Buton ekleme işlemi gerçekleştirildi!");

            }
        }

        private void Sil_Click(object sender, EventArgs e)

        {
            string message = "Ürün Silinsin mi?";
            string title = "Ürünü Sil";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                NpgsqlCommand comSil = new NpgsqlCommand("delete from buton where id=@p1", con);
                comSil.Parameters.AddWithValue("@p1", int.Parse(silText.Text));
                comSil.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            string message = "Ürün Güncellensin mi?";
            string title = "Ürün Güncelle";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                NpgsqlCommand comGuncelle = new NpgsqlCommand("update buton set isim = @p1, fiyat = @p2, tip = @p3 where id = @p4", con);
                comGuncelle.Parameters.AddWithValue("@p1", newIsim.Text);
                comGuncelle.Parameters.AddWithValue("@p2", double.Parse(newFiyat.Text));
                comGuncelle.Parameters.AddWithValue("@p3", newText.SelectedItem.ToString());
                comGuncelle.Parameters.AddWithValue("@p4", int.Parse(silText.Text));
                comGuncelle.ExecuteNonQuery();
                dataGridView1.Refresh();
                con.Close();
            }
            
        }
      


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string isim = dataGridView1.SelectedCells[0].Value.ToString();
            string fiyat = dataGridView1.SelectedCells[1].Value.ToString();
            String tip = dataGridView1.SelectedCells[2].Value.ToString();
            String id = dataGridView1.SelectedCells[3].Value.ToString();

            newIsim.Text = isim;
            newFiyat.Text = fiyat;
            newText.SelectedItem = tip.ToString();
            silText.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            String lister = "select * from buton where LOWER(isim) like LOWER('" + textBox1.Text + "%') OR tip like LOWER('"+ textBox1.Text+"') order by id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lister, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Refresh();
            con.Close();
        }

        
    }
}
