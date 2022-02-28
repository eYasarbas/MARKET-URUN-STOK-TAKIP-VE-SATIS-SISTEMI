using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmMusteri_Ekle : Form
    {
        public frmMusteri_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void frmMusteri_Ekle_Load(object sender, EventArgs e)
        {


        }
        private bool durum;
        private void TcEngelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Musteri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtTc.Text == read["tc"].ToString() || txtTc.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            TcEngelle();
            if (durum == true)
            {


                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    string kayit = "insert into Musteri(tc,ad_soyad,telefon,adres,mail) values (@tc,@ad_soyad,@telefon,@adres,@mail)";
                    // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@ad_soyad", txtad_soyad.Text);
                    komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                    komut.Parameters.AddWithValue("@adres", txtadres.Text);
                    komut.Parameters.AddWithValue("@mail", txtmail.Text);
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Böyle bir TC zaten var.");
            }
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtad_soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
