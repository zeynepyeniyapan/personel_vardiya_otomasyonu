namespace PersonelOtomasyon
{
    partial class frm_adm_ozel_gun
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
            this.lbl_ozel_gun = new System.Windows.Forms.Label();
            this.tbx_og_ad = new System.Windows.Forms.TextBox();
            this.lbl_og_ad = new System.Windows.Forms.Label();
            this.btn_og_kaydet = new System.Windows.Forms.Button();
            this.lbl_og_tarih = new System.Windows.Forms.Label();
            this.pnl_og = new System.Windows.Forms.Panel();
            this.dtp_og_tarih = new System.Windows.Forms.DateTimePicker();
            this.dgw_adm_ozel_gunler = new System.Windows.Forms.DataGridView();
            this.btn_og_sil = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.pnl_og.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_ozel_gunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(692, 11);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 33);
            this.btn_kapat.TabIndex = 17;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_ozel_gun
            // 
            this.lbl_ozel_gun.AutoSize = true;
            this.lbl_ozel_gun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.lbl_ozel_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ozel_gun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_ozel_gun.Location = new System.Drawing.Point(288, 1);
            this.lbl_ozel_gun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ozel_gun.Name = "lbl_ozel_gun";
            this.lbl_ozel_gun.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_ozel_gun.Size = new System.Drawing.Size(183, 43);
            this.lbl_ozel_gun.TabIndex = 16;
            this.lbl_ozel_gun.Text = "Özel Günler";
            // 
            // tbx_og_ad
            // 
            this.tbx_og_ad.Location = new System.Drawing.Point(203, 60);
            this.tbx_og_ad.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_og_ad.Name = "tbx_og_ad";
            this.tbx_og_ad.Size = new System.Drawing.Size(224, 22);
            this.tbx_og_ad.TabIndex = 16;
            // 
            // lbl_og_ad
            // 
            this.lbl_og_ad.AutoSize = true;
            this.lbl_og_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_og_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_og_ad.Location = new System.Drawing.Point(24, 64);
            this.lbl_og_ad.Name = "lbl_og_ad";
            this.lbl_og_ad.Size = new System.Drawing.Size(139, 20);
            this.lbl_og_ad.TabIndex = 14;
            this.lbl_og_ad.Text = "Özel Gün Adı : ";
            // 
            // btn_og_kaydet
            // 
            this.btn_og_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_og_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_og_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_og_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_og_kaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_og_kaydet.Location = new System.Drawing.Point(144, 286);
            this.btn_og_kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_og_kaydet.Name = "btn_og_kaydet";
            this.btn_og_kaydet.Size = new System.Drawing.Size(229, 33);
            this.btn_og_kaydet.TabIndex = 19;
            this.btn_og_kaydet.Text = "Özel Gün Kaydet";
            this.btn_og_kaydet.UseVisualStyleBackColor = false;
            this.btn_og_kaydet.Click += new System.EventHandler(this.btn_og_kaydet_Click);
            // 
            // lbl_og_tarih
            // 
            this.lbl_og_tarih.AutoSize = true;
            this.lbl_og_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_og_tarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_og_tarih.Location = new System.Drawing.Point(24, 116);
            this.lbl_og_tarih.Name = "lbl_og_tarih";
            this.lbl_og_tarih.Size = new System.Drawing.Size(75, 20);
            this.lbl_og_tarih.TabIndex = 15;
            this.lbl_og_tarih.Text = "Tarihi : ";
            // 
            // pnl_og
            // 
            this.pnl_og.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.pnl_og.Controls.Add(this.dtp_og_tarih);
            this.pnl_og.Controls.Add(this.tbx_og_ad);
            this.pnl_og.Controls.Add(this.lbl_og_tarih);
            this.pnl_og.Controls.Add(this.lbl_og_ad);
            this.pnl_og.Location = new System.Drawing.Point(144, 65);
            this.pnl_og.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_og.Name = "pnl_og";
            this.pnl_og.Size = new System.Drawing.Size(479, 199);
            this.pnl_og.TabIndex = 18;
            // 
            // dtp_og_tarih
            // 
            this.dtp_og_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_og_tarih.Location = new System.Drawing.Point(203, 112);
            this.dtp_og_tarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_og_tarih.Name = "dtp_og_tarih";
            this.dtp_og_tarih.Size = new System.Drawing.Size(224, 22);
            this.dtp_og_tarih.TabIndex = 17;
            this.dtp_og_tarih.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // dgw_adm_ozel_gunler
            // 
            this.dgw_adm_ozel_gunler.AllowUserToResizeColumns = false;
            this.dgw_adm_ozel_gunler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_adm_ozel_gunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_adm_ozel_gunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_adm_ozel_gunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_adm_ozel_gunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.dgw_adm_ozel_gunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_adm_ozel_gunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_adm_ozel_gunler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_adm_ozel_gunler.Location = new System.Drawing.Point(144, 341);
            this.dgw_adm_ozel_gunler.Margin = new System.Windows.Forms.Padding(4);
            this.dgw_adm_ozel_gunler.Name = "dgw_adm_ozel_gunler";
            this.dgw_adm_ozel_gunler.RowHeadersWidth = 51;
            this.dgw_adm_ozel_gunler.Size = new System.Drawing.Size(479, 198);
            this.dgw_adm_ozel_gunler.TabIndex = 20;
            // 
            // btn_og_sil
            // 
            this.btn_og_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_og_sil.FlatAppearance.BorderSize = 0;
            this.btn_og_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_og_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_og_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_og_sil.Location = new System.Drawing.Point(393, 286);
            this.btn_og_sil.Margin = new System.Windows.Forms.Padding(0);
            this.btn_og_sil.Name = "btn_og_sil";
            this.btn_og_sil.Size = new System.Drawing.Size(229, 33);
            this.btn_og_sil.TabIndex = 21;
            this.btn_og_sil.Text = "Özel Gün Sil";
            this.btn_og_sil.UseVisualStyleBackColor = false;
            this.btn_og_sil.Click += new System.EventHandler(this.btn_og_sil_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(12, 11);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(39, 33);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frm_adm_ozel_gun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(740, 554);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_og_sil);
            this.Controls.Add(this.dgw_adm_ozel_gunler);
            this.Controls.Add(this.btn_og_kaydet);
            this.Controls.Add(this.pnl_og);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_ozel_gun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_adm_ozel_gun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özel Günler";
            this.Load += new System.EventHandler(this.frm_adm_ozel_gun_Load);
            this.pnl_og.ResumeLayout(false);
            this.pnl_og.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_ozel_gunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_ozel_gun;
        private System.Windows.Forms.TextBox tbx_og_ad;
        private System.Windows.Forms.Label lbl_og_ad;
        private System.Windows.Forms.Button btn_og_kaydet;
        private System.Windows.Forms.Label lbl_og_tarih;
        private System.Windows.Forms.Panel pnl_og;
        private System.Windows.Forms.DateTimePicker dtp_og_tarih;
        private System.Windows.Forms.DataGridView dgw_adm_ozel_gunler;
        private System.Windows.Forms.Button btn_og_sil;
        private System.Windows.Forms.Button btn_geri;
    }
}