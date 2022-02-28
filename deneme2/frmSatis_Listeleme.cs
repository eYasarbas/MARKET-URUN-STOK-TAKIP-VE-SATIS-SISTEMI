using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmSatis_Listeleme : Form
    {
        public frmSatis_Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet dataset = new DataSet();
        private void frmSatis_Listeleme_Load(object sender, EventArgs e)
        {
            satisListele();
        }
        private void satisListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                }

                SqlDataAdapter adtr = new SqlDataAdapter("select *from Satis", baglanti);
                adtr.Fill(dataset, "Satis");
                dataGridView1.DataSource = dataset.Tables["Satis"];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("delete from Satis ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış sayfası temizlendi...");
            dataset.Tables["Satis"].Clear();


        }
    }
}
