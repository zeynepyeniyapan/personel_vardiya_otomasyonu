using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frm_adm_izin : Form
    {
        public frm_adm_izin()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_adm_izin_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunları tanımla
            dgw_adm_izinler.Columns.Add("id", "#");
            dgw_adm_izinler.Columns.Add("adsoyad", "Ad Soyad");
            dgw_adm_izinler.Columns.Add("sebep", "İzin Sebebi");
            dgw_adm_izinler.Columns.Add("sicil_no", "Sicil No");
            dgw_adm_izinler.Columns.Add("baslangic_tarih", "Başlangıç Tarihi");
			dgw_adm_izinler.Columns.Add("bitis_tarih", "Bitiş Tarihi");

			// Form yüklenirken veriyi çeken fonksiyonu çağır
			LoadData();
        }
        private void LoadData()
        {
            // Veritabanı bağlantı bilgilerini içeren string
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand db_cmd, db_cmd2;
            MySqlDataReader db_dr, db_dr2;
            using (var baglan2 = new MySqlConnection(db_con))
            {
                try
                {
                    // Veritabanına bağlan
                    baglan2.Open();
                    cb_sicil_no.Items.Clear();
                    db_cmd2 = new MySqlCommand();
                    db_cmd2.Connection = baglan2;
                    db_cmd2.CommandText = "SELECT ad, soyad, sicil_no FROM tbl_personel";
                    db_dr2 = db_cmd2.ExecuteReader();
                    while (db_dr2.Read())
                    {
                        // cb_sicil_no ComboBox'ına sicil numaralarını ekleyin
                        cb_sicil_no.Items.Add(db_dr2["sicil_no"].ToString() + " - " + db_dr2["ad"].ToString() + " " + db_dr2["soyad"].ToString());
                    }
                    baglan2.Close();
                    using (var baglan = new MySqlConnection(db_con))
                    {
                        try
                        {
                            // Veritabanına bağlan
                            baglan.Open();

                            // Veritabanından tüm izinleri çeken SQL sorgusu
                            db_cmd = new MySqlCommand();
                            db_cmd.Connection = baglan;
                            db_cmd.CommandText = "SELECT * FROM tbl_izin";
                            db_dr = db_cmd.ExecuteReader();

                            // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                            if (db_dr.HasRows)
                            {
                                dgw_adm_izinler.Rows.Clear();
                                while (db_dr.Read())
                                {
                                    dgw_adm_izinler.Rows.Add(
                                        db_dr["id"].ToString(),
                                        db_dr["adsoyad"].ToString(),
                                        db_dr["sebep"].ToString(),
                                        db_dr["sicil_no"].ToString(),
                                        // Sadece tarih kısmını al
                                        Convert.ToDateTime(db_dr["baslangic_tarih"]).ToShortDateString(),
										Convert.ToDateTime(db_dr["bitis_tarih"]).ToShortDateString()
									);
                                }
                                // Veritabanı bağlantısını kapat
                                baglan.Close();


                            }
                            else
                            {
                                MessageBox.Show("İzin Bilgisi Bulunamadı!");
                                // Veritabanı bağlantısını kapat
                                baglan.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hata durumunda kullanıcıya bilgi ver
                            MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Personel Bilgisi Bulunamadı!");
                }
            }
            
        }


		private void btn_izin_kaydet_Click(object sender, EventArgs e)
		{
			string bas_tarih = dtp_izin_tarih_baslangic.Value.ToString("yyyy-MM-dd");
			string bit_tarih = dtp_izin_tarih_bitis.Value.ToString("yyyy-MM-dd");

			if (tbox_izin_sebep.Text != "" && cb_sicil_no.SelectedItem != null && bas_tarih != "" && bit_tarih != "")
			{
				string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";
				MySqlCommand db_cmd;

				using (var baglan = new MySqlConnection(db_con))
				{
					baglan.Open();

					DateTime startDate = DateTime.Parse(bas_tarih);
					DateTime endDate = DateTime.Parse(bit_tarih);

					for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
					{
						if (cb_sicil_no.SelectedItem != null) // Null kontrolü
						{
							string secilenItem = cb_sicil_no.SelectedItem.ToString();
							string[] parcalar = secilenItem.Split('-');

							string sicil_no = parcalar[0].Trim();

							string[] adSoyadParcalar = parcalar[1].Split(' ');

							string ad = adSoyadParcalar[0].Trim();
							string soyad = string.Join(" ", adSoyadParcalar.Skip(1)).Trim();

							string sorgu = "INSERT INTO tbl_izin (adsoyad, sebep, sicil_no, baslangic_tarih,bitis_tarih) VALUES (@adsoyad, @sebep, @sicil_no, @baslangic_tarih, @bitis_tarih)";
							db_cmd = new MySqlCommand(sorgu, baglan);

							db_cmd.Parameters.AddWithValue("@adsoyad", ad + " " + soyad);
                            db_cmd.Parameters.AddWithValue("@sebep", tbox_izin_sebep.Text);
                            db_cmd.Parameters.AddWithValue("@sicil_no", sicil_no);
							db_cmd.Parameters.AddWithValue("@baslangic_tarih", currentDate.ToString("yyyy-MM-dd"));
							db_cmd.Parameters.AddWithValue("@bitis_tarih", currentDate.ToString("yyyy-MM-dd"));

							db_cmd.ExecuteNonQuery();
							db_cmd.Parameters.Clear();  // Parametreleri temizle
						}
					}

					baglan.Close();

					cb_sicil_no.SelectedIndex = -1;
					tbox_izin_sebep.Text = "";
					dtp_izin_tarih_baslangic.Value = DateTime.Now;
					dtp_izin_tarih_bitis.Value = DateTime.Now;

					LoadData();

					

				}
			}
			else
			{
				MessageBox.Show("Tüm Alanları Doldurunuz!");
			}
		}


		private void btn_izin_sil_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (dgw_adm_izinler.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_izinler.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silmeSorgusu = "DELETE FROM tbl_izin WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                    {
                        // Seçili satırın gün adını al  
                        string selectedId = dgw_adm_izinler.Rows[selectedIndex].Cells["id"].Value.ToString();

                        db_cmd.Parameters.AddWithValue("@id", selectedId);

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

		private void dgw_adm_izinler_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void pnl_og_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_sicil_no_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbox_izin_sebep_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_sicil_no_Click(object sender, EventArgs e)
        {

        }
    }
}
