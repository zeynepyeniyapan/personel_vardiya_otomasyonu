using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static PersonelOtomasyon.cls_KullaniciSession;

namespace PersonelOtomasyon
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //Kapatma butonu ayarladık
            this.Close();
        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            string db_con = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd='';";

            string kul_eposta = tbx_eposta.Text;
            string kul_sifre = tbx_sifre.Text;

            if (!string.IsNullOrEmpty(kul_eposta) && !string.IsNullOrEmpty(kul_sifre))
            {
                using (var baglan = new MySqlConnection(db_con))
                {
                    try
                    {
                        baglan.Open();

                        using (MySqlCommand db_cmd = new MySqlCommand())
                        {
                            db_cmd.Connection = baglan;
                            db_cmd.CommandText = "SELECT * FROM tbl_personel WHERE email=@eposta AND sifre=@sifre";
                            db_cmd.Parameters.AddWithValue("@eposta", kul_eposta);
                            db_cmd.Parameters.AddWithValue("@sifre", kul_sifre);

                            using (MySqlDataReader db_dr = db_cmd.ExecuteReader())
                            {
                                if (db_dr.Read())
                                {
                                    string userRole = db_dr["rol"].ToString();

                                    if (userRole == "Yönetici")
                                    {
                                        UserSession.Id = db_dr["id"].ToString(); 
                                        UserSession.SicilNo = db_dr["sicil_no"].ToString();
                                        UserSession.AdSoyad = db_dr["ad"].ToString() + " " + db_dr["soyad"].ToString();
                                        this.Hide();
                                        frm_admin admin = new frm_admin();
                                        admin.Show();
                                    }
                                    else if (userRole == "Kullanıcı")
                                    {
                                        UserSession.Id = db_dr["id"].ToString();
                                        UserSession.SicilNo = db_dr["sicil_no"].ToString();
                                        UserSession.AdSoyad = db_dr["ad"].ToString() + " " + db_dr["soyad"].ToString();
                                        this.Hide();
                                        frm_personel personel = new frm_personel();
                                        personel.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bilinmeyen rol: " + userRole);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bağlantı ile ilgili bir sorun oluştu!\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Tam Girilmelidir!");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
