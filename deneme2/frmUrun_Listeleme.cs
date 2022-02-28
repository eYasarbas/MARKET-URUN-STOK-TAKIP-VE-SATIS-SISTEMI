using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deneme2
{
    public partial class frmUrun_Listeleme : Form
    {
        public frmUrun_Listeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-311JGF2\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void frmUrun_Listeleme_Load(object sender, EventArgs e)
        {
            UrunListele();
            Kategori_getir();
            Marka_getir();
        }

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Urun", baglanti);
            adapter.Fill(dataSet, "Urun");
            dataGridView1.DataSource = dataSet.Tables["Urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod_no.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtkategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtUrun_adi.Text = dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString();
            txtMiktari.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            txtAlis_fiyati.Text = dataGridView1.CurrentRow.Cells["alis_fiyati"].Value.ToString();
            txtSatis_fiyati.Text = dataGridView1.CurrentRow.Cells["satis_fiyati"].Value.ToString();
        }

        private void btnYeni_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                SqlCommand komut = new SqlCommand("update Urun set kategori=@kategori,marka=@marka,urun_adi=@urun_adi,miktari=@miktari,alis_fiyati=@alis_fiyati,satis_fiyati=@satis_fiyati where barkodno=@barkodno", baglanti);
                komut.Parameters.Clear();
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@barkodno", txtBarkod_no.Text);
                komut.Parameters.AddWithValue("@kategori", txtkategori.Text);
                komut.Parameters.AddWithValue("@marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@urun_adi", txtUrun_adi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alis_fiyati", int.Parse(txtAlis_fiyati.Text));
                komut.Parameters.AddWithValue("@satis_fiyati", int.Parse(txtSatis_fiyati.Text));
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
                dataSet.Tables["Urun"].Clear();
                UrunListele();
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
        private void Kategori_getir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select *from Kategori_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combkategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void Marka_getir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand("select *from Marka_Bilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combmarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }
        private void btnmarkaguncelle_Click(object sender, EventArgs e)
        {
            if (txtBarkod_no.Text != "")
            {


                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    SqlCommand komut = new SqlCommand("update Urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@barkodno", txtBarkod_no.Text);
                    komut.Parameters.AddWithValue("@kategori", combkategori.Text);
                    komut.Parameters.AddWithValue("@marka", combmarka.Text);
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
                    dataSet.Tables["Urun"].Clear();
                    UrunListele();
                    foreach (Control item in this.Controls)
                    {
                        if (item is ComboBox)
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
                MessageBox.Show("Barkod no yazılı değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
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

                SqlCommand komut = new SqlCommand("delete from Urun where barkodno='" + dataGridView1.CurrentRow.Cells[0].Value + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataSet.Tables["Urun"].Clear();
                UrunListele();
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
                SqlDataAdapter adapter = new SqlDataAdapter("select *from Urun where barkodno like'%" + txtBarkod_ara.Text + "%'", baglanti);
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
