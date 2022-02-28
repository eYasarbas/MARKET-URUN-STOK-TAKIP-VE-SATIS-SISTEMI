using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet dataset = new DataSet();
        private bool durum;
        private void barkodKontrol()
        {
            durum = true;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlCommand komut = new SqlCommand("select *from Sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkod_no.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void sepetListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                }

                SqlDataAdapter adtr = new SqlDataAdapter("select *from Sepet", baglanti);
                adtr.Fill(dataset, "Sepet");
                dataGridView1.DataSource = dataset.Tables["Sepet"];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);


            }

        }

        private void hesapla()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from Sepet ", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteri_Ekle ekle = new frmMusteri_Ekle();
            ekle.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMusteri_Listeleme listeleme = new frmMusteri_Listeleme();
            listeleme.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUrun_ekleme ekle = new frmUrun_ekleme();
            ekle.ShowDialog();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmUrun_Listeleme ekle = new frmUrun_Listeleme();
            ekle.ShowDialog();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtad_soyad.Text = "";
                txttelefon.Text = "";
            }
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select *from Musteri where tc like'" + txtTc.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                txtad_soyad.Text = reader["ad_soyad"].ToString();
                txttelefon.Text = reader["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkod_no_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select *from Urun where barkodno like'" + txtBarkod_no.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                txtUrun_adi.Text = reader["urun_adi"].ToString();
                txtSatis_fiyati.Text = reader["satis_fiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkod_no.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }


                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("insert into Sepet(tc,ad_soyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyat) values (@tc,@ad_soyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyat)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@ad_soyad", txtad_soyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkod_no.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrun_adi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", int.Parse(txtSatis_fiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", int.Parse(txtToplam_fiyat.Text));
                komut.ExecuteReader();
                baglanti.Close();
            }
            else
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut1 = new SqlCommand("update Sepet miktari=miktari+'" + int.Parse(txtMiktari.Text) + "' where barkodno='" + txtBarkod_no.Text + "'", baglanti);
                komut1.ExecuteReader();
                SqlCommand komut2 = new SqlCommand("update Sepet toplamfiyat=miktari*satisfiyati where barkodno='" + txtBarkod_no.Text + "'", baglanti);
                komut2.ExecuteReader();
                baglanti.Close();

            }

            txtMiktari.Text = "1";
            dataset.Tables["Sepet"].Clear();
            sepetListele(); hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }
            }

        }
        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam_fiyat.Text = (int.Parse(txtMiktari.Text) * int.Parse(txtSatis_fiyati.Text)).ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSatis_fiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam_fiyat.Text = (int.Parse(txtMiktari.Text) * int.Parse(txtSatis_fiyati.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("delete from Sepet  where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün sepetten çıkarıldı...");
            dataset.Tables["Sepet"].Clear();
            sepetListele(); hesapla();
        }

        private void btnSatis_iptal_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("delete from Sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler sepetten çıkarıldı...");
            dataset.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSatis_Listeleme satis = new frmSatis_Listeleme();
            satis.ShowDialog();
        }

        private void btnSatis_yap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("insert into Satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyat) values (@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyat)", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.Rows[i].Cells["tc"].Value.ToString());
                komut.Parameters.AddWithValue("@adsoyad", dataGridView1.Rows[i].Cells["adsoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@telefon", dataGridView1.Rows[i].Cells["telefon"].Value.ToString());
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", int.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", int.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update Urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            MessageBox.Show("Satış başarıyla gerçekleşti...");
            SqlCommand komut3 = new SqlCommand("delete from Sepet ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            dataset.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();

        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            frmGrafikler ekle = new frmGrafikler();
            ekle.ShowDialog();
        }
    }
}
