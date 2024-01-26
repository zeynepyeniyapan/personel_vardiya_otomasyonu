namespace PersonelOtomasyon
{
    partial class frm_personel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            this.dgw_personel_vardiya = new System.Windows.Forms.DataGridView();
            this.btn_cikti_al = new System.Windows.Forms.Button();
            this.pnl_per_profil = new System.Windows.Forms.Panel();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_unvan = new System.Windows.Forms.Label();
            this.lbl_kadro = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_per_profil = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personel_vardiya)).BeginInit();
            this.pnl_per_profil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(762, 9);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(29, 27);
            this.btn_kapat.TabIndex = 17;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_giris_paneli
            // 
            this.lbl_giris_paneli.AutoSize = true;
            this.lbl_giris_paneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_giris_paneli.Location = new System.Drawing.Point(298, 1);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(188, 35);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Personel Paneli";
            // 
            // dgw_personel_vardiya
            // 
            this.dgw_personel_vardiya.AllowUserToResizeColumns = false;
            this.dgw_personel_vardiya.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_personel_vardiya.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_personel_vardiya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_personel_vardiya.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_personel_vardiya.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.dgw_personel_vardiya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_personel_vardiya.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_personel_vardiya.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_personel_vardiya.Location = new System.Drawing.Point(12, 172);
            this.dgw_personel_vardiya.Name = "dgw_personel_vardiya";
            this.dgw_personel_vardiya.Size = new System.Drawing.Size(776, 230);
            this.dgw_personel_vardiya.TabIndex = 18;
            // 
            // btn_cikti_al
            // 
            this.btn_cikti_al.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_cikti_al.FlatAppearance.BorderSize = 0;
            this.btn_cikti_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikti_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikti_al.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_cikti_al.Location = new System.Drawing.Point(666, 414);
            this.btn_cikti_al.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cikti_al.Name = "btn_cikti_al";
            this.btn_cikti_al.Size = new System.Drawing.Size(122, 27);
            this.btn_cikti_al.TabIndex = 19;
            this.btn_cikti_al.Text = "Çıktı Al";
            this.btn_cikti_al.UseVisualStyleBackColor = false;
            this.btn_cikti_al.Click += new System.EventHandler(this.btn_cikti_al_Click);
            // 
            // pnl_per_profil
            // 
            this.pnl_per_profil.Controls.Add(this.label22);
            this.pnl_per_profil.Controls.Add(this.lbl_sicil_no);
            this.pnl_per_profil.Controls.Add(this.lbl_telefon);
            this.pnl_per_profil.Controls.Add(this.lbl_unvan);
            this.pnl_per_profil.Controls.Add(this.lbl_kadro);
            this.pnl_per_profil.Controls.Add(this.lbl_eposta);
            this.pnl_per_profil.Controls.Add(this.lbl_ad_soyad);
            this.pnl_per_profil.Controls.Add(this.lbl_per_profil);
            this.pnl_per_profil.Location = new System.Drawing.Point(12, 54);
            this.pnl_per_profil.Name = "pnl_per_profil";
            this.pnl_per_profil.Size = new System.Drawing.Size(776, 100);
            this.pnl_per_profil.TabIndex = 20;
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_sicil_no.Location = new System.Drawing.Point(512, 13);
            this.lbl_sicil_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(131, 17);
            this.lbl_sicil_no.TabIndex = 27;
            this.lbl_sicil_no.Text = "Sicil Numarası :  ";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_telefon.Location = new System.Drawing.Point(21, 64);
            this.lbl_telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(78, 17);
            this.lbl_telefon.TabIndex = 26;
            this.lbl_telefon.Text = "Telefon : ";
            // 
            // lbl_unvan
            // 
            this.lbl_unvan.AutoSize = true;
            this.lbl_unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_unvan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_unvan.Location = new System.Drawing.Point(512, 45);
            this.lbl_unvan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_unvan.Name = "lbl_unvan";
            this.lbl_unvan.Size = new System.Drawing.Size(69, 17);
            this.lbl_unvan.TabIndex = 25;
            this.lbl_unvan.Text = "Ünvan : ";
            // 
            // lbl_kadro
            // 
            this.lbl_kadro.AutoSize = true;
            this.lbl_kadro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kadro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_kadro.Location = new System.Drawing.Point(250, 64);
            this.lbl_kadro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kadro.Name = "lbl_kadro";
            this.lbl_kadro.Size = new System.Drawing.Size(61, 17);
            this.lbl_kadro.TabIndex = 24;
            this.lbl_kadro.Text = "Kadro :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_eposta.Location = new System.Drawing.Point(250, 31);
            this.lbl_eposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(80, 17);
            this.lbl_eposta.TabIndex = 23;
            this.lbl_eposta.Text = "E-Posta : ";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(21, 31);
            this.lbl_ad_soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(97, 17);
            this.lbl_ad_soyad.TabIndex = 22;
            this.lbl_ad_soyad.Text = "Ad Soyad :  ";
            // 
            // lbl_per_profil
            // 
            this.lbl_per_profil.AutoSize = true;
            this.lbl_per_profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_per_profil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_per_profil.Location = new System.Drawing.Point(2, 0);
            this.lbl_per_profil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_per_profil.Name = "lbl_per_profil";
            this.lbl_per_profil.Size = new System.Drawing.Size(119, 17);
            this.lbl_per_profil.TabIndex = 21;
            this.lbl_per_profil.Text = "Personel Profili";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label22.Location = new System.Drawing.Point(512, 83);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 17);
            this.label22.TabIndex = 28;
            this.label22.Text = "Prim:";
            // 
            // frm_personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_per_profil);
            this.Controls.Add(this.btn_cikti_al);
            this.Controls.Add(this.dgw_personel_vardiya);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Paneli";
            this.Load += new System.EventHandler(this.frm_personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personel_vardiya)).EndInit();
            this.pnl_per_profil.ResumeLayout(false);
            this.pnl_per_profil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.DataGridView dgw_personel_vardiya;
        private System.Windows.Forms.Button btn_cikti_al;
        private System.Windows.Forms.Panel pnl_per_profil;
        private System.Windows.Forms.Label lbl_per_profil;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_unvan;
        private System.Windows.Forms.Label lbl_kadro;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Label label22;
    }
}