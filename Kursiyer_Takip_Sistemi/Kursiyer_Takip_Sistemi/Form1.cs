using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursiyer_Takip_Sistemi
{
    public partial class Form1 : Form
    {
        // SQL Server Express bağlantı adresimiz
        string baglantiAdresi = @"Data Source=DESKTOP-43FCON2;Initial Catalog=KursiyerTakipSistemi;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. KURSİYER KAYDET BUTON KODU
        private void KursiyerKaydetButonu_Click(object sender, EventArgs e)
        {
            SqlConnection sqlBaglantisi = new SqlConnection(baglantiAdresi);
            try
            {
                sqlBaglantisi.Open();
                string eklemeSorgusu = "INSERT INTO Kursiyerler (Ad, Soyad, TelefonNumarasi, KayitliOlduguKurs) " +
                                       "VALUES (@ogrenciAdi, @ogrenciSoyadi, @telefon, @kursNo)";

                SqlCommand sqlKomutu = new SqlCommand(eklemeSorgusu, sqlBaglantisi);
                sqlKomutu.Parameters.AddWithValue("@ogrenciAdi", txtAd.Text);
                sqlKomutu.Parameters.AddWithValue("@ogrenciSoyadi", txtSoyad.Text);
                sqlKomutu.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                sqlKomutu.Parameters.AddWithValue("@kursNo", Convert.ToInt32(txtKursNo.Text));

                sqlKomutu.ExecuteNonQuery();
                MessageBox.Show("Kursiyer başarıyla sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception yakalananHata)
            {
                MessageBox.Show("Kaydedilirken bir hata oluştu: " + yakalananHata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlBaglantisi.Close();
            }
        }

        // 2. YOKLAMA KAYDET BUTON KODU
        private void YoklamaKaydetButonu_Click(object sender, EventArgs e)
        {
            SqlConnection sqlBaglantisi = new SqlConnection(baglantiAdresi);
            try
            {
                sqlBaglantisi.Open();
                string yoklamaSorgusu = "INSERT INTO YoklamaDurumlari (KursiyerNumarasi, YoklamaTarihi, DerseGeldiMi) " +
                                        "VALUES (@kursiyerNo, @tarih, @geldiMi)";

                SqlCommand yoklamaKomutu = new SqlCommand(yoklamaSorgusu, sqlBaglantisi);
                yoklamaKomutu.Parameters.AddWithValue("@kursiyerNo", Convert.ToInt32(txtYoklamaKursiyerNo.Text));
                yoklamaKomutu.Parameters.AddWithValue("@tarih", DateTime.Now.Date);
                yoklamaKomutu.Parameters.AddWithValue("@geldiMi", chkGeldiMi.Checked);

                yoklamaKomutu.ExecuteNonQuery();
                MessageBox.Show("Yoklama durumu başarıyla veritabanına işlendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yoklama alınırken bir sorun çıktı: " + hata.Message);
            }
            finally
            {
                sqlBaglantisi.Close();
            }
        }

        // 3. LİSTELEME BUTON KODU
        private void ListeleButonu_Click(object sender, EventArgs e)
        {
            SqlConnection sqlBaglantisi = new SqlConnection(baglantiAdresi);
            try
            {
                sqlBaglantisi.Open();
                string listelemeSorgusu = "SELECT * FROM Kursiyerler";
                SqlCommand listelemeKomutu = new SqlCommand(listelemeSorgusu, sqlBaglantisi);

                SqlDataAdapter veriAdaptoru = new SqlDataAdapter(listelemeKomutu);
                DataTable veriTablosu = new DataTable();
                veriAdaptoru.Fill(veriTablosu);

                dataGridViewKursiyerler.DataSource = veriTablosu;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Listeleme sırasında hata oluştu: " + hata.Message);
            }
            finally
            {
                sqlBaglantisi.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void YoklamaListeleButonu_Click(object sender, EventArgs e)
        {
            SqlConnection sqlBaglantisi = new SqlConnection(baglantiAdresi);
            try
            {
                sqlBaglantisi.Open();

                // Bu sorgu sayesinde hem öğrencinin adını soyadını hem de yoklama durumunu tek bir tabloda birleştirip çekiyoruz
                string sorgu = "SELECT K.Ad, K.Soyad, Y.YoklamaTarihi, Y.DerseGeldiMi " +
                               "FROM YoklamaDurumlari Y " +
                               "INNER JOIN Kursiyerler K ON Y.KursiyerNumarasi = K.KursiyerNumarasi";

                SqlCommand sqlKomutu = new SqlCommand(sorgu, sqlBaglantisi);
                SqlDataAdapter veriAdaptoru = new SqlDataAdapter(sqlKomutu);
                DataTable veriTablosu = new DataTable();
                veriAdaptoru.Fill(veriTablosu);

                // Verileri ekrandaki büyük tabloya aktarıyoruz.
                dataGridViewKursiyerler.DataSource = veriTablosu;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yoklama listesi çekilirken hata oluştu: " + hata.Message);//hata mesajı
            }
            finally
            {
                sqlBaglantisi.Close();
            }
        }

        private void KursiyerSilButonu_Click(object sender, EventArgs e)
        {
            // Giriş kutusunun boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrEmpty(txtSilKursiyerNo.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz kursiyerin numarasını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection sqlBaglantisi = new SqlConnection(baglantiAdresi);

            try
            {
                sqlBaglantisi.Open();

                // Aynı anda iki silme sorgusu gönderilir
                // Önce YoklamaDurumlari tablosundaki geçmiş kayıtlarını temizliyoruz, 
                // hemen ardından Kursiyerler tablosundan öğrencinin kendisini siliyoruz.
                // böylece geride veri bırakılmamış olur.
                string silmeSorgusu = "DELETE FROM YoklamaDurumlari WHERE KursiyerNumarasi = @kursiyerNo; " +
                                     "DELETE FROM Kursiyerler WHERE KursiyerNumarasi = @kursiyerNo;";

                SqlCommand sqlKomutu = new SqlCommand(silmeSorgusu, sqlBaglantisi);
                sqlKomutu.Parameters.AddWithValue("@kursiyerNo", Convert.ToInt32(txtSilKursiyerNo.Text));

                // Sorguyu çalıştırıyoruz ve etkilenen satır sayısını alıyoruz
                int etkilenenSatirSayisi = sqlKomutu.ExecuteNonQuery();

                // Eğer veritabanında böyle bir ID yoksa etkilenen satır sayısı 0 
                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Kursiyer ve bağlı tüm yoklama geçmişi başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Silme işleminden sonra tablonun güncellenmesi için listeleme fonksiyonunu otomatik tetikliyoruz
                    ListeleButonu_Click(sender, e);
                    txtSilKursiyerNo.Clear(); // Kutuyu temizle
                }
                else
                {
                    MessageBox.Show("Bu numaraya sahip bir kursiyer bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata meydana geldi: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlBaglantisi.Close();
            }
        }
    }
}