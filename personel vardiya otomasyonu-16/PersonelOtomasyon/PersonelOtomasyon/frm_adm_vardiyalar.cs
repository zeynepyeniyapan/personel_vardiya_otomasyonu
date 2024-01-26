using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonelOtomasyon.cls_vardiya;

namespace PersonelOtomasyon
{
    public partial class frm_adm_vardiyalar : Form
    {
        public frm_adm_vardiyalar()
        {
            InitializeComponent();
        }

        private void frm_adm_mesailer_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunları tanımla
            dgw_adm_vardiyalar.Columns.Add("id", "#");
            dgw_adm_vardiyalar.Columns.Add("ad", "Ad");
            dgw_adm_vardiyalar.Columns.Add("soyad", "Soyad");
            dgw_adm_vardiyalar.Columns.Add("sicilno", "Sicil No");
			dgw_adm_vardiyalar.Columns.Add("tarih", "Vardiya Tarih");
			dgw_adm_vardiyalar.Columns.Add("vardiya_saat", "Vardiya Saati");
            dgw_adm_vardiyalar.Columns.Add("lokasyon", "Lokasyon");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            LoadData();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {
            cb_lokasyon.Items.Clear();
            cb_lokasyon.Items.Add("Kampüs Giriş");
            cb_lokasyon.Items.Add("Kampüs İçi");

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
                            db_cmd.CommandText = "SELECT * FROM tbl_vardiya";
                            db_dr = db_cmd.ExecuteReader();

                            // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                            if (db_dr.HasRows)
                            {
                                dgw_adm_vardiyalar.Rows.Clear();
                                while (db_dr.Read())
                                {
                                    dgw_adm_vardiyalar.Rows.Add(
                                        db_dr["id"].ToString(),
                                        db_dr["ad"].ToString(),
                                        db_dr["soyad"].ToString(), 
                                        db_dr["sicil_no"].ToString(),
										Convert.ToDateTime(db_dr["tarih_gun"]).ToString("dd.MM.yyyy dddd"),
                                        db_dr["tarih_saat"].ToString(),
                                        db_dr["bolge"].ToString()
                                    );
                                }
                                // Veritabanı bağlantısını kapat
                                baglan.Close();
                            }

                            else
                            {
                                MessageBox.Show("Vardiya Bilgisi Bulunamadı!");
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

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_admin adm = new frm_admin();
            adm.Show();
        }

        private void cb_lokasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_lokasyon.SelectedIndex == 0)
            {
                cb_vardiya_saat.Items.Clear();
                cb_vardiya_saat.Items.Add("00.00 - 08.00");
                cb_vardiya_saat.Items.Add("08.00 - 16.00");
                cb_vardiya_saat.Items.Add("16.00 - 24.00");
            }
            else
            {
                cb_vardiya_saat.Items.Clear();
                cb_vardiya_saat.Items.Add("08.00 - 16.00");
                cb_vardiya_saat.Items.Add("09.00 - 17.00");
            }
        }

        private void btn_vardiya_sil_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (dgw_adm_vardiyalar.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_vardiyalar.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silmeSorgusu = "DELETE FROM tbl_vardiya WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = dgw_adm_vardiyalar.Rows[selectedIndex].Cells["id"].Value.ToString();

                        db_cmd.Parameters.AddWithValue("@id", selectedGünAdı);

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

        private void btn_vardiya_olustur_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantı bilgilerini içeren string
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand db_cmd;

            using (var baglan = new MySqlConnection(db_con))
            {
                baglan.Open();

                // Önce " " karakterine göre stringi böl
                string[] parts = cb_sicil_no.Text.Split(' ');

                // Sadece ilk parçayı (sicil_no) al
                string sicil_no = parts[0];
                string ad = parts[2];
                string soyad = parts[3];

                // Vardiya oluşturulacak tarih ve saat
                DateTime vardiyaTarih = dtp_vardiya_tarih.Value;
                string vardiyaSaat = cb_vardiya_saat.Text;

                // Kontrol için flag
                bool vardiyaOlusturulabilir1 = true, vardiyaOlusturulabilir2 = true, vardiyaOlusturulabilir3 = true, vardiyaOlusturulabilir4 = true, mesaiEkle = false;

                // Aynı güne birden fazla saat kayıt edilip edilmediğini kontrol et
                string kontrolSorgusu = "SELECT COUNT(*) FROM tbl_vardiya WHERE sicil_no = @sicil_no AND tarih_gun = @tarih_gun";
                using (var kontrolCmd = new MySqlCommand(kontrolSorgusu, baglan))
                {
                    kontrolCmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                    kontrolCmd.Parameters.AddWithValue("@tarih_gun", vardiyaTarih);

                    int kayitSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        // Aynı gün için daha önce kayıt yapılmışsa uyarı ver
                        DialogResult result = MessageBox.Show("Bu güne zaten vardiya atanmış. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            vardiyaOlusturulabilir1 = false;
                        }
                        else
                        {
                            mesaiEkle = true;
                        }
                    }
                }

                // İzin aldığı gün olup olmadığını kontrol et
                string izinGunuSorgusu = "SELECT COUNT(*) FROM tbl_izin WHERE sicil_no = @sicil_no AND baslangic_tarih = @tarih_gun";
                using (var kontrolCmd = new MySqlCommand(izinGunuSorgusu, baglan))
                {
                    kontrolCmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                    kontrolCmd.Parameters.AddWithValue("@tarih_gun", vardiyaTarih);

                    int kayitSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        // Aynı gün için daha önce kayıt yapılmışsa uyarı ver
                        DialogResult result = MessageBox.Show("Personel izin almış. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            vardiyaOlusturulabilir4 = false;
                        }
                        else
                        {
                            mesaiEkle = true;
                        }
                    }
                }

                // tbl_personel tablosundan izin_1 ve izin_2 günlerini kontrol et
                string izinSorgusu = "SELECT izin_1, izin_2 FROM tbl_personel WHERE sicil_no = @sicil_no";
                using (var izinCmd = new MySqlCommand(izinSorgusu, baglan))
                {
                    izinCmd.Parameters.AddWithValue("@sicil_no", sicil_no);

                    using (var izinReader = izinCmd.ExecuteReader())
                    {
                        if (izinReader.Read())
                        {
                            string izin1 = izinReader["izin_1"].ToString();
                            string izin2 = izinReader["izin_2"].ToString();

                            // tbl_personel tablosundan gelen izin günlerini kontrol et
                            if (vardiyaTarih.DayOfWeek.ToString() == izin1 || vardiyaTarih.DayOfWeek.ToString() == izin2)
                            {
                                // İzin gününe denk gelen bir vardiya oluşturulamaz
                                DialogResult result = MessageBox.Show("Bu tarih izin günüdür. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.No)
                                {
                                    vardiyaOlusturulabilir2 = false;
                                }
                                else
                                {
                                    mesaiEkle = true;
                                }
                            }
                        }
                    }
                }

                // tbl_ozelgun tablosunu kontrol et
                string ozelGunSorgusu = "SELECT * FROM tbl_ozelgun WHERE tarih = @tarih";
                using (var ozelGunCmd = new MySqlCommand(ozelGunSorgusu, baglan))
                {
                    ozelGunCmd.Parameters.AddWithValue("@tarih", vardiyaTarih);

                    using (var ozelGunReader = ozelGunCmd.ExecuteReader())
                    {
                        if (ozelGunReader.Read())
                        {
                            // İzin gününe denk gelen bir vardiya oluşturulamaz
                            DialogResult result = MessageBox.Show("Bu tarih özel gündür günüdür. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No)
                            {
                                vardiyaOlusturulabilir3 = false;
                            }
                            else
                            {
                                mesaiEkle = true;
                            }
                        }
                    }
                }

                // Aynı gün içerisinde özel gün veya izin olmayan durumda vardiya kaydını yap
                if (vardiyaOlusturulabilir1 && vardiyaOlusturulabilir2 && vardiyaOlusturulabilir3 && vardiyaOlusturulabilir4) 
                {
                    // Vardiya oluşturulacak tarih ve saat
                    string bolge = cb_lokasyon.Text;

                    // Özel gün veya izin olup olmadığını kontrol eden kodlar bu noktadan önce eklendi
                    // Sadece bu blok içerisinde vardiya kaydını ve tbl_mesai kaydını yapılır

                    // Özel gün veya izin olmayan durumda vardiya kaydını yap
                    string vardiyaSorgu = "INSERT INTO tbl_vardiya (ad, soyad, sicil_no, tarih_gun, tarih_saat, bolge) VALUES (@ad, @soyad, @sicil_no, @tarih_gun, @tarih_saat, @bolge)";
                    db_cmd = new MySqlCommand(vardiyaSorgu, baglan);

                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    db_cmd.Parameters.AddWithValue("@ad", ad);
                    db_cmd.Parameters.AddWithValue("@soyad", soyad);
                    db_cmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                    db_cmd.Parameters.AddWithValue("@tarih_gun", vardiyaTarih);
                    db_cmd.Parameters.AddWithValue("@tarih_saat", vardiyaSaat);
                    db_cmd.Parameters.AddWithValue("@bolge", bolge);

                    // SQL sorgusunu çalıştır
                    db_cmd.ExecuteNonQuery();

                    // Eğer mesai kaydedilecekse
                    if (mesaiEkle == true)
                    {
                        // tbl_mesai tablosuna kayıt ekle
                        string mesaiSorgu = "INSERT INTO tbl_mesai (ad, soyad, sicil_no, tarih_saat) VALUES (@ad_mesai, @soyad_mesai, @sicil_no_mesai, @tarih_saat_mesai)";
                        using (var mesaiCmd = new MySqlCommand(mesaiSorgu, baglan))
                        {
                            // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                            mesaiCmd.Parameters.AddWithValue("@ad_mesai", ad);
                            mesaiCmd.Parameters.AddWithValue("@soyad_mesai", soyad);
                            mesaiCmd.Parameters.AddWithValue("@sicil_no_mesai", sicil_no);
                            mesaiCmd.Parameters.AddWithValue("@tarih_saat_mesai", vardiyaSaat);

                            // SQL sorgusunu çalıştır
                            mesaiCmd.ExecuteNonQuery();
                        }
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri ekledikten sonra DataGridView'i güncelle
                    LoadData();
                }

                baglan.Close();
            }
        }



        private void btn_vardiya_guncelle_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı güncelle
            if (dgw_adm_vardiyalar.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_vardiyalar.CurrentRow.Index;

                // Güncelleme işlemi için sorgu
                string guncelleSorgusu = "UPDATE tbl_vardiya SET id = @id, tarih_gun = @tarih_gun, tarih_saat = @tarih_saat, bolge = @bolge WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand db_cmd = new MySqlCommand(guncelleSorgusu, baglan))
                    {
                        // Seçili satırın id'sini al
                        string selectedId = dgw_adm_vardiyalar.Rows[selectedIndex].Cells["id"].Value.ToString();

                        // Parametreleri ekleyerek SQL sorgusunu güncel hale getir
                        db_cmd.Parameters.AddWithValue("@id", selectedId);
                        db_cmd.Parameters.AddWithValue("@tarih_gun", dtp_vardiya_tarih.Value);
                        db_cmd.Parameters.AddWithValue("@tarih_saat", cb_vardiya_saat.Text);
                        db_cmd.Parameters.AddWithValue("@bolge", cb_lokasyon.Text);

                        // SQL sorgusunu çalıştır
                        db_cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri güncellendikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }


        public class Personel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string SicilNo { get; set; }
            public string KadroTipi { get; set; }
            public string Izin1 { get; set; }
            public string Izin2 { get; set; }

            public Personel(string ad, string soyad ,string sicilNo, string kadroTipi, string izin1, string izin2)
            {
                Ad = ad;
                Soyad = soyad;
                SicilNo = sicilNo;
                KadroTipi = kadroTipi;
                Izin1 = izin1;
                Izin2 = izin2;
            }
        }
        public class Izinler
        {
            public string SicilNo { get; set; }
            public string Tarih { get; set; }

            public Izinler(string sicilNo, string tarih)
            {
                SicilNo = sicilNo;
                Tarih = tarih;
            }
        }

        public class OzelGunler
        {
            public string Tarih { get; set; }
            public string Ad { get; set; }

            public OzelGunler(string tarih, string ad)
            {
                Tarih = tarih;
                Ad = ad;
            }
        }
        private void btn_cikti_al_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dgw_adm_vardiyalar.ColumnCount);

                float pageWidth = PageSize.A2.Width; // Sayfa genişliği
                float tableWidth = pageWidth * 0.8f; // Tablo genişliği (sayfa genişliğinin %80'i)

                pdfTable.DefaultCell.Padding = 6;
                pdfTable.WidthPercentage = 100; // Tabloyu sayfanın tam genişliğine yay
                pdfTable.TotalWidth = tableWidth;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                // Sayfa genişliğinin yarısı kadar boş hücre ekle (ortalamak için)
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Colspan = dgw_adm_vardiyalar.ColumnCount;
                emptyCell.Border = 0; // Kenarlığı olmayan bir hücre
                pdfTable.AddCell(emptyCell);

                foreach (DataGridViewColumn column in dgw_adm_vardiyalar.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                try
                {
                    foreach (DataGridViewRow row in dgw_adm_vardiyalar.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Eğer hücre değeri null değilse, PDF tabloya ekle
                            if (cell.Value != null)
                            {
                                // Tarih hücrelerini uygun formata dönüştürerek ekleyin
                                if (cell.OwningColumn.Name == "tarih")
                                {
                                    DateTime dateValue;
                                    if (DateTime.TryParse(cell.Value.ToString(), out dateValue))
                                    {
                                        pdfTable.AddCell(dateValue.ToString("dd.MM.yyyy"));
                                    }
                                    else
                                    {
                                        // Eğer tarih dönüştürme başarısız olursa, boş bir hücre ekleyebilir veya başka bir değer atayabilirsiniz.
                                        pdfTable.AddCell("");
                                    }
                                }
                                else
                                {
                                    // Tarih hücresi değilse, değeri doğrudan ekleyin
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            else
                            {
                                // Eğer hücre değeri null ise, boş bir hücre ekleyebilir veya başka bir değer atayabilirsiniz.
                                pdfTable.AddCell("");
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }

                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 20f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Başlık eklemek için
                    Paragraph title = new Paragraph("Vardiya Listesi");
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    // Tabloyu sayfanın tam genişliğine yayarak hem sağdan hem soldan ortala
                    pdfTable.TotalWidth = pageWidth;
                    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void dgw_adm_vardiyalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgw_adm_vardiyalar.ClearSelection();
                dgw_adm_vardiyalar.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dgw_adm_vardiyalar.Rows[e.RowIndex];

                cb_sicil_no.Text = selectedRow.Cells["sicilno"].Value?.ToString();
                cb_lokasyon.Text = selectedRow.Cells["lokasyon"].Value?.ToString();
                dtp_vardiya_tarih.Text = selectedRow.Cells["tarih"].Value?.ToString();
                cb_vardiya_saat.Text = selectedRow.Cells["vardiya_saat"].Value?.ToString();
            }
        }

		private void btn_ara_Click(object sender, EventArgs e)
		{
			DateTime basTarih = dtp_ara_baslangic.Value;
			DateTime bitTarih = dtp_ara_bitis.Value;

			// Tarihleri 'yyyy-MM-dd' formatına dönüştür
			string bas_tarih = basTarih.ToString("yyyy-MM-dd");
			string bit_tarih = bitTarih.ToString("yyyy-MM-dd");

			string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

			// MySqlCommand ve MySqlDataReader nesneleri
			MySqlCommand db_cmd;
			MySqlDataReader db_dr;

			using (var baglan = new MySqlConnection(db_con))
			{
				try
				{
					baglan.Open();

					string sorgu = "SELECT * FROM tbl_vardiya WHERE tarih_gun BETWEEN @bas_tarih AND @bit_tarih";
					db_cmd = new MySqlCommand(sorgu, baglan);

					// Parametreleri ekleyerek SQL enjeksiyonlarına karşı koruma sağla
					db_cmd.Parameters.AddWithValue("@bas_tarih", basTarih.ToString("yyyy-MM-dd"));
					db_cmd.Parameters.AddWithValue("@bit_tarih", bitTarih.ToString("yyyy-MM-dd"));

					db_dr = db_cmd.ExecuteReader();

					// DataGridView'i temizle
					dgw_adm_vardiyalar.Rows.Clear();

					if (db_dr.HasRows)
					{
						while (db_dr.Read())
						{
							dgw_adm_vardiyalar.Rows.Add(
								db_dr["id"].ToString(),
								db_dr["ad"].ToString(),
								db_dr["soyad"].ToString(),
								db_dr["sicil_no"].ToString(),
								Convert.ToDateTime(db_dr["tarih_gun"]).ToShortDateString(),
								db_dr["tarih_saat"].ToString(),
								db_dr["bolge"].ToString()
							);
						}
					}
					else
					{
						MessageBox.Show("Belirtilen Tarihlerde Vardiya Bilgisi Bulunamadı!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
				}
				finally
				{
					baglan.Close();
				}
			}
		}

		private void btn_vardiya_otomatik_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtp_vardiya_baslangic.Value;
            DateTime bitisTarihi = dtp_vardiya_bitis.Value;

            // vardiyalar sınıfının bir örneğini oluşturun
            cls_vardiya.vardiyalar vardiyalar = new cls_vardiya.vardiyalar(baslangicTarihi, bitisTarihi);

            // Ayrıca OtoEkle metodunu çağırarak otomatik vardiya ekleme işlemini gerçekleştirebilirsiniz
            vardiyalar.OtoEkle();
            LoadData();


        }

        private void btn_tum_vardiyayi_sil_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Silme işlemi için sorgu
            string silmeSorgusu = "DELETE FROM tbl_vardiya";

            using (var baglan = new MySqlConnection(db_con))
            {
                baglan.Open();

                // MySqlCommand nesnesi oluştur ve parametreleri ekle
                using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                {

                    // SQL sorgusunu çalıştır
                    db_cmd.ExecuteNonQuery();
                }

                // Veritabanı bağlantısını kapat
                baglan.Close();

                // Veri silindikten sonra DataGridView'i güncelle
                LoadData();
            }
        }
    }
}
