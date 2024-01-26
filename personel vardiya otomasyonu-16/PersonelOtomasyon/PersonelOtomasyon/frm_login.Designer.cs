namespace PersonelOtomasyon
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.tbx_sifre = new System.Windows.Forms.TextBox();
            this.tbx_eposta = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_giris_yap = new System.Windows.Forms.Button();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_giris_paneli
            // 
            this.lbl_giris_paneli.AutoSize = true;
            this.lbl_giris_paneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_giris_paneli.Location = new System.Drawing.Point(120, 1);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(144, 35);
            this.lbl_giris_paneli.TabIndex = 11;
            this.lbl_giris_paneli.Text = "Giriş Paneli";
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(342, 9);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(29, 27);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_eposta.Location = new System.Drawing.Point(18, 52);
            this.lbl_eposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(70, 17);
            this.lbl_eposta.TabIndex = 14;
            this.lbl_eposta.Text = "E-Posta:";
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.pnl_login.Controls.Add(this.tbx_sifre);
            this.pnl_login.Controls.Add(this.tbx_eposta);
            this.pnl_login.Controls.Add(this.lbl_sifre);
            this.pnl_login.Controls.Add(this.lbl_eposta);
            this.pnl_login.Location = new System.Drawing.Point(12, 86);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(359, 162);
            this.pnl_login.TabIndex = 15;
            // 
            // tbx_sifre
            // 
            this.tbx_sifre.Location = new System.Drawing.Point(113, 94);
            this.tbx_sifre.Name = "tbx_sifre";
            this.tbx_sifre.Size = new System.Drawing.Size(169, 20);
            this.tbx_sifre.TabIndex = 17;
            // 
            // tbx_eposta
            // 
            this.tbx_eposta.Location = new System.Drawing.Point(113, 52);
            this.tbx_eposta.Name = "tbx_eposta";
            this.tbx_eposta.Size = new System.Drawing.Size(169, 20);
            this.tbx_eposta.TabIndex = 16;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_sifre.Location = new System.Drawing.Point(18, 94);
            this.lbl_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(47, 17);
            this.lbl_sifre.TabIndex = 15;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.btn_giris_yap.FlatAppearance.BorderSize = 0;
            this.btn_giris_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_yap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_giris_yap.Location = new System.Drawing.Point(12, 289);
            this.btn_giris_yap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(359, 27);
            this.btn_giris_yap.TabIndex = 16;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = false;
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(383, 337);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_giris_yap;
        private System.Windows.Forms.TextBox tbx_sifre;
        private System.Windows.Forms.TextBox tbx_eposta;
        private System.Windows.Forms.Label lbl_sifre;
    }
}

