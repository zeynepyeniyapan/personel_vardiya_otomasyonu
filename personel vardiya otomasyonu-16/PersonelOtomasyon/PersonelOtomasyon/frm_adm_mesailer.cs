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
    public partial class frm_adm_mesailer : Form
    {
        public frm_adm_mesailer()
        {
            InitializeComponent();
        }

        private void frm_adm_mesailer_Load(object sender, EventArgs e)
        {
            dgw_adm_mesailer.Columns.Add("id", "#");
            dgw_adm_mesailer.Columns.Add("ad", "Ad");
            dgw_adm_mesailer.Columns.Add("soyad", "Soyad");
            dgw_adm_mesailer.Columns.Add("sicil_no", "Sicil No");
            dgw_adm_mesailer.Columns.Add("vardiya_saat", "Vardiya Saati");
			dgw_adm_mesailer.Columns.Add("vardiya_gün", "Vardiya Günü");
			LoadData();
        }
        private void LoadData()
        {

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

                    dgw_adm_mesailer.Rows.Clear();
                    // Veritabanından tüm izinleri çeken SQL sorgusu
                    db_cmd = new MySqlCommand();
                    db_cmd.Connection = baglan;
                    db_cmd.CommandText = "SELECT * FROM tbl_mesai";
                    db_dr = db_cmd.ExecuteReader();

                    // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                    if (db_dr.HasRows)
                    {
                        while (db_dr.Read())
                        {
                            dgw_adm_mesailer.Rows.Add(
                                db_dr["id"].ToString(),
                                db_dr["ad"].ToString(),
                                db_dr["soyad"].ToString(),
                                db_dr["sicil_no"].ToString(),
                                db_dr["tarih_saat"].ToString(),
								db_dr["tarih_gun"].ToString()
							);
                        }
                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }

                    else
                    {
                        MessageBox.Show("Mesai Bilgisi Bulunamadı!");
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

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_admin admin = new frm_admin();
            admin.Show();
        }

        private void dgw_adm_mesailer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgw_adm_mesailer.ClearSelection();
                dgw_adm_mesailer.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dgw_adm_mesailer.Rows[e.RowIndex];

                lbl_secilen_sicil.Text = selectedRow.Cells["sicil_no"].Value?.ToString();
                lbl_ad_soyad.Text = selectedRow.Cells["ad"].Value?.ToString() + " " + selectedRow.Cells["soyad"].Value?.ToString();
            }

        }

        private void btn_izin_ekle_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (dgw_adm_mesailer.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_mesailer.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silmeSorgusu = "DELETE FROM tbl_mesai WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                    {
                        // Seçili idsini al
                        string id = dgw_adm_mesailer.Rows[selectedIndex].Cells["id"].Value.ToString();
                        string ad = dgw_adm_mesailer.Rows[selectedIndex].Cells["ad"].Value.ToString();
                        string soyad = dgw_adm_mesailer.Rows[selectedIndex].Cells["soyad"].Value.ToString();

                        db_cmd.Parameters.AddWithValue("@id", id);

                        // SQL sorgusunu çalıştır
                        db_cmd.ExecuteNonQuery();

                        // Yeni izin ekleme sorgusu
                        string yeniIzinEkleSorgusu = "INSERT INTO tbl_izin (adsoyad, sebep, sicil_no, tarih) VALUES (@adsoyad, @sebep, @sicil_no, @tarih)";

                        using (MySqlCommand yeniIzinEkleCmd = new MySqlCommand(yeniIzinEkleSorgusu, baglan))
                        {
                            // Seçili satırdaki sicil_no'yu al
                            int sicilNo = Convert.ToInt32(dgw_adm_mesailer.Rows[selectedIndex].Cells["sicil_no"].Value);

                            // İzin için tarih ayarladık
                            DateTime izin = dtp_izin_tarih.Value;

                            // İzine kaydedilecek verileri ayarla
                            yeniIzinEkleCmd.Parameters.AddWithValue("@adsoyad", ad + " " + soyad);
                            yeniIzinEkleCmd.Parameters.AddWithValue("@sebep", "Mesai İzni.");
                            yeniIzinEkleCmd.Parameters.AddWithValue("@sicil_no", sicilNo);
                            yeniIzinEkleCmd.Parameters.AddWithValue("@tarih", izin.ToString("yyyy-MM-dd"));

                            // Yeni izin ekleme SQL sorgusunu çalıştır
                            yeniIzinEkleCmd.ExecuteNonQuery();
                        }
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri silindikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }

            else
            {
                MessageBox.Show("Bir hata oluştur.");
            }
        }

        private void btn_prim_ekle_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (dgw_adm_mesailer.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_mesailer.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silmeSorgusu = "DELETE FROM tbl_mesai WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                    {
                        // Seçili idsini al
                        string id = dgw_adm_mesailer.Rows[selectedIndex].Cells["id"].Value.ToString();

                        db_cmd.Parameters.AddWithValue("@id", id);

                        // SQL sorgusunu çalıştır
                        db_cmd.ExecuteNonQuery();

                        // Önceki prim değerini al
                        string primSorgusu = "SELECT prim FROM tbl_personel WHERE sicil_no = @sicil_no";

                        using (MySqlCommand primCmd = new MySqlCommand(primSorgusu, baglan))
                        {
                            int sicilNo = Convert.ToInt32(dgw_adm_mesailer.Rows[selectedIndex].Cells["sicil_no"].Value);
                            primCmd.Parameters.AddWithValue("@sicil_no", sicilNo);

                            object currentPrimObj = primCmd.ExecuteScalar();

                            if (currentPrimObj != null)
                            {
                                int currentPrim = Convert.ToInt32(currentPrimObj);

                                // Yeni prim değerini al
                                int yeniPrim = currentPrim + (12 * 1000);

                                // Prim güncelleme sorgusu
                                string primGuncelleSorgusu = "UPDATE tbl_personel SET prim = @yeniPrim WHERE sicil_no = @sicil_no";

                                using (MySqlCommand primGuncelleCmd = new MySqlCommand(primGuncelleSorgusu, baglan))
                                {
                                    primGuncelleCmd.Parameters.AddWithValue("@yeniPrim", yeniPrim);
                                    primGuncelleCmd.Parameters.AddWithValue("@sicil_no", sicilNo);

                                    // Prim güncelleme SQL sorgusunu çalıştır
                                    primGuncelleCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri silindikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }

            else
            {
                MessageBox.Show("Bir hata oluştur.");
            }
        }
    }
}
