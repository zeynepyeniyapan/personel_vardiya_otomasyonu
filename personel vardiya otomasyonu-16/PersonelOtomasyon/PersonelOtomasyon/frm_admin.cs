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

namespace PersonelOtomasyon
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //Kapatma butonu ayarladık
            Application.Exit();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            // Personel formunun açılmasını sağlayan kod
            this.Close();
            frm_adm_personel frm_personel = new frm_adm_personel();
            frm_personel.Show();
        }

        private void btn_calisma_saatleri_Click(object sender, EventArgs e)
        {
            // Çalışma Saatleri formunun açılmasını sağlayan kod
            this.Close();
            frm_adm_calisma_saatleri frm_calisma_saatleri = new frm_adm_calisma_saatleri();
            frm_calisma_saatleri.Show();
        }

        private void btn_ozel_gun_Click(object sender, EventArgs e)
        {
            // Özel Günler formunun açılmasını sağlayan kod
            this.Hide();
            frm_adm_ozel_gun frm_og = new frm_adm_ozel_gun();
            frm_og.Show();
        }

        private void btn_izin_Click(object sender, EventArgs e)
        {
            // İzin formunun açılmasını sağlayan kod
            this.Hide();
            frm_adm_izin frm_izin = new frm_adm_izin();
            frm_izin.Show();
        }


        private void btn_vardiyalar_Click(object sender, EventArgs e)
        {
            // Vardiyalar formunun açılmasını sağlayan kod
            this.Hide();
            frm_adm_vardiyalar frm_vardiyalar = new frm_adm_vardiyalar();
            frm_vardiyalar.Show();
        }

        private void btn_mesailer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_adm_mesailer frm_mesailer = new frm_adm_mesailer();
            frm_mesailer.Show();

        }
    }
}
