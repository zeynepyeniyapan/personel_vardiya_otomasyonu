namespace PersonelOtomasyon
{
    partial class frm_adm_mesailer
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
            this.dgw_adm_mesailer = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_izin_ekle = new System.Windows.Forms.Button();
            this.dtp_izin_tarih = new System.Windows.Forms.DateTimePicker();
            this.lbl_og_ad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.lbl_secilen_sicil = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_prim_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_mesailer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.lbl_giris_paneli.Location = new System.Drawing.Point(287, 1);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(185, 35);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Mesailer Paneli";
            // 
            // dgw_adm_mesailer
            // 
            this.dgw_adm_mesailer.AllowUserToResizeColumns = false;
            this.dgw_adm_mesailer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_adm_mesailer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_adm_mesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_adm_mesailer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_adm_mesailer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.dgw_adm_mesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_adm_mesailer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_adm_mesailer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_adm_mesailer.Location = new System.Drawing.Point(9, 176);
            this.dgw_adm_mesailer.Name = "dgw_adm_mesailer";
            this.dgw_adm_mesailer.Size = new System.Drawing.Size(779, 262);
            this.dgw_adm_mesailer.TabIndex = 26;
            this.dgw_adm_mesailer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_adm_mesailer_CellMouseClick);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(12, 9);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(29, 27);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_izin_ekle
            // 
            this.btn_izin_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.btn_izin_ekle.FlatAppearance.BorderSize = 0;
            this.btn_izin_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_izin_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_izin_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_izin_ekle.Location = new System.Drawing.Point(189, 51);
            this.btn_izin_ekle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_izin_ekle.Name = "btn_izin_ekle";
            this.btn_izin_ekle.Size = new System.Drawing.Size(112, 26);
            this.btn_izin_ekle.TabIndex = 29;
            this.btn_izin_ekle.Text = "İzin Ekle";
            this.btn_izin_ekle.UseVisualStyleBackColor = false;
            this.btn_izin_ekle.Click += new System.EventHandler(this.btn_izin_ekle_Click);
            // 
            // dtp_izin_tarih
            // 
            this.dtp_izin_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_izin_tarih.Location = new System.Drawing.Point(21, 53);
            this.dtp_izin_tarih.Name = "dtp_izin_tarih";
            this.dtp_izin_tarih.Size = new System.Drawing.Size(150, 20);
            this.dtp_izin_tarih.TabIndex = 30;
            // 
            // lbl_og_ad
            // 
            this.lbl_og_ad.AutoSize = true;
            this.lbl_og_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_og_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_og_ad.Location = new System.Drawing.Point(20, 20);
            this.lbl_og_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_og_ad.Name = "lbl_og_ad";
            this.lbl_og_ad.Size = new System.Drawing.Size(140, 17);
            this.lbl_og_ad.TabIndex = 31;
            this.lbl_og_ad.Text = "İzin Tarihi Seçin : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.lbl_og_ad);
            this.panel1.Controls.Add(this.btn_izin_ekle);
            this.panel1.Controls.Add(this.dtp_izin_tarih);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 100);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.lbl_ad_soyad);
            this.panel2.Controls.Add(this.lbl_secilen_sicil);
            this.panel2.Location = new System.Drawing.Point(337, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(13, 51);
            this.lbl_ad_soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(0, 17);
            this.lbl_ad_soyad.TabIndex = 33;
            // 
            // lbl_secilen_sicil
            // 
            this.lbl_secilen_sicil.AutoSize = true;
            this.lbl_secilen_sicil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilen_sicil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_secilen_sicil.Location = new System.Drawing.Point(13, 20);
            this.lbl_secilen_sicil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_secilen_sicil.Name = "lbl_secilen_sicil";
            this.lbl_secilen_sicil.Size = new System.Drawing.Size(104, 17);
            this.lbl_secilen_sicil.TabIndex = 32;
            this.lbl_secilen_sicil.Text = "Bir Kişi Seçin";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_prim_ekle);
            this.panel3.Location = new System.Drawing.Point(543, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 100);
            this.panel3.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Prim Eklemek İçin Tıklayın :";
            // 
            // btn_prim_ekle
            // 
            this.btn_prim_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.btn_prim_ekle.FlatAppearance.BorderSize = 0;
            this.btn_prim_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prim_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_prim_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_prim_ekle.Location = new System.Drawing.Point(23, 53);
            this.btn_prim_ekle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_prim_ekle.Name = "btn_prim_ekle";
            this.btn_prim_ekle.Size = new System.Drawing.Size(112, 26);
            this.btn_prim_ekle.TabIndex = 29;
            this.btn_prim_ekle.Text = "Prim Ekle";
            this.btn_prim_ekle.UseVisualStyleBackColor = false;
            this.btn_prim_ekle.Click += new System.EventHandler(this.btn_prim_ekle_Click);
            // 
            // frm_adm_mesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dgw_adm_mesailer);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_adm_mesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adm_mesailer";
            this.Load += new System.EventHandler(this.frm_adm_mesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_mesailer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.DataGridView dgw_adm_mesailer;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_izin_ekle;
        private System.Windows.Forms.DateTimePicker dtp_izin_tarih;
        private System.Windows.Forms.Label lbl_og_ad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Label lbl_secilen_sicil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_prim_ekle;
    }
}