
namespace FirstOfAll
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.newIsim = new System.Windows.Forms.TextBox();
            this.newFiyat = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.silText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newText = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.urun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(622, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(642, 84);
            this.ekle.Margin = new System.Windows.Forms.Padding(4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(134, 96);
            this.ekle.TabIndex = 2;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // newIsim
            // 
            this.newIsim.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.newIsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newIsim.Location = new System.Drawing.Point(896, 89);
            this.newIsim.Margin = new System.Windows.Forms.Padding(4);
            this.newIsim.Multiline = true;
            this.newIsim.Name = "newIsim";
            this.newIsim.Size = new System.Drawing.Size(143, 28);
            this.newIsim.TabIndex = 3;
            this.newIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newFiyat
            // 
            this.newFiyat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.newFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFiyat.Location = new System.Drawing.Point(896, 127);
            this.newFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.newFiyat.Multiline = true;
            this.newFiyat.Name = "newFiyat";
            this.newFiyat.Size = new System.Drawing.Size(143, 28);
            this.newFiyat.TabIndex = 5;
            this.newFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(642, 297);
            this.Sil.Margin = new System.Windows.Forms.Padding(4);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(134, 96);
            this.Sil.TabIndex = 6;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // silText
            // 
            this.silText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.silText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.silText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silText.Location = new System.Drawing.Point(921, 310);
            this.silText.Margin = new System.Windows.Forms.Padding(4);
            this.silText.Multiline = true;
            this.silText.Name = "silText";
            this.silText.Size = new System.Drawing.Size(133, 45);
            this.silText.TabIndex = 7;
            this.silText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fiyat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Silinecek Ürün ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tip :";
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(642, 193);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(134, 96);
            this.guncelle.TabIndex = 12;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 96);
            this.button1.TabIndex = 13;
            this.button1.Text = "MENÜ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newText
            // 
            this.newText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newText.FormattingEnabled = true;
            this.newText.Items.AddRange(new object[] {
            "kasa",
            "kahvaltı",
            "anayemek",
            "salata",
            "tost",
            "sıcak",
            "tatlı",
            "fırın"});
            this.newText.Location = new System.Drawing.Point(896, 162);
            this.newText.Name = "newText";
            this.newText.Size = new System.Drawing.Size(143, 30);
            this.newText.TabIndex = 14;
            this.newText.Text = "kasa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 37);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // urun
            // 
            this.urun.AutoSize = true;
            this.urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urun.Location = new System.Drawing.Point(145, 9);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(334, 29);
            this.urun.TabIndex = 16;
            this.urun.Text = "ÜRÜN ARAMAK İÇİN YAZINIZ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.urun);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silText);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.newFiyat);
            this.Controls.Add(this.newIsim);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox newIsim;
        private System.Windows.Forms.TextBox newFiyat;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.TextBox silText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label urun;
        private System.Windows.Forms.ComboBox newText;
    }
}