
namespace FirstOfAll
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreButton = new System.Windows.Forms.Button();
            this.hataButon = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.Button();
            this.mutfakSiparis = new System.Windows.Forms.Button();
            this.kasaSiparis = new System.Windows.Forms.Button();
            this.eskiSiparis = new System.Windows.Forms.Button();
            this.firinSiparis = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SIFRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADMIN SAYFASI ICIN GIRIS YAPINIZ";
            // 
            // sifreButton
            // 
            this.sifreButton.BackColor = System.Drawing.SystemColors.Control;
            this.sifreButton.ForeColor = System.Drawing.Color.Black;
            this.sifreButton.Location = new System.Drawing.Point(182, 84);
            this.sifreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sifreButton.Name = "sifreButton";
            this.sifreButton.Size = new System.Drawing.Size(70, 19);
            this.sifreButton.TabIndex = 6;
            this.sifreButton.Text = "GIRIS";
            this.sifreButton.UseVisualStyleBackColor = false;
            this.sifreButton.Click += new System.EventHandler(this.sifreButton_Click);
            // 
            // hataButon
            // 
            this.hataButon.AutoSize = true;
            this.hataButon.Location = new System.Drawing.Point(44, 86);
            this.hataButon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hataButon.Name = "hataButon";
            this.hataButon.Size = new System.Drawing.Size(120, 13);
            this.hataButon.TabIndex = 7;
            this.hataButon.Text = "Lütfen Tekrar Deneyiniz";
            this.hataButon.Click += new System.EventHandler(this.hataButon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menu
            // 
            this.menu.BackgroundImage = global::FirstOfAll.Properties.Resources.Seçilenden__1_;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Location = new System.Drawing.Point(296, 19);
            this.menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(132, 103);
            this.menu.TabIndex = 8;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // mutfakSiparis
            // 
            this.mutfakSiparis.BackgroundImage = global::FirstOfAll.Properties.Resources.Mutfak;
            this.mutfakSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mutfakSiparis.FlatAppearance.BorderSize = 0;
            this.mutfakSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mutfakSiparis.Location = new System.Drawing.Point(447, 21);
            this.mutfakSiparis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mutfakSiparis.Name = "mutfakSiparis";
            this.mutfakSiparis.Size = new System.Drawing.Size(132, 103);
            this.mutfakSiparis.TabIndex = 9;
            this.mutfakSiparis.UseVisualStyleBackColor = true;
            this.mutfakSiparis.Click += new System.EventHandler(this.mutfakSiparis_Click);
            // 
            // kasaSiparis
            // 
            this.kasaSiparis.BackgroundImage = global::FirstOfAll.Properties.Resources.Seçilenden__2_;
            this.kasaSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kasaSiparis.FlatAppearance.BorderSize = 0;
            this.kasaSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kasaSiparis.Location = new System.Drawing.Point(747, 19);
            this.kasaSiparis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kasaSiparis.Name = "kasaSiparis";
            this.kasaSiparis.Size = new System.Drawing.Size(132, 103);
            this.kasaSiparis.TabIndex = 11;
            this.kasaSiparis.UseVisualStyleBackColor = true;
            this.kasaSiparis.Click += new System.EventHandler(this.kasaSiparis_Click);
            // 
            // eskiSiparis
            // 
            this.eskiSiparis.BackgroundImage = global::FirstOfAll.Properties.Resources.Seçilenden__3_;
            this.eskiSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eskiSiparis.FlatAppearance.BorderSize = 0;
            this.eskiSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eskiSiparis.Location = new System.Drawing.Point(903, 19);
            this.eskiSiparis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eskiSiparis.Name = "eskiSiparis";
            this.eskiSiparis.Size = new System.Drawing.Size(132, 103);
            this.eskiSiparis.TabIndex = 12;
            this.eskiSiparis.UseVisualStyleBackColor = true;
            this.eskiSiparis.Click += new System.EventHandler(this.eskiSiparis_Click);
            // 
            // firinSiparis
            // 
            this.firinSiparis.BackgroundImage = global::FirstOfAll.Properties.Resources.Firin1;
            this.firinSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.firinSiparis.FlatAppearance.BorderSize = 0;
            this.firinSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firinSiparis.Location = new System.Drawing.Point(596, 19);
            this.firinSiparis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firinSiparis.Name = "firinSiparis";
            this.firinSiparis.Size = new System.Drawing.Size(133, 103);
            this.firinSiparis.TabIndex = 10;
            this.firinSiparis.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.firinSiparis.UseVisualStyleBackColor = true;
            this.firinSiparis.Click += new System.EventHandler(this.firinSiparis_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackgroundImage = global::FirstOfAll.Properties.Resources.Seçilenden;
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Location = new System.Drawing.Point(98, 120);
            this.adminButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(130, 103);
            this.adminButton.TabIndex = 5;
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FirstOfAll.Properties.Resources.Katman_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1069, 387);
            this.Controls.Add(this.eskiSiparis);
            this.Controls.Add(this.kasaSiparis);
            this.Controls.Add(this.firinSiparis);
            this.Controls.Add(this.mutfakSiparis);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.hataButon);
            this.Controls.Add(this.sifreButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button sifreButton;
        private System.Windows.Forms.Label hataButon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button mutfakSiparis;
        private System.Windows.Forms.Button firinSiparis;
        private System.Windows.Forms.Button kasaSiparis;
        private System.Windows.Forms.Button eskiSiparis;
    }
}