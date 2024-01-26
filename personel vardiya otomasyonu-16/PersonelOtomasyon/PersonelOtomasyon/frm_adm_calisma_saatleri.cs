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
    public partial class frm_adm_calisma_saatleri : Form
    {
        public frm_adm_calisma_saatleri()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_admin adm = new frm_admin();
            adm.Show();
        }
    }
}
