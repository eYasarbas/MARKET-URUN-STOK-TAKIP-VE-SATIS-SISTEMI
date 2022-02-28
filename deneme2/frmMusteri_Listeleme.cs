using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmMusteri_Listeleme : Form
    {
        public frmMusteri_Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet dataSet = new DataSet();


        private void frmMusteri_Listeleme_Load(object sender, EventArgs e)
        {
            Kayit_goster();

        }

        private void Kayit_goster()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select *from Musteri", baglanti);
            adptr.Fill(dataSet, "Musteri");
            dataGridView1.DataSource = dataSet.Tables["Musteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtad_soyad.Text = dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["mail"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                SqlCommand komut = new SqlCommand("update Musteri set ad_soyad=@ad_soyad,telefon=@telefon,adres=@adres,mail=@mail where tc=@tc", baglanti);
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@ad_soyad", txtad_soyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtadres.Text);
                komut.Parameters.AddWithValue("@mail", txtmail.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                if (komut.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Müşteri Güncelleme İşlemi Gerçekleşti.");

                }
                else
                {
                    MessageBox.Show("Bir hata ile karşılaştı");
                }
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                dataSet.Tables["Musteri"].Clear();
                Kayit_goster();

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                }

                SqlCommand komut = new SqlCommand("delete from Musteri where tc='" + dataGridView1.CurrentRow.Cells[0].Value + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataSet.Tables["Musteri"].Clear();
                Kayit_goster();
                MessageBox.Show("Kayıt Silindi..");

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);


            }

        }

        private void txtTc_ara_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter("select *from Musteri where tc like'%" + txtTc_ara.Text + "%'", baglanti);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}
