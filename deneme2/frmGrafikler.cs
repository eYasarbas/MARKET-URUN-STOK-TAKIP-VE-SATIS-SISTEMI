using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
     
        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            Grafik_Listele1();
            Grafik_Listele2();
        }
        private void Grafik_Listele1()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("Select urun_adi,satis_fiyati From Urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Satış Fiyatları"].Points.AddXY(read[0].ToString(), read[1].ToString());
            }
            baglanti.Close();
        }
        private void Grafik_Listele2()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("Select urun_adi,miktari From Urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart2.Series["Ürün Adeti"].Points.AddXY(read[0].ToString(), read[1].ToString());
            }
            baglanti.Close();
        }
    }
}
