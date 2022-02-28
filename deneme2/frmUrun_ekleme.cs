using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmUrun_ekleme : Form
    {
        public frmUrun_ekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private bool durum;
        private void barkodnoEngelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkod_no.Text == read["barkodno"].ToString() || txtBarkod_no.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }
        private void frmUrun_ekleme_Load(object sender, System.EventArgs e)
        {
            Kategori_getir();
            Marka_getir();
        }
        private void Kategori_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kategori_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void Marka_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Marka_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }



        private void btnYeni_ekle_Click(object sender, System.EventArgs e)
        {
            barkodnoEngelle();
            if (durum == true)
            {


                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    string kayit = "insert into Urun(barkodno,kategori,marka,urun_adi,miktari,alis_fiyati,satis_fiyati) values (@barkodno,@kategori,@marka,@urun_adi,@miktari,@alis_fiyati,@satis_fiyati)";
                    // urun tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@barkodno", txtBarkod_no.Text);
                    komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                    komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                    komut.Parameters.AddWithValue("@urun_adi", txtUrun_adi.Text);
                    komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                    komut.Parameters.AddWithValue("@alis_fiyati", int.Parse(txtAlis_fiyati.Text));
                    komut.Parameters.AddWithValue("@satis_fiyati", int.Parse(txtSatis_fiyati.Text));
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Ürün Ekleme İşlemi Gerçekleşti.");

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir barkod kodu zaten var.");
            }
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void barkod_notxt_TextChanged(object sender, EventArgs e)
        {
            if (barkod_notxt.Text == "")
            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select *from Urun where barkodno like '" + barkod_notxt.Text + "'", baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    kategoritxt.Text = reader["kategori"].ToString();
                    markatxt.Text = reader["marka"].ToString();
                    urun_aditxt.Text = reader["urun_adi"].ToString();
                    lblMiktari.Text = reader["miktari"].ToString();
                    alis_fiyatitxt.Text = reader["alis_fiyati"].ToString();
                    satis_fiyatitxt.Text = reader["satis_fiyati"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void btnVarolan_ekle_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(miktaritxt.Text) + "' where barkodno='" + barkod_notxt.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                MessageBox.Show("Var olan ürüne ekleme yapıldı...");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }
}
