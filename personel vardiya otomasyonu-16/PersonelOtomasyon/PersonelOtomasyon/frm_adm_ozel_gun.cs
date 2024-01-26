using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frm_adm_ozel_gun : Form
    {
        public frm_adm_ozel_gun()
        {
            InitializeComponent();
        }

        // Uygulamayı kapatma butonu
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Form yüklendiğinde çalışan olay
        private void frm_adm_ozel_gun_Load(object sender, EventArgs e)
        {
            dtp_og_tarih.Format = DateTimePickerFormat.Short;
            dtp_og_tarih.ShowUpDown = true;
            // DataGridView için sütunları tanımla
            dgw_adm_ozel_gunler.Columns.Add("og_ad", "Gün Adı");
            dgw_adm_ozel_gunler.Columns.Add("og_tarih", "Tarihi");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            LoadData();
        }

        // Özel gün kaydetme butonu
        private void btn_og_kaydet_Click(object sender, EventArgs e)
        {
			if (!string.IsNullOrWhiteSpace(tbx_og_ad.Text) && dtp_og_tarih.Value != DateTime.MinValue)
			{

                // Veritabanı bağlantı bilgilerini içeren string
                string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

                // MySqlCommand ve MySqlDataReader nesneleri
                MySqlCommand db_cmd;

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // Özel gün eklemek için SQL sorgusu
                    string sorgu = "INSERT INTO tbl_ozelgun (ad, tarih) VALUES (@ad, @tarih)";
                    db_cmd = new MySqlCommand(sorgu, baglan);

                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    db_cmd.Parameters.AddWithValue("@ad", tbx_og_ad.Text);
                    db_cmd.Parameters.AddWithValue("@tarih", dtp_og_tarih.Value);

                    // SQL sorgusunu çalıştır
                    db_cmd.ExecuteNonQuery();

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri ekledikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }

        // Veriyi yükleyen fonksiyon
        private void LoadData()
        {
            // Veritabanı bağlantı bilgilerini içeren string
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand db_cmd;
            MySqlDataReader db_dr;

            using (var baglan = new MySqlConnection(db_con))
            {
                try
                {
                    // Veritabanına bağlan
                    baglan.Open();

                    // Veritabanından tüm özel günleri çeken SQL sorgusu
                    db_cmd = new MySqlCommand();
                    db_cmd.Connection = baglan;
                    db_cmd.CommandText = "SELECT * FROM tbl_ozelgun";
                    db_dr = db_cmd.ExecuteReader();

                    // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                    if (db_dr.HasRows)
                    {
                        dgw_adm_ozel_gunler.Rows.Clear();
                        while (db_dr.Read())
                        {
                            dgw_adm_ozel_gunler.Rows.Add(
                                // Sadece tarih kısmını al
                                db_dr["ad"].ToString(),
                                Convert.ToDateTime(db_dr["tarih"]).ToShortDateString() 
                            );
                        }
                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Özel Gün Bilgisi Bulunamadı!");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya bilgi ver
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }
            }
        }

        private void btn_og_sil_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (dgw_adm_ozel_gunler.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_ozel_gunler.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silmeSorgusu = "DELETE FROM tbl_ozelgun WHERE ad = @ad";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = dgw_adm_ozel_gunler.Rows[selectedIndex].Cells["og_ad"].Value.ToString();

                        db_cmd.Parameters.AddWithValue("@ad", selectedGünAdı);

                        // SQL sorgusunu çalıştır
                        db_cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri silindikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_admin adm = new frm_admin();
            adm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
