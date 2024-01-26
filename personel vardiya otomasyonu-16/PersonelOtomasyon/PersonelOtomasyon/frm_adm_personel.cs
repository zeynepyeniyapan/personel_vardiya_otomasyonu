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
using static PersonelOtomasyon.cls_KullaniciSession;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelOtomasyon
{
    public partial class frm_adm_personel : Form
    {
        public frm_adm_personel()
        {
            InitializeComponent();
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_adm_personel_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunları tanımla
            dgw_adm_personel.Columns.Add("id", "#");
            dgw_adm_personel.Columns.Add("ad", "Ad");
            dgw_adm_personel.Columns.Add("soyad", "Soyad");
            dgw_adm_personel.Columns.Add("rol", "Rolü");
            dgw_adm_personel.Columns.Add("sicil_no", "Sicil No");
            dgw_adm_personel.Columns.Add("kadro_tipi", "Kadro Tipi");
            dgw_adm_personel.Columns.Add("unvan", "Ünvanı");
            dgw_adm_personel.Columns.Add("email", "E-Posta");
            dgw_adm_personel.Columns.Add("sifre", "Şifre");
            dgw_adm_personel.Columns.Add("telefon", "Telefon");
            dgw_adm_personel.Columns.Add("tc_no", "Kimlik No");
            dgw_adm_personel.Columns.Add("adres", "Adres");
            dgw_adm_personel.Columns.Add("izin_1", "1. Izin");
            dgw_adm_personel.Columns.Add("izin_2", "2. Izin");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            LoadData();
        }

        // Veriyi yükleyen fonksiyon
        private void LoadData()
        {
            // Tekrara düşmemesi için comboboxları sıfırlıyoruz
            cb_kadro.Items.Clear();
            cb_rol.Items.Clear();

            // Combobox verilerini tanımla
            cb_kadro.Items.Add("İşçi");
            cb_kadro.Items.Add("Memur");

            cb_rol.Items.Add("Kullanıcı");
            cb_rol.Items.Add("Yönetici");

            Dictionary<string, string> gunler = new Dictionary<string, string>
            {
                { "Pazartesi", "Monday" },
                { "Salı", "Tuesday" },
                { "Çarşamba", "Wednesday" },
                { "Perşembe", "Thursday" },
                { "Cuma", "Friday" },
                { "Cumartesi", "Saturday" },
                { "Pazar", "Sunday" },
                { "Yok", "Yok" },
                { "Monday", "Pazartesi" },
                { "Tuesday", "Salı" },
                { "Wednesday", "Çarşamba" },
                { "Thursday", "Perşembe" },
                { "Friday", "Cuma" },
                { "Saturday", "Cumartesi" },
                { "Sunday", "Pazar" }

            };


            Dictionary<string, string> gunler2 = new Dictionary<string, string>
            {
                { "Pazartesi", "Monday" },
                { "Salı", "Tuesday" },
                { "Çarşamba", "Wednesday" },
                { "Perşembe", "Thursday" },
                { "Cuma", "Friday" },
                { "Cumartesi", "Saturday" },
                { "Pazar", "Sunday" },
                { "Yok", "Yok" }

            };
            cb_izin1.DataSource = new BindingSource(gunler2, null);
            cb_izin1.DisplayMember = "Key";
            cb_izin1.ValueMember = "Value";

            cb_izin2.DataSource = new BindingSource(gunler2, null);
            cb_izin2.DisplayMember = "Key";
            cb_izin2.ValueMember = "Value";

            cb_izin2.Visible = false;
            lbl_izin_2.Visible = false;

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
                    db_cmd.CommandText = "SELECT * FROM tbl_personel";
                    db_dr = db_cmd.ExecuteReader();

                    // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                    if (db_dr.HasRows)
                    {
                        dgw_adm_personel.Rows.Clear();
                        while (db_dr.Read())
                        {
                            dgw_adm_personel.Rows.Add(
                                db_dr["id"].ToString(),
                                db_dr["ad"].ToString(),
                                db_dr["soyad"].ToString(),
                                db_dr["rol"].ToString(),
                                db_dr["sicil_no"].ToString(),
                                db_dr["kadro_tipi"].ToString(),
                                db_dr["unvan"].ToString(),
                                db_dr["email"].ToString(),
                                db_dr["sifre"].ToString(),
                                db_dr["telefon"].ToString(),
                                db_dr["tc_no"].ToString(),
                                db_dr["adres"].ToString(),
                                gunler[db_dr["izin_1"].ToString()], 
                                gunler[db_dr["izin_2"].ToString()]
                            );
                        }
                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Personel Bilgisi Bulunamadı!");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya bilgi ver
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }
            }
        }

        private void btn_personel_sil_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (dgw_adm_personel.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_personel.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silmeSorgusu = "DELETE FROM tbl_personel WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand db_cmd = new MySqlCommand(silmeSorgusu, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = dgw_adm_personel.Rows[selectedIndex].Cells["id"].Value.ToString();

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

        private void cb_kadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_kadro.SelectedIndex == 0)
            {
                cb_izin2.Visible = false;
                lbl_izin_2.Visible = false;
            }
            else
            {
                cb_izin2.Visible = true;
                lbl_izin_2.Visible = true;
            }
        }

        private void btn_cikti_al_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dgw_adm_personel.ColumnCount);

                float pageWidth = PageSize.A2.Width; // Sayfa genişliği
                float tableWidth = pageWidth * 0.8f; // Tablo genişliği (sayfa genişliğinin %80'i)

                pdfTable.DefaultCell.Padding = 6;
                pdfTable.WidthPercentage = 100; // Tabloyu sayfanın tam genişliğine yay
                pdfTable.TotalWidth = tableWidth;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                // Sayfa genişliğinin yarısı kadar boş hücre ekle (ortalamak için)
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Colspan = dgw_adm_personel.ColumnCount;
                emptyCell.Border = 0; // Kenarlığı olmayan bir hücre
                pdfTable.AddCell(emptyCell);

                foreach (DataGridViewColumn column in dgw_adm_personel.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                try
                {
                    foreach (DataGridViewRow row in dgw_adm_personel.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Eğer hücre değeri null değilse, PDF tabloya ekle
                            if (cell.Value != null)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
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
                    Paragraph title = new Paragraph("Personel Listesi");
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

        private void btn_personel_kaydet_Click(object sender, EventArgs e)
        {
            if (
		        !string.IsNullOrWhiteSpace(tbox_sicil_no.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_ad.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_soyad.Text) &&
		        !string.IsNullOrWhiteSpace(cb_kadro.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_adres.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_kimlik_no.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_sifre.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_eposta.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_telefon.Text) &&
		        !string.IsNullOrWhiteSpace(tbox_unvan.Text) &&
		        !string.IsNullOrWhiteSpace(cb_izin1.Text) &&
		        !string.IsNullOrWhiteSpace(cb_rol.Text)
            )
            {
                // Veritabanı bağlantı bilgilerini içeren string
                string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

                // MySqlCommand ve MySqlDataReader nesneleri
                MySqlCommand db_cmd;

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // Özel gün eklemek için SQL sorgusu
                    string sorgu = "INSERT INTO tbl_personel (ad, soyad, rol, sicil_no, kadro_tipi, unvan, email, sifre, telefon, tc_no, adres, izin_1, izin_2) VALUES (@ad, @soyad, @rol, @sicil_no, @kadro_tipi, @unvan, @email, @sifre, @telefon, @tc_no, @adres, @izin_1, @izin_2)";
                    db_cmd = new MySqlCommand(sorgu, baglan);

                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    db_cmd.Parameters.AddWithValue("@ad", tbox_ad.Text);
                    db_cmd.Parameters.AddWithValue("@soyad", tbox_soyad.Text);
                    db_cmd.Parameters.AddWithValue("@rol", cb_rol.Text);
                    db_cmd.Parameters.AddWithValue("@sicil_no", tbox_sicil_no.Text);
                    db_cmd.Parameters.AddWithValue("@kadro_tipi", cb_kadro.Text);
                    db_cmd.Parameters.AddWithValue("@unvan", tbox_unvan.Text);
                    db_cmd.Parameters.AddWithValue("@email", tbox_eposta.Text);
                    db_cmd.Parameters.AddWithValue("@sifre", tbox_sifre.Text);
                    db_cmd.Parameters.AddWithValue("@telefon", tbox_telefon.Text);
                    db_cmd.Parameters.AddWithValue("@tc_no", tbox_kimlik_no.Text);
                    db_cmd.Parameters.AddWithValue("@adres", tbox_adres.Text);

                    // Eğer cb_izin1.SelectedItem'ı kullanarak seçili öğeyi almak istiyorsanız
                    string izin1 = cb_izin1.SelectedItem != null ? ((KeyValuePair<string, string>)cb_izin1.SelectedItem).Value : "";
                    string izin2 = cb_izin2.SelectedItem != null ? ((KeyValuePair<string, string>)cb_izin2.SelectedItem).Value : "";

                    db_cmd.Parameters.AddWithValue("@izin_1", izin1);
                    db_cmd.Parameters.AddWithValue("@izin_2", izin2);

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
        private void btn_personel_guncelle_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı güncelle
            if (dgw_adm_personel.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = dgw_adm_personel.CurrentRow.Index;

                // Güncelleme işlemi için sorgu
                string guncelleSorgusu = "UPDATE tbl_personel SET ad = @ad, soyad = @soyad, rol = @rol, sicil_no = @sicil_no, kadro_tipi = @kadro_tipi, unvan = @unvan, email = @email, sifre = @sifre, telefon = @telefon, tc_no = @tc_no, adres=@adres, izin_1 = @izin_1, izin_2 = @izin_2 WHERE id = @id";

                using (var baglan = new MySqlConnection(db_con))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand db_cmd = new MySqlCommand(guncelleSorgusu, baglan))
                    {
                        // Seçili satırın id'sini al
                        string selectedId = dgw_adm_personel.Rows[selectedIndex].Cells["id"].Value.ToString();

                        // Parametreleri ekleyerek SQL sorgusunu güncel hale getir
                        db_cmd.Parameters.AddWithValue("@id", selectedId);
                        db_cmd.Parameters.AddWithValue("@ad", tbox_ad.Text);
                        db_cmd.Parameters.AddWithValue("@soyad", tbox_soyad.Text);
                        db_cmd.Parameters.AddWithValue("@rol", cb_rol.Text);
                        db_cmd.Parameters.AddWithValue("@sicil_no", tbox_sicil_no.Text);
                        db_cmd.Parameters.AddWithValue("@kadro_tipi", cb_kadro.Text);
                        db_cmd.Parameters.AddWithValue("@unvan", tbox_unvan.Text);
                        db_cmd.Parameters.AddWithValue("@email", tbox_eposta.Text);
                        db_cmd.Parameters.AddWithValue("@sifre", tbox_sifre.Text);
                        db_cmd.Parameters.AddWithValue("@telefon", tbox_telefon.Text);
                        db_cmd.Parameters.AddWithValue("@tc_no", tbox_kimlik_no.Text);
                        db_cmd.Parameters.AddWithValue("@adres", tbox_adres.Text);
						// Eğer cb_izin1.SelectedItem'ı kullanarak seçili öğeyi almak istiyorsanız
						string izin1 = cb_izin1.SelectedItem != null ? ((KeyValuePair<string, string>)cb_izin1.SelectedItem).Value : "";
						string izin2 = cb_izin2.SelectedItem != null ? ((KeyValuePair<string, string>)cb_izin2.SelectedItem).Value : "";

						// İzin 1 zorunlu olduğu için kontrol ekleyin
						if (string.IsNullOrEmpty(izin1))
						{
							MessageBox.Show("İzin 1 alanını seçiniz!");
							return;
						}


						db_cmd.Parameters.AddWithValue("@izin_1", izin1);
                        db_cmd.Parameters.AddWithValue("@izin_2", izin2);

                        // SQL sorgusunu çalıştır
                        db_cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri güncellendikten sonra DataGridView'i güncelle
                    LoadData();

                    // TextBox'ları temizle
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }

        private void ClearTextBoxes()
        {
            // TextBox'ları temizle
            tbox_ad.Text = "";
            tbox_soyad.Text = "";
            cb_rol.SelectedIndex = -1;
            tbox_sicil_no.Text = "";
            cb_kadro.SelectedIndex = -1;
            tbox_unvan.Text = "";
            tbox_eposta.Text = "";
            tbox_sifre.Text = "";
            tbox_telefon.Text = "";
            tbox_adres.Text = "";
            tbox_kimlik_no.Text = "";
            cb_izin1.SelectedIndex = -1;
            cb_izin2.SelectedIndex = -1;
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_admin adm = new frm_admin();
            adm.Show();
        }

        private void dgw_adm_personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgw_adm_personel.ClearSelection();
                dgw_adm_personel.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dgw_adm_personel.Rows[e.RowIndex];

                tbox_ad.Text = selectedRow.Cells["ad"].Value?.ToString();
                tbox_soyad.Text = selectedRow.Cells["soyad"].Value?.ToString();
                tbox_sicil_no.Text = selectedRow.Cells["sicil_no"].Value?.ToString();
                cb_kadro.Text = selectedRow.Cells["kadro_tipi"].Value?.ToString();
                tbox_unvan.Text = selectedRow.Cells["unvan"].Value?.ToString();
                cb_rol.Text = selectedRow.Cells["rol"].Value?.ToString();
                tbox_eposta.Text = selectedRow.Cells["email"].Value?.ToString();
                tbox_sifre.Text = selectedRow.Cells["sifre"].Value?.ToString();
                tbox_telefon.Text = selectedRow.Cells["telefon"].Value?.ToString();
                tbox_kimlik_no.Text = selectedRow.Cells["tc_no"].Value?.ToString();
                tbox_adres.Text = selectedRow.Cells["adres"].Value?.ToString();
                cb_izin1.Text = selectedRow.Cells["izin_1"].Value?.ToString();
                cb_izin2.Text = selectedRow.Cells["izin_2"].Value?.ToString();


            }
        }
    }
}
