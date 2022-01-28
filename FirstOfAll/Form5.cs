﻿using System;
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
   
    public partial class Form5 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("server = 192.168.1.24;" +
            "port = 5432;Database = kantin;" +
            " user Id = postgres; password=Okanmert123456");
        public Form5()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            con.Open();
            String lister = "select * from mutfak_siparis order by isim";
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
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String lister = "select * from mutfak_siparis order by isim";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lister, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            con.Open();
            String lister = "select * from mutfak_siparis order by isim";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(lister, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
