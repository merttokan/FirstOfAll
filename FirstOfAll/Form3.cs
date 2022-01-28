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
   
    public partial class Form3 : Form
    {

        int adisyonNo;
        NpgsqlConnection con = new NpgsqlConnection("server = 192.168.1.24;" +
           "port = 5432;Database = kantin;" +
           " user Id = postgres; password=Okanmert123456");
        Button[] buttonArrayKasa;
        Button[] buttonArrayAnayemek;
        Button[] buttonArrayKahvalti;
        Button[] buttonArraySalata;
        Button[] buttonArrayFirin;
        Button[] buttonArrayTatli;
        Button[] buttonArraySicak;
        Button[] buttonArrayTost;
        Button[] tumButonlar;
        


        public Form3()
        {
            
            InitializeComponent();
            timer1.Enabled = true;
            kasaButonları();
            anayemeklerButonları();
            kahvaltıButonları();
            sicakButonları();
            tostButonları();
            salataButonları();
            tatlılarButonları();
            firinButonları();
            /*var z = new int[x.Length + y.Length];
            x.CopyTo(z, 0);
            y.CopyTo(z, x.Length);*/

            int adisyonNo;
            try
            {
                con.Open();
                string command1 = "select adisyon_numarasi from eski_siparis order by adisyon_numarasi DESC";
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                object[] arr2 = ds1.Tables[0].Rows[0].ItemArray;
                adisyonNo = int.Parse(arr2.GetValue(0).ToString());
                adisyonNumber.Text = adisyonNo.ToString();
            }
            catch (Exception e)
            {

                adisyonNo = 0;
                adisyonNumber.Text = adisyonNo.ToString();
            }
            con.Close();
        

    }
        
        private void firinButonları()
        {

            con.Open();
            string command = "select count(*) from buton where tip = 'fırın'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArrayFirin = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArrayFirin.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArrayFirin[i] = new Button();
                buttonArrayFirin[i].Size = new Size(120, 75);
                buttonArrayFirin[i].Location = new Point(step, horizotal);
                buttonArrayFirin[i].Click += button2_Click;
                step += 120;

                firin.Controls.Add(buttonArrayFirin[i]);
            }
            String lister = "select isim from buton where tip = 'fırın' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArrayFirin.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArrayFirin[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();

        }

        private void kasaButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'kasa'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArrayKasa = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArrayKasa.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArrayKasa[i] = new Button();
                buttonArrayKasa[i].Size = new Size(120, 75);
                buttonArrayKasa[i].Location = new Point(step, horizotal);
                buttonArrayKasa[i].Click += button2_Click;
                step += 120;

                kasa.Controls.Add(buttonArrayKasa[i]);
            }
            String lister = "select isim from buton where tip = 'kasa' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArrayKasa.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArrayKasa[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();
        }
       
        private void corbaButonları()
        {

        }
        private void anayemeklerButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'anayemek'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArrayAnayemek = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArrayAnayemek.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArrayAnayemek[i] = new Button();
                buttonArrayAnayemek[i].Size = new Size(120, 75);
                buttonArrayAnayemek[i].Location = new Point(step, horizotal);
                buttonArrayAnayemek[i].Click += button2_Click;
                step += 120;

                anayemek.Controls.Add(buttonArrayAnayemek[i]);
            }
            String lister = "select isim from buton where tip = 'anayemek' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArrayAnayemek.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArrayAnayemek[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();
        }
        private void kahvaltıButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'kahvaltı'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArrayKahvalti = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArrayKahvalti.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArrayKahvalti[i] = new Button();
                buttonArrayKahvalti[i].Size = new Size(120, 75);
                buttonArrayKahvalti[i].Location = new Point(step, horizotal);
                buttonArrayKahvalti[i].Click += button2_Click;
                step += 120;

                kahvaltı.Controls.Add(buttonArrayKahvalti[i]);
            }
            String lister = "select isim from buton where tip = 'kahvaltı' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArrayKahvalti.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArrayKahvalti[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();
        }
        private void tatlılarButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'tatlı'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArrayTatli = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArrayTatli.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArrayTatli[i] = new Button();
                buttonArrayTatli[i].Size = new Size(120, 75);
                buttonArrayTatli[i].Location = new Point(step, horizotal);
                buttonArrayTatli[i].Click += button2_Click;
                step += 120;

                tatlı.Controls.Add(buttonArrayTatli[i]);
            }
            String lister = "select isim from buton where tip = 'tatlı' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArrayTatli.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArrayTatli[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();

        }
        private void salataButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'salata'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArraySalata = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArraySalata.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArraySalata[i] = new Button();
                buttonArraySalata[i].Size = new Size(120, 75);
                buttonArraySalata[i].Location = new Point(step, horizotal);
                buttonArraySalata[i].Click += button2_Click;
                step += 120;

                salata.Controls.Add(buttonArraySalata[i]);
            }
            String lister = "select isim from buton where tip = 'salata' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArraySalata.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArraySalata[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();
        }
        private void tostButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'tost'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
            
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArrayTost = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArrayTost.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArrayTost[i] = new Button();
                buttonArrayTost[i].Size = new Size(120, 75);
                buttonArrayTost[i].Location = new Point(step, horizotal);
                buttonArrayTost[i].Click += button2_Click;
                step += 120;

                tost.Controls.Add(buttonArrayTost[i]);
            }
            String lister = "select isim from buton where tip = 'tost' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArrayTost.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArrayTost[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();
        }
        private void sicakButonları()
        {
            con.Open();
            string command = "select count(*) from buton where tip = 'sıcak'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
            String butonSayisiStr = arr1.GetValue(0).ToString();
           
            int butonSayisiInt = int.Parse(butonSayisiStr);
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[butonSayisiInt];
            int step = 20;
            int horizotal = 20;

            buttonArraySicak = new Button[butonSayisiInt];

            for (int i = 0; i < buttonArraySicak.Length; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    step = 20;
                    horizotal += 75;
                }
                buttonArraySicak[i] = new Button();
                buttonArraySicak[i].Size = new Size(120, 75);
                buttonArraySicak[i].Location = new Point(step, horizotal);
                buttonArraySicak[i].Click += button2_Click;
                step += 120;

                sıcak.Controls.Add(buttonArraySicak[i]);
            }
            String lister = "select isim from buton where tip = 'sıcak' order by id";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < buttonArraySicak.Length; i++)
            {
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                buttonArraySicak[i].Text = arr2.GetValue(0).ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] tipler = new string[8]{
                "kasa", "kahvaltı", "anayemek", "salata", "tost", "sıcak", "tatlı","fırın" };
            con.Open();
            
            Button temp = new Button();
            Button temp2;
            temp2 = (Button)sender;
            String listele = "select tip from buton where isim = '" + temp2.Text.ToString() + "'";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(listele, con);
            DataSet isElement = new DataSet();
            adapter.Fill(isElement);
            object[] arr3 = isElement.Tables[0].Rows[0].ItemArray;

            if (arr3.GetValue(0).Equals(tipler[0]))
            {
                for (int i = 0; i < buttonArrayKasa.Length; i++)
                {
                    if (buttonArrayKasa[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if(arr3.GetValue(0).Equals(tipler[1]))
            {
                for (int i = 0; i < buttonArrayKahvalti.Length; i++)
                {
                    if (buttonArrayKahvalti[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if (arr3.GetValue(0).Equals(tipler[2]))
            {
                for (int i = 0; i < buttonArrayAnayemek.Length; i++)
                {
                    if (buttonArrayAnayemek[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if (arr3.GetValue(0).Equals(tipler[3]))
            {
                for (int i = 0; i < buttonArraySalata.Length; i++)
                {
                    if (buttonArraySalata[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if (arr3.GetValue(0).Equals(tipler[4]))
            {
                for (int i = 0; i < buttonArrayTost.Length; i++)
                {
                    if (buttonArrayTost[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if (arr3.GetValue(0).Equals(tipler[5]))
            {
                for (int i = 0; i < buttonArraySicak.Length; i++)
                {
                    if (buttonArraySicak[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if (arr3.GetValue(0).Equals(tipler[6]))
            {
                for (int i = 0; i < buttonArrayTatli.Length; i++)
                {
                    if (buttonArrayTatli[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }
            else if (arr3.GetValue(0).Equals(tipler[7]))
            {
                for (int i = 0; i < buttonArrayFirin.Length; i++)
                {
                    if (buttonArrayFirin[i].Equals(sender))
                    {
                        temp = (Button)sender;
                    }
                }
            }


            String lister = "select isim,fiyat,tip from buton where isim = '" + temp.Text.ToString() + "'";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(lister, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            object[] arr2 = ds1.Tables[0].Rows[0].ItemArray;
            String isim = arr2.GetValue(0).ToString();
            double fiyat = double.Parse(arr2.GetValue(1).ToString());
            String tip = arr2.GetValue(2).ToString();
            NpgsqlCommand comEkle =
               new NpgsqlCommand("insert into kasa_check(isim,fiyat,tip,id,sayi) values (@p1,@p2,@p3,@p4,@p5) on conflict(isim) do update set sayi = kasa_check.sayi+1", con);
            comEkle.Parameters.AddWithValue("@p1", isim);
            comEkle.Parameters.AddWithValue("@p2", fiyat);
            comEkle.Parameters.AddWithValue("@p3", tip);
            comEkle.Parameters.AddWithValue("@p4", 1);
            comEkle.Parameters.AddWithValue("@p5", 1);
            comEkle.ExecuteNonQuery();

            String lister2 = "select isim,sayi from kasa_check where isim = '" + temp.Text.ToString() + "'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(lister2, con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            object[] arr4 = ds2.Tables[0].Rows[0].ItemArray;

           
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString().Contains(arr4.GetValue(0).ToString()))
                {
                    checkedListBox1.Items.RemoveAt(i);
                }
            }
            checkedListBox1.Items.Add(arr4.GetValue(0) + "(" + arr4.GetValue(1).ToString() + ")");

            con.Close();
            ToplamFiyatHesaplama();


        }







        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void secAzalt_Click_1(object sender, EventArgs e)
        {
            tumButonlarTopla();
           

            String temp = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    for (int b = 0; b < tumButonlar.Length; b++)
                    {
                        if (checkedListBox1.Items[i].ToString().Contains(tumButonlar[b].Text.ToString()))
                        {
                            temp = tumButonlar[b].Text.ToString();
                        }
                    }

                    con.Open();
                    NpgsqlCommand azalt = new NpgsqlCommand("update kasa_check set sayi = kasa_check.sayi-1 where isim = '"+temp+"'",con);
                    azalt.ExecuteNonQuery();
                    string command = "select sayi from kasa_check where isim = '" + temp + "'";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
                    if (arr1.GetValue(0).ToString().Equals("0"))
                    {
                        NpgsqlCommand sil = new NpgsqlCommand("delete from kasa_check where isim = '" + temp + "'", con);
                        sil.ExecuteNonQuery();
                        checkedListBox1.Items.RemoveAt(i);
                    }
                    else
                    {
                        checkedListBox1.Items[i] = temp.ToString() + "(" + arr1.GetValue(0) + ")";
                    }
                    con.Close();
                }
                



            }
        }

        private void tumButonlarTopla()
        {
            tumButonlar = new Button[buttonArrayAnayemek.Length + buttonArrayKahvalti.Length + buttonArraySalata.Length +buttonArrayTost.Length +buttonArrayKasa.Length +buttonArrayTatli.Length + buttonArraySicak.Length + buttonArrayFirin.Length];
            buttonArrayAnayemek.CopyTo(tumButonlar, 0);
            buttonArrayKahvalti.CopyTo(tumButonlar, buttonArrayAnayemek.Length);
            buttonArraySalata.CopyTo(tumButonlar, buttonArrayAnayemek.Length + buttonArrayKahvalti.Length);
            buttonArrayTatli.CopyTo(tumButonlar, buttonArrayAnayemek.Length + buttonArrayKahvalti.Length+ buttonArraySalata.Length);
            buttonArraySicak.CopyTo(tumButonlar, buttonArrayAnayemek.Length + buttonArrayKahvalti.Length + buttonArraySalata.Length + buttonArrayTatli.Length);
            buttonArrayFirin.CopyTo(tumButonlar, buttonArrayAnayemek.Length + buttonArrayKahvalti.Length + buttonArraySalata.Length + buttonArrayTatli.Length + buttonArraySicak.Length );
            buttonArrayTost.CopyTo(tumButonlar, buttonArrayAnayemek.Length + buttonArrayKahvalti.Length + buttonArraySalata.Length +buttonArrayTatli.Length + buttonArraySicak.Length + buttonArrayFirin.Length );
            
            buttonArrayKasa.CopyTo(tumButonlar, buttonArrayAnayemek.Length + buttonArraySalata.Length +buttonArrayTatli.Length + buttonArraySicak.Length + buttonArrayFirin.Length + buttonArrayTost.Length + +buttonArrayKahvalti.Length);
            
        }   
        private void SecilenFiyatHesaplama()
        {
            tumButonlarTopla();
            double toplamFiyat = 0;
            
            String temp = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                con.Open();
                string command1 = "select isim,sayi from kasa_check";
                
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                tumButonlarTopla();
                if (checkedListBox1.GetItemChecked(i))
                {
                    for (int b = 0; b < tumButonlar.Length; b++)
                    {
                        if (tumButonlar[b].Text.ToString().Equals(arr2.GetValue(0)))
                        {
                            temp = tumButonlar[b].Text.ToString();
                        }
                    }
                  
                    string command = "select fiyat,sayi from kasa_check where isim = '" + temp + "'";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    object[] arr1 = ds.Tables[0].Rows[0].ItemArray;

                    toplamFiyat = toplamFiyat + (double.Parse(arr1.GetValue(0).ToString()) * double.Parse(arr1.GetValue(1).ToString()));
                    
                }
                
               

                   
                
                secFiyat.Text =  (toplamFiyat.ToString()+" TL");
                con.Close();
            }
            

            /*for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
            
                    


                }
            }
            this.secilenFiyat.Text = toplamFiyat.ToString();
           */

        }
        private void ToplamFiyatHesaplama()
        {
            String oldTempToplamFiyat = "Toplam Fiyat : ";
            double toplamFiyat = 0;
           
            String temp = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                con.Open();
                string command1 = "select isim,sayi from kasa_check";
                
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                tumButonlarTopla();
                for (int b = 0; b < tumButonlar.Length; b++)
                {
                    if (tumButonlar[b].Text.ToString().Equals(arr2.GetValue(0)))
                    {
                        temp = tumButonlar[b].Text.ToString();
                    }
                }
            
                string command = "select fiyat,sayi from kasa_check where isim ='" + temp + "'";
                
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                object[] arr1 = ds.Tables[0].Rows[0].ItemArray;
               
                toplamFiyat = toplamFiyat + (double.Parse(arr1.GetValue(0).ToString()) * double.Parse(arr1.GetValue(1).ToString()));
                con.Close();
            }
                
                toplamFiyatLabel.Text = oldTempToplamFiyat+toplamFiyat.ToString()+" TL";
        
        }



        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            SecilenFiyatHesaplama();

        }

        private void hepsiniSil_Click(object sender, EventArgs e)
        {
            String oldTempToplamFiyat = "Toplam Fiyat : ";
            checkedListBox1.Items.Clear();
            con.Open();
            NpgsqlCommand sil = new NpgsqlCommand("DELETE FROM kasa_check",con);
            sil.ExecuteNonQuery();
            con.Close();
            secFiyat.Text = "0";
            toplamFiyatLabel.Text = oldTempToplamFiyat+"0";
        }

      

        private void cikarken(object sender, FormClosedEventArgs e)
        {
            String oldTempToplamFiyat = "Toplam Fiyat : ";
            checkedListBox1.Items.Clear();
            con.Open();
            NpgsqlCommand sil = new NpgsqlCommand("DELETE FROM kasa_check", con);
            sil.ExecuteNonQuery();
            con.Close();
            secFiyat.Text = "0";
            toplamFiyatLabel.Text = oldTempToplamFiyat + "0";
        }
        private void eskiSiparis()
        {
            String temp = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                con.Open();
                string command1 = "select isim,fiyat,sayi,tip from kasa_check";
                
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                tumButonlarTopla();
                for (int b = 0; b < tumButonlar.Length; b++)
                {
                    if (tumButonlar[b].Text.ToString().Equals(arr2.GetValue(0)))
                    {
                        temp = tumButonlar[b].Text.ToString();
                    }
                }

                NpgsqlCommand comEkle =
                new NpgsqlCommand("insert into eski_siparis (isim,fiyat,sayi,tip,adisyon_numarasi,tarih)values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                comEkle.Parameters.AddWithValue("@p1", arr2.GetValue(0));
                comEkle.Parameters.AddWithValue("@p2", double.Parse(arr2.GetValue(1).ToString()));
                comEkle.Parameters.AddWithValue("@p3", int.Parse(arr2.GetValue(2).ToString()));
                comEkle.Parameters.AddWithValue("@p4", arr2.GetValue(3).ToString());
                comEkle.Parameters.AddWithValue("@p5", adisyonNo);
                comEkle.Parameters.AddWithValue("@p6", labelSaat.Text.ToString());
                comEkle.ExecuteNonQuery();
                con.Close();
            }
        }
        private void siparisTakip()
        {
            String tempIsim = "";
            
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                

                con.Open();
                string command1 = "select isim,fiyat,sayi,tip from kasa_check";
               
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                tumButonlarTopla();
                for (int b = 0; b < tumButonlar.Length; b++)
                {
                    if (tumButonlar[b].Text.ToString().Equals(arr2.GetValue(0)))
                    {
                        tempIsim = tumButonlar[b].Text.ToString();
                        
                    }
                }

                if (arr2.GetValue(3).ToString().Equals("anayemek") || arr2.GetValue(3).ToString().Equals("kahvaltı")|| arr2.GetValue(3).ToString().Equals("salata")
                    || arr2.GetValue(3).ToString().Equals("sıcak")|| arr2.GetValue(3).ToString().Equals("tost") || arr2.GetValue(3).ToString().Equals("tatlı"))
                {
                    NpgsqlCommand comEkle =
                new NpgsqlCommand("insert into mutfak_siparis (isim,fiyat,durum,sayi,tip,adisyon_numarasi)values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    comEkle.Parameters.AddWithValue("@p1", arr2.GetValue(0));
                    comEkle.Parameters.AddWithValue("@p2", double.Parse(arr2.GetValue(1).ToString()));
                    comEkle.Parameters.AddWithValue("@p3", "beklemede");
                    comEkle.Parameters.AddWithValue("@p4", int.Parse(arr2.GetValue(2).ToString()));
                    comEkle.Parameters.AddWithValue("@p5", arr2.GetValue(3).ToString());
                    comEkle.Parameters.AddWithValue("@p6", int.Parse(adisyonNumber.Text.ToString()));
                    comEkle.ExecuteNonQuery();
                   
                }
                else if (arr2.GetValue(3).ToString().Equals("kasa"))
                {
                    NpgsqlCommand comEkle =
               new NpgsqlCommand("insert into kasa_siparis (isim,fiyat,durum,sayi,tip,adisyon_numarasi)values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    comEkle.Parameters.AddWithValue("@p1", arr2.GetValue(0));
                    comEkle.Parameters.AddWithValue("@p2", double.Parse(arr2.GetValue(1).ToString()));
                    comEkle.Parameters.AddWithValue("@p3", "beklemede");
                    comEkle.Parameters.AddWithValue("@p4", int.Parse(arr2.GetValue(2).ToString()));
                    comEkle.Parameters.AddWithValue("@p5", arr2.GetValue(3).ToString());
                    comEkle.Parameters.AddWithValue("@p6", int.Parse(adisyonNumber.Text.ToString()));
                    comEkle.ExecuteNonQuery();
                }
                else if (arr2.GetValue(3).ToString().Equals("fırın"))
                {
                    NpgsqlCommand comEkle =
               new NpgsqlCommand("insert into firin_siparis (isim,fiyat,durum,sayi,tip,adisyon_numarasi)values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    comEkle.Parameters.AddWithValue("@p1", arr2.GetValue(0));
                    comEkle.Parameters.AddWithValue("@p2", double.Parse(arr2.GetValue(1).ToString()));
                    comEkle.Parameters.AddWithValue("@p3", "beklemede");
                    comEkle.Parameters.AddWithValue("@p4", int.Parse(arr2.GetValue(2).ToString()));
                    comEkle.Parameters.AddWithValue("@p5", arr2.GetValue(3).ToString());
                    comEkle.Parameters.AddWithValue("@p6", int.Parse(adisyonNumber.Text.ToString()));
                    comEkle.ExecuteNonQuery();
                }
                
                con.Close();
            }
            
        }

        private void siparisVer_Click(object sender, EventArgs e)
        {
            string message = "Hepsini Sipariş Vermek istediğinize emin misiniz";
            string title = "Hepsini sipariş ver";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                eskiSiparis();
                siparisTakip();
            }
        }
        private void secSiparisVer_Click(object sender, EventArgs e)
        {
            string message = "Seçilenleri Sipariş Vermek istediğinize emin misiniz";
            string title = "Seçilenleri sipariş ver";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                String temp = "";
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    con.Open();
                    string command1 = "select isim,fiyat,sayi,tip from kasa_check";
                    
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    object[] arr2 = ds1.Tables[0].Rows[i].ItemArray;
                    tumButonlarTopla();
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        for (int b = 0; b < tumButonlar.Length; b++)
                        {
                            if (tumButonlar[b].Text.ToString().Equals(arr2.GetValue(0)))
                            {
                                temp = tumButonlar[b].Text.ToString();
                            }
                        }

                        NpgsqlCommand comEkle =
                    new NpgsqlCommand("insert into eski_siparis (isim,fiyat,sayi,tip,adisyon_numarası,tarih)values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                        comEkle.Parameters.AddWithValue("@p1", arr2.GetValue(0));
                        comEkle.Parameters.AddWithValue("@p2", double.Parse(arr2.GetValue(1).ToString()));
                        comEkle.Parameters.AddWithValue("@p3", int.Parse(arr2.GetValue(2).ToString()));
                        comEkle.Parameters.AddWithValue("@p4", arr2.GetValue(3).ToString());
                        comEkle.Parameters.AddWithValue("@p5", 0);
                        comEkle.Parameters.AddWithValue("@p6", labelSaat.Text.ToString());
                        comEkle.ExecuteNonQuery();



                    }
                    con.Close();

                }
            }
            else
            {
                // Do something  
            }
            
        }

        private void kasa_Click(object sender, EventArgs e)
        {

        }

        private void adisyonKapat_Click(object sender, EventArgs e)
        {
            String oldTempToplamFiyat = "Toplam Fiyat : ";
            checkedListBox1.Items.Clear();
            con.Open();
            NpgsqlCommand sil = new NpgsqlCommand("DELETE FROM kasa_check", con);
            sil.ExecuteNonQuery();
            con.Close();
            secFiyat.Text = "0";
            toplamFiyatLabel.Text = oldTempToplamFiyat + "0";
            
            
            if(adisyonNo == 0)
            {
                string command1 = "select adisyon_numarasi from eski_siparis order by adisyon_numarasi DESC";
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(command1, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                object[] arr2 = ds1.Tables[0].Rows[0].ItemArray;
                adisyonNo = int.Parse(arr2.GetValue(0).ToString());
                adisyonNo++;
            }
            else
            {
                adisyonNo++;
            }
            adisyonNumber.Text = adisyonNo.ToString();
            MessageBox.Show("ADİSYON KAPATILDI, BİR SONRAKİ SİPARİŞE GEÇİLİYOR");
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

        private void labelGun_Click(object sender, EventArgs e)
        {

        }
    }
}
