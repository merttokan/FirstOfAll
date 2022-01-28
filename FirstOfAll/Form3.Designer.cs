
namespace FirstOfAll
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kasa = new System.Windows.Forms.TabPage();
            this.mutfak = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.kahvaltı = new System.Windows.Forms.TabPage();
            this.anayemek = new System.Windows.Forms.TabPage();
            this.salata = new System.Windows.Forms.TabPage();
            this.tost = new System.Windows.Forms.TabPage();
            this.sıcak = new System.Windows.Forms.TabPage();
            this.tatlı = new System.Windows.Forms.TabPage();
            this.firin = new System.Windows.Forms.TabPage();
            this.secAzalt = new System.Windows.Forms.Button();
            this.hepsiniSil = new System.Windows.Forms.Button();
            this.adisyonKapat = new System.Windows.Forms.Button();
            this.siparisVer = new System.Windows.Forms.Button();
            this.toplamFiyatLabel = new System.Windows.Forms.Label();
            this.secHesapla = new System.Windows.Forms.Button();
            this.secFiyat = new System.Windows.Forms.Label();
            this.secSiparisVer = new System.Windows.Forms.Button();
            this.labelGun = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.adisyonNumber = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.mutfak.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1283, 25);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(247, 328);
            this.checkedListBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kasa);
            this.tabControl1.Controls.Add(this.mutfak);
            this.tabControl1.Controls.Add(this.firin);
            this.tabControl1.Location = new System.Drawing.Point(4, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 703);
            this.tabControl1.TabIndex = 2;
            // 
            // kasa
            // 
            this.kasa.Location = new System.Drawing.Point(4, 25);
            this.kasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kasa.Name = "kasa";
            this.kasa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kasa.Size = new System.Drawing.Size(1245, 674);
            this.kasa.TabIndex = 0;
            this.kasa.Text = "KASA";
            this.kasa.UseVisualStyleBackColor = true;
            this.kasa.Click += new System.EventHandler(this.kasa_Click);
            // 
            // mutfak
            // 
            this.mutfak.Controls.Add(this.tabControl2);
            this.mutfak.Location = new System.Drawing.Point(4, 22);
            this.mutfak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutfak.Name = "mutfak";
            this.mutfak.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutfak.Size = new System.Drawing.Size(1245, 677);
            this.mutfak.TabIndex = 1;
            this.mutfak.Text = "MUTFAK";
            this.mutfak.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.kahvaltı);
            this.tabControl2.Controls.Add(this.anayemek);
            this.tabControl2.Controls.Add(this.salata);
            this.tabControl2.Controls.Add(this.tost);
            this.tabControl2.Controls.Add(this.sıcak);
            this.tabControl2.Controls.Add(this.tatlı);
            this.tabControl2.Location = new System.Drawing.Point(8, 6);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1224, 672);
            this.tabControl2.TabIndex = 0;
            // 
            // kahvaltı
            // 
            this.kahvaltı.Location = new System.Drawing.Point(4, 25);
            this.kahvaltı.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.kahvaltı.Name = "kahvaltı";
            this.kahvaltı.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.kahvaltı.Size = new System.Drawing.Size(1216, 643);
            this.kahvaltı.TabIndex = 0;
            this.kahvaltı.Text = "KAHVALTI";
            this.kahvaltı.UseVisualStyleBackColor = true;
            // 
            // anayemek
            // 
            this.anayemek.Location = new System.Drawing.Point(4, 22);
            this.anayemek.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.anayemek.Name = "anayemek";
            this.anayemek.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.anayemek.Size = new System.Drawing.Size(1216, 646);
            this.anayemek.TabIndex = 1;
            this.anayemek.Text = "ANAYEMEK";
            this.anayemek.UseVisualStyleBackColor = true;
            // 
            // salata
            // 
            this.salata.Location = new System.Drawing.Point(4, 22);
            this.salata.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.salata.Name = "salata";
            this.salata.Size = new System.Drawing.Size(1216, 646);
            this.salata.TabIndex = 2;
            this.salata.Text = "SALATA";
            this.salata.UseVisualStyleBackColor = true;
            // 
            // tost
            // 
            this.tost.Location = new System.Drawing.Point(4, 22);
            this.tost.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tost.Name = "tost";
            this.tost.Size = new System.Drawing.Size(1216, 646);
            this.tost.TabIndex = 3;
            this.tost.Text = "TOST";
            this.tost.UseVisualStyleBackColor = true;
            // 
            // sıcak
            // 
            this.sıcak.Location = new System.Drawing.Point(4, 22);
            this.sıcak.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.sıcak.Name = "sıcak";
            this.sıcak.Size = new System.Drawing.Size(1216, 646);
            this.sıcak.TabIndex = 4;
            this.sıcak.Text = "SICAK";
            this.sıcak.UseVisualStyleBackColor = true;
            // 
            // tatlı
            // 
            this.tatlı.Location = new System.Drawing.Point(4, 22);
            this.tatlı.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tatlı.Name = "tatlı";
            this.tatlı.Size = new System.Drawing.Size(1216, 646);
            this.tatlı.TabIndex = 5;
            this.tatlı.Text = "TATLILAR";
            this.tatlı.UseVisualStyleBackColor = true;
            // 
            // firin
            // 
            this.firin.Location = new System.Drawing.Point(4, 22);
            this.firin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firin.Name = "firin";
            this.firin.Size = new System.Drawing.Size(1245, 677);
            this.firin.TabIndex = 2;
            this.firin.Text = "FIRIN";
            this.firin.UseVisualStyleBackColor = true;
            // 
            // secAzalt
            // 
            this.secAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secAzalt.Location = new System.Drawing.Point(1283, 639);
            this.secAzalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secAzalt.Name = "secAzalt";
            this.secAzalt.Size = new System.Drawing.Size(120, 58);
            this.secAzalt.TabIndex = 3;
            this.secAzalt.Text = "Seçilenleri Azalt";
            this.secAzalt.UseVisualStyleBackColor = true;
            this.secAzalt.Click += new System.EventHandler(this.secAzalt_Click_1);
            // 
            // hepsiniSil
            // 
            this.hepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hepsiniSil.Location = new System.Drawing.Point(1408, 639);
            this.hepsiniSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hepsiniSil.Name = "hepsiniSil";
            this.hepsiniSil.Size = new System.Drawing.Size(121, 58);
            this.hepsiniSil.TabIndex = 4;
            this.hepsiniSil.Text = "Hepsini Sil";
            this.hepsiniSil.UseVisualStyleBackColor = true;
            this.hepsiniSil.Click += new System.EventHandler(this.hepsiniSil_Click);
            // 
            // adisyonKapat
            // 
            this.adisyonKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adisyonKapat.Location = new System.Drawing.Point(1284, 704);
            this.adisyonKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adisyonKapat.Name = "adisyonKapat";
            this.adisyonKapat.Size = new System.Drawing.Size(119, 58);
            this.adisyonKapat.TabIndex = 5;
            this.adisyonKapat.Text = "Sonraki adisyon";
            this.adisyonKapat.UseVisualStyleBackColor = true;
            this.adisyonKapat.Click += new System.EventHandler(this.adisyonKapat_Click);
            // 
            // siparisVer
            // 
            this.siparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siparisVer.Location = new System.Drawing.Point(1285, 489);
            this.siparisVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siparisVer.Name = "siparisVer";
            this.siparisVer.Size = new System.Drawing.Size(247, 58);
            this.siparisVer.TabIndex = 8;
            this.siparisVer.Text = "Sipariş Ver";
            this.siparisVer.UseVisualStyleBackColor = true;
            this.siparisVer.Click += new System.EventHandler(this.siparisVer_Click);
            // 
            // toplamFiyatLabel
            // 
            this.toplamFiyatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.toplamFiyatLabel.Location = new System.Drawing.Point(1277, 460);
            this.toplamFiyatLabel.Name = "toplamFiyatLabel";
            this.toplamFiyatLabel.Size = new System.Drawing.Size(239, 25);
            this.toplamFiyatLabel.TabIndex = 0;
            this.toplamFiyatLabel.Text = "Hepsinin Fiyatı :";
            // 
            // secHesapla
            // 
            this.secHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secHesapla.Location = new System.Drawing.Point(1285, 406);
            this.secHesapla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secHesapla.Name = "secHesapla";
            this.secHesapla.Size = new System.Drawing.Size(137, 48);
            this.secHesapla.TabIndex = 9;
            this.secHesapla.Text = "Seçilenlerin Fiyatı:";
            this.secHesapla.UseVisualStyleBackColor = true;
            this.secHesapla.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // secFiyat
            // 
            this.secFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.secFiyat.Location = new System.Drawing.Point(1429, 423);
            this.secFiyat.Name = "secFiyat";
            this.secFiyat.Size = new System.Drawing.Size(77, 31);
            this.secFiyat.TabIndex = 10;
            this.secFiyat.Text = "0 TL";
            // 
            // secSiparisVer
            // 
            this.secSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secSiparisVer.Location = new System.Drawing.Point(1285, 561);
            this.secSiparisVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secSiparisVer.Name = "secSiparisVer";
            this.secSiparisVer.Size = new System.Drawing.Size(247, 58);
            this.secSiparisVer.TabIndex = 11;
            this.secSiparisVer.Text = "Seçilenleri Sipariş Ver";
            this.secSiparisVer.UseVisualStyleBackColor = true;
            this.secSiparisVer.Click += new System.EventHandler(this.secSiparisVer_Click);
            // 
            // labelGun
            // 
            this.labelGun.AutoSize = true;
            this.labelGun.Location = new System.Drawing.Point(131, 25);
            this.labelGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGun.Name = "labelGun";
            this.labelGun.Size = new System.Drawing.Size(45, 16);
            this.labelGun.TabIndex = 0;
            this.labelGun.Text = "label1";
            this.labelGun.Click += new System.EventHandler(this.labelGun_Click);
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Location = new System.Drawing.Point(208, 25);
            this.labelSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(45, 16);
            this.labelSaat.TabIndex = 12;
            this.labelSaat.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1409, 704);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADİSYON NUMARASI";
            // 
            // adisyonNumber
            // 
            this.adisyonNumber.AutoSize = true;
            this.adisyonNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adisyonNumber.Location = new System.Drawing.Point(1448, 727);
            this.adisyonNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adisyonNumber.Name = "adisyonNumber";
            this.adisyonNumber.Size = new System.Drawing.Size(51, 20);
            this.adisyonNumber.TabIndex = 14;
            this.adisyonNumber.Text = "label2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 772);
            this.Controls.Add(this.adisyonNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.labelGun);
            this.Controls.Add(this.secSiparisVer);
            this.Controls.Add(this.secFiyat);
            this.Controls.Add(this.secHesapla);
            this.Controls.Add(this.toplamFiyatLabel);
            this.Controls.Add(this.siparisVer);
            this.Controls.Add(this.adisyonKapat);
            this.Controls.Add(this.hepsiniSil);
            this.Controls.Add(this.secAzalt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cikarken);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.mutfak.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kasa;
        private System.Windows.Forms.TabPage mutfak;
        private System.Windows.Forms.Button secAzalt;
        private System.Windows.Forms.Button hepsiniSil;
        private System.Windows.Forms.Button adisyonKapat;
        private System.Windows.Forms.Button siparisVer;
        private System.Windows.Forms.Label toplamFiyatLabel;
        private System.Windows.Forms.Button secHesapla;
        private System.Windows.Forms.Label secFiyat;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage kahvaltı;
        private System.Windows.Forms.TabPage anayemek;
        private System.Windows.Forms.TabPage salata;
        private System.Windows.Forms.TabPage tost;
        private System.Windows.Forms.TabPage sıcak;
        private System.Windows.Forms.TabPage tatlı;
        private System.Windows.Forms.TabPage firin;
        private System.Windows.Forms.Button secSiparisVer;
        private System.Windows.Forms.Label labelGun;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adisyonNumber;
    }
}