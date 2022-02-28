using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace deneme2
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void kategoriEngelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kategori_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }
        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriEngelle();
            if (durum == true)
            {


                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string kayit = "insert into Kategori_Bilgileri(kategori) values (@kategori)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@kategori", textBox1.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kategori Eklendi..");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }

            }
            else
            {
                MessageBox.Show("Böyle bir kategori zaten var.");
            }
            textBox1.Text = "";

        }
    }
}
