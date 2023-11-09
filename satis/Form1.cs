using System.Data;
using System.Data.SqlClient;

namespace satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"Data Source=LAPTOP-41S7NGID\MSSQLSERVER01;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetListele()
        {
            Baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", Baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            Baglanti.Close();
        }

        private void hesapla()
        {
            try
            {
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", Baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "tl";
                Baglanti.Close();
            }
            catch (Exception)
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüþteriEkleme EKLE = new frmMüþteriEkleme();
            EKLE.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüþteriListeleme listele = new frmMüþteriListeleme();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void textTc_TextChanged(object sender, EventArgs e)
        {
            if (textTc.Text == "")
            {
                txtAdsoyad.Text = "";
                txtTelefon.Text = "";
            }
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müþteri where tc like '" + textTc.Text + "'", Baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdsoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            Baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            temizle();
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from ürün where barkodno like '" + txtBarkodNo.Text + "'", Baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdý.Text = read["ürünadi"].ToString();
                txtSatisFiyatý.Text = read["satisfiyati"].ToString();
            }
            Baglanti.Close();
        }

        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar)
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
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,ürünadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@ürünadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", Baglanti);
                komut.Parameters.AddWithValue("tc", textTc.Text);
                komut.Parameters.AddWithValue("adsoyad", txtAdsoyad.Text);
                komut.Parameters.AddWithValue("telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("ürünadi", txtÜrünAdý.Text);
                komut.Parameters.AddWithValue("miktari", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("satisfiyati", double.Parse(txtSatisFiyatý.Text));
                komut.Parameters.AddWithValue("toplamfiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                Baglanti.Close();
            }
            else
            {
                Baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari = miktari + " + int.Parse(txtMiktar.Text) + " where barkodno = '" + txtBarkodNo.Text + "'", Baglanti);
                komut2.ExecuteNonQuery();


                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati = miktari * satisfiyati where barkodno = '" + txtBarkodNo.Text + "'", Baglanti);
                komut3.ExecuteNonQuery();

                Baglanti.Close();
            }



            txtMiktar.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)
                    {
                        item.Text = "";
                    }
                }

            }

        }

        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", Baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            Baglanti.Close();
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyatý.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void txtSatisFiyatý_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyatý.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çýkarýldý..");
            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();


        }

        private void btnSatýþÝptal_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", Baglanti);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çýkarýldý..");
            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSatisListele listele = new frmSatisListele();
            listele.ShowDialog();
        }

        private void btnSatýþYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,ürünadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@ürünadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", Baglanti);
                komut.Parameters.AddWithValue("tc", textTc.Text);
                komut.Parameters.AddWithValue("adsoyad", txtAdsoyad.Text);
                komut.Parameters.AddWithValue("telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("ürünadi", dataGridView1.Rows[i].Cells["ürünadi"].Value.ToString());
                komut.Parameters.AddWithValue("miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update ürün set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where barkodno= '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", Baglanti);
                komut2.ExecuteNonQuery();
                Baglanti.Close();

            }
            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", Baglanti);
            komut3.ExecuteNonQuery();
            Baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();

        }
    }
}