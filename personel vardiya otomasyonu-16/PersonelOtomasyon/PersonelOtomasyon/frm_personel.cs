using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static PersonelOtomasyon.cls_KullaniciSession;

namespace PersonelOtomasyon
{
    public partial class frm_personel : Form
    {
        public frm_personel()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_personel_Load(object sender, EventArgs e)
        {
            dgw_personel_vardiya.Columns.Add("tarih_gun", "Tarih Gün");
            dgw_personel_vardiya.Columns.Add("tarih_saat", "Tarih Saat");
            dgw_personel_vardiya.Columns.Add("bolge", "Bölge");

            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";
            MySqlCommand db_cmd, db_cmd2;
            MySqlDataReader db_dr, db_dr2;

            using (var baglan = new MySqlConnection(db_con))
            {
                try
                {
                    baglan.Open();
                    db_cmd = new MySqlCommand();
                    db_cmd.Connection = baglan;
                    db_cmd.CommandText = "SELECT * FROM tbl_personel where id='" + UserSession.Id + "'";
                    db_dr = db_cmd.ExecuteReader();

                    if (db_dr.Read())
                    {
                        lbl_ad_soyad.Text = "Ad Soyad: " + db_dr["ad"].ToString() + " " + db_dr["soyad"].ToString();
                        lbl_sicil_no.Text = "Sicil No: " + db_dr["sicil_no"].ToString();
                        lbl_kadro.Text = "Kadro Tipi: " + db_dr["kadro_tipi"].ToString();
                        lbl_unvan.Text = "Ünvan: " + db_dr["unvan"].ToString();
                        lbl_telefon.Text = "Telefon: " + db_dr["telefon"].ToString();
                        lbl_eposta.Text = "E-Posta: " + db_dr["email"].ToString();
                        label22.Text = "Prim: " + db_dr["prim"].ToString();

                        baglan.Close();

                        try
                        {
                            baglan.Open();
                            db_cmd2 = new MySqlCommand();
                            db_cmd2.Connection = baglan;
                            db_cmd2.CommandText = "SELECT * FROM tbl_vardiya where sicil_no='" + UserSession.SicilNo + "'";
                            db_dr2 = db_cmd2.ExecuteReader();
                            if (db_dr2.HasRows)
                            {
                                dgw_personel_vardiya.Rows.Clear();
                                while (db_dr2.Read())
                                {
                                    dgw_personel_vardiya.Rows.Add(
                                        db_dr2["tarih_gun"].ToString(),
                                        db_dr2["tarih_saat"].ToString(),
                                        db_dr2["bolge"].ToString()
                                    );
                                }
                                baglan.Close();
                            }
                            else
                            {
                                MessageBox.Show("Personele Ait Vardiya Bilgisi Bulunamadı!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }
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
                PdfPTable pdfTable = new PdfPTable(dgw_personel_vardiya.ColumnCount);

                float pageWidth = PageSize.A2.Width; // Sayfa genişliği
                float tableWidth = pageWidth * 0.8f; // Tablo genişliği (sayfa genişliğinin %80'i)

                pdfTable.DefaultCell.Padding = 6;
                pdfTable.WidthPercentage = 100; // Tabloyu sayfanın tam genişliğine yay
                pdfTable.TotalWidth = tableWidth;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                // Sayfa genişliğinin yarısı kadar boş hücre ekle (ortalamak için)
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Colspan = dgw_personel_vardiya.ColumnCount;
                emptyCell.Border = 0; // Kenarlığı olmayan bir hücre
                pdfTable.AddCell(emptyCell);

                foreach (DataGridViewColumn column in dgw_personel_vardiya.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                try
                {
                    foreach (DataGridViewRow row in dgw_personel_vardiya.Rows)
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
                    Paragraph title = new Paragraph(UserSession.AdSoyad + " Personel Vardiya Programi");
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
    }
}
