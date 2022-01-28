
namespace FirstOfAll
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunSonu = new System.Windows.Forms.Button();
            this.labelGun = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(985, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gunSonu
            // 
            this.gunSonu.Location = new System.Drawing.Point(1069, 139);
            this.gunSonu.Name = "gunSonu";
            this.gunSonu.Size = new System.Drawing.Size(199, 79);
            this.gunSonu.TabIndex = 1;
            this.gunSonu.Text = "Gün Sonu";
            this.gunSonu.UseVisualStyleBackColor = true;
            this.gunSonu.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGun
            // 
            this.labelGun.AutoSize = true;
            this.labelGun.Location = new System.Drawing.Point(244, 40);
            this.labelGun.Name = "labelGun";
            this.labelGun.Size = new System.Drawing.Size(46, 17);
            this.labelGun.TabIndex = 2;
            this.labelGun.Text = "label1";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Location = new System.Drawing.Point(329, 40);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(46, 17);
            this.labelSaat.TabIndex = 3;
            this.labelSaat.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(1069, 244);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(199, 79);
            this.yenile.TabIndex = 4;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 614);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.labelGun);
            this.Controls.Add(this.gunSonu);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gunSonu;
        private System.Windows.Forms.Label labelGun;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button yenile;
    }
}