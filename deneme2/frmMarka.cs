using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void markaEngelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Marka_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text == read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text == "" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            markaEngelle();
            if (durum == true)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string kayit = "insert into Marka_Bilgileri(kategori,marka) values (@kategori,@marka)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                    komut.Parameters.AddWithValue("@marka", textBox1.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Marka Eklendi..");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu marka zaten var.");
            }
            textBox1.Text = "";
            comboBox1.Text = "";
        }
        private void frmMarka_Load(object sender, EventArgs e)
        {
            Kategori_getir();
        }

        private void Kategori_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kategori_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
    }
}
