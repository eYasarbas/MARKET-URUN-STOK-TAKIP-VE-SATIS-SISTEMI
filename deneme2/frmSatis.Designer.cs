
namespace deneme2
{
    partial class frmSatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtToplam_fiyat = new System.Windows.Forms.TextBox();
            this.txtSatis_fiyati = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtUrun_adi = new System.Windows.Forms.TextBox();
            this.txtBarkod_no = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtad_soyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatis_iptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatis_yap = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnkategori = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btngrafik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 252);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtToplam_fiyat);
            this.groupBox1.Controls.Add(this.txtSatis_fiyati);
            this.groupBox1.Controls.Add(this.txtMiktari);
            this.groupBox1.Controls.Add(this.txtUrun_adi);
            this.groupBox1.Controls.Add(this.txtBarkod_no);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtToplam_fiyat
            // 
            this.txtToplam_fiyat.Location = new System.Drawing.Point(79, 123);
            this.txtToplam_fiyat.Name = "txtToplam_fiyat";
            this.txtToplam_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txtToplam_fiyat.TabIndex = 14;
            // 
            // txtSatis_fiyati
            // 
            this.txtSatis_fiyati.Location = new System.Drawing.Point(79, 97);
            this.txtSatis_fiyati.Name = "txtSatis_fiyati";
            this.txtSatis_fiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatis_fiyati.TabIndex = 13;
            this.txtSatis_fiyati.TextChanged += new System.EventHandler(this.txtSatis_fiyati_TextChanged);
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(79, 71);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtMiktari.TabIndex = 12;
            this.txtMiktari.Text = "1";
            this.txtMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            // 
            // txtUrun_adi
            // 
            this.txtUrun_adi.Location = new System.Drawing.Point(79, 45);
            this.txtUrun_adi.Name = "txtUrun_adi";
            this.txtUrun_adi.Size = new System.Drawing.Size(100, 20);
            this.txtUrun_adi.TabIndex = 11;
            // 
            // txtBarkod_no
            // 
            this.txtBarkod_no.Location = new System.Drawing.Point(79, 19);
            this.txtBarkod_no.Name = "txtBarkod_no";
            this.txtBarkod_no.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod_no.TabIndex = 10;
            this.txtBarkod_no.TextChanged += new System.EventHandler(this.txtBarkod_no_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Satış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barkod No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttelefon);
            this.groupBox2.Controls.Add(this.txtad_soyad);
            this.groupBox2.Controls.Add(this.txtTc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri İşlemleri";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(79, 64);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(100, 20);
            this.txttelefon.TabIndex = 5;
            // 
            // txtad_soyad
            // 
            this.txtad_soyad.Location = new System.Drawing.Point(79, 39);
            this.txtad_soyad.Name = "txtad_soyad";
            this.txtad_soyad.Size = new System.Drawing.Size(100, 20);
            this.txtad_soyad.TabIndex = 4;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(79, 13);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 3;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(227, 373);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatis_iptal
            // 
            this.btnSatis_iptal.Location = new System.Drawing.Point(681, 150);
            this.btnSatis_iptal.Name = "btnSatis_iptal";
            this.btnSatis_iptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatis_iptal.TabIndex = 9;
            this.btnSatis_iptal.Text = "Satış İptal";
            this.btnSatis_iptal.UseVisualStyleBackColor = true;
            this.btnSatis_iptal.Click += new System.EventHandler(this.btnSatis_iptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(681, 109);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatis_yap
            // 
            this.btnSatis_yap.Location = new System.Drawing.Point(600, 373);
            this.btnSatis_yap.Name = "btnSatis_yap";
            this.btnSatis_yap.Size = new System.Drawing.Size(75, 23);
            this.btnSatis_yap.TabIndex = 11;
            this.btnSatis_yap.Text = "Satış Yap";
            this.btnSatis_yap.UseVisualStyleBackColor = true;
            this.btnSatis_yap.Click += new System.EventHandler(this.btnSatis_yap_Click);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(510, 383);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 13);
            this.lblGenelToplam.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Genel Toplam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btngrafik);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnkategori);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 100);
            this.panel1.TabIndex = 14;
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(720, 34);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(94, 28);
            this.btnMarka.TabIndex = 6;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(620, 35);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(94, 28);
            this.btnkategori.TabIndex = 5;
            this.btnkategori.Text = "Kategori";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(106, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 33);
            this.button9.TabIndex = 4;
            this.button9.Text = "Müşteri Listeleme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(271, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 33);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ürün Ekleme";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(488, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 33);
            this.button7.TabIndex = 2;
            this.button7.Text = "Satışları Listeleme";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(367, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 33);
            this.button6.TabIndex = 1;
            this.button6.Text = "Ürün Listeleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 33);
            this.button5.TabIndex = 0;
            this.button5.Text = "Müşteri Ekleme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(844, 33);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(94, 28);
            this.btngrafik.TabIndex = 7;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatis_yap);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatis_iptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtToplam_fiyat;
        private System.Windows.Forms.TextBox txtSatis_fiyati;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtUrun_adi;
        private System.Windows.Forms.TextBox txtBarkod_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtad_soyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatis_iptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatis_yap;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btngrafik;
    }
}