
namespace deneme2
{
    partial class frmUrun_Listeleme
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
            this.lblTc_ara = new System.Windows.Forms.Label();
            this.txtBarkod_ara = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYeni_ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSatis_fiyati = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtAlis_fiyati = new System.Windows.Forms.TextBox();
            this.txtUrun_adi = new System.Windows.Forms.TextBox();
            this.txtBarkod_no = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.combkategori = new System.Windows.Forms.ComboBox();
            this.combmarka = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnmarkaguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTc_ara
            // 
            this.lblTc_ara.AutoSize = true;
            this.lblTc_ara.Location = new System.Drawing.Point(379, 52);
            this.lblTc_ara.Name = "lblTc_ara";
            this.lblTc_ara.Size = new System.Drawing.Size(77, 13);
            this.lblTc_ara.TabIndex = 28;
            this.lblTc_ara.Text = "Barkod No Ara";
            // 
            // txtBarkod_ara
            // 
            this.txtBarkod_ara.Location = new System.Drawing.Point(471, 49);
            this.txtBarkod_ara.Name = "txtBarkod_ara";
            this.txtBarkod_ara.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod_ara.TabIndex = 27;
            this.txtBarkod_ara.TextChanged += new System.EventHandler(this.txtTc_ara_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(688, 85);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 249);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Satış Fiyatı";
            // 
            // btnYeni_ekle
            // 
            this.btnYeni_ekle.Location = new System.Drawing.Point(101, 319);
            this.btnYeni_ekle.Name = "btnYeni_ekle";
            this.btnYeni_ekle.Size = new System.Drawing.Size(75, 23);
            this.btnYeni_ekle.TabIndex = 31;
            this.btnYeni_ekle.Text = "Güncelle";
            this.btnYeni_ekle.UseVisualStyleBackColor = true;
            this.btnYeni_ekle.Click += new System.EventHandler(this.btnYeni_ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Barkod No";
            // 
            // txtSatis_fiyati
            // 
            this.txtSatis_fiyati.Location = new System.Drawing.Point(76, 293);
            this.txtSatis_fiyati.Name = "txtSatis_fiyati";
            this.txtSatis_fiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatis_fiyati.TabIndex = 34;
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(76, 225);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtMiktari.TabIndex = 33;
            // 
            // txtAlis_fiyati
            // 
            this.txtAlis_fiyati.Location = new System.Drawing.Point(76, 259);
            this.txtAlis_fiyati.Name = "txtAlis_fiyati";
            this.txtAlis_fiyati.Size = new System.Drawing.Size(100, 20);
            this.txtAlis_fiyati.TabIndex = 32;
            // 
            // txtUrun_adi
            // 
            this.txtUrun_adi.Location = new System.Drawing.Point(76, 191);
            this.txtUrun_adi.Name = "txtUrun_adi";
            this.txtUrun_adi.Size = new System.Drawing.Size(100, 20);
            this.txtUrun_adi.TabIndex = 30;
            // 
            // txtBarkod_no
            // 
            this.txtBarkod_no.Location = new System.Drawing.Point(76, 87);
            this.txtBarkod_no.Name = "txtBarkod_no";
            this.txtBarkod_no.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod_no.TabIndex = 29;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(76, 155);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.ReadOnly = true;
            this.txtmarka.Size = new System.Drawing.Size(100, 20);
            this.txtmarka.TabIndex = 44;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(76, 121);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.ReadOnly = true;
            this.txtkategori.Size = new System.Drawing.Size(100, 20);
            this.txtkategori.TabIndex = 45;
            // 
            // combkategori
            // 
            this.combkategori.FormattingEnabled = true;
            this.combkategori.Location = new System.Drawing.Point(333, 340);
            this.combkategori.Name = "combkategori";
            this.combkategori.Size = new System.Drawing.Size(97, 21);
            this.combkategori.TabIndex = 46;
            // 
            // combmarka
            // 
            this.combmarka.FormattingEnabled = true;
            this.combmarka.Location = new System.Drawing.Point(333, 367);
            this.combmarka.Name = "combmarka";
            this.combmarka.Size = new System.Drawing.Size(97, 21);
            this.combmarka.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Kategori";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Marka";
            // 
            // btnmarkaguncelle
            // 
            this.btnmarkaguncelle.Location = new System.Drawing.Point(436, 348);
            this.btnmarkaguncelle.Name = "btnmarkaguncelle";
            this.btnmarkaguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnmarkaguncelle.TabIndex = 50;
            this.btnmarkaguncelle.Text = "Güncelle";
            this.btnmarkaguncelle.UseVisualStyleBackColor = true;
            this.btnmarkaguncelle.Click += new System.EventHandler(this.btnmarkaguncelle_Click);
            // 
            // frmUrun_Listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmarkaguncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combmarka);
            this.Controls.Add(this.combkategori);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnYeni_ekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSatis_fiyati);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.txtAlis_fiyati);
            this.Controls.Add(this.txtUrun_adi);
            this.Controls.Add(this.txtBarkod_no);
            this.Controls.Add(this.lblTc_ara);
            this.Controls.Add(this.txtBarkod_ara);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrun_Listeleme";
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrun_Listeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTc_ara;
        private System.Windows.Forms.TextBox txtBarkod_ara;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYeni_ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatis_fiyati;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtAlis_fiyati;
        private System.Windows.Forms.TextBox txtUrun_adi;
        private System.Windows.Forms.TextBox txtBarkod_no;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.ComboBox combkategori;
        private System.Windows.Forms.ComboBox combmarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnmarkaguncelle;
    }
}