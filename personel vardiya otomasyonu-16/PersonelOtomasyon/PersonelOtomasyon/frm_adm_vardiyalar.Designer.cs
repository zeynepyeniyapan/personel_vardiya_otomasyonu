namespace PersonelOtomasyon
{
    partial class frm_adm_vardiyalar
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
            this.btn_cikti_al = new System.Windows.Forms.Button();
            this.dgw_adm_vardiyalar = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_vardiya_olustur = new System.Windows.Forms.Button();
            this.btn_vardiya_sil = new System.Windows.Forms.Button();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.lbl_vardiya = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.cb_sicil_no = new System.Windows.Forms.ComboBox();
            this.dtp_vardiya_tarih = new System.Windows.Forms.DateTimePicker();
            this.cb_vardiya_saat = new System.Windows.Forms.ComboBox();
            this.pnl_personel = new System.Windows.Forms.Panel();
            this.cb_lokasyon = new System.Windows.Forms.ComboBox();
            this.lbl_lokasyon = new System.Windows.Forms.Label();
            this.btn_vardiya_guncelle = new System.Windows.Forms.Button();
            this.btn_vardiya_otomatik = new System.Windows.Forms.Button();
            this.dtp_vardiya_baslangic = new System.Windows.Forms.DateTimePicker();
            this.dtp_vardiya_bitis = new System.Windows.Forms.DateTimePicker();
            this.lbl_vardiya_aralik = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.dtp_ara_bitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_ara_baslangic = new System.Windows.Forms.DateTimePicker();
            this.btn_tum_vardiyayi_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_vardiyalar)).BeginInit();
            this.pnl_personel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(1437, 11);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 33);
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
            this.lbl_giris_paneli.Location = new System.Drawing.Point(623, 1);
            this.lbl_giris_paneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(249, 43);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Vardiyalar Paneli";
            // 
            // btn_cikti_al
            // 
            this.btn_cikti_al.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_cikti_al.FlatAppearance.BorderSize = 0;
            this.btn_cikti_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikti_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikti_al.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_cikti_al.Location = new System.Drawing.Point(1183, 69);
            this.btn_cikti_al.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cikti_al.Name = "btn_cikti_al";
            this.btn_cikti_al.Size = new System.Drawing.Size(293, 43);
            this.btn_cikti_al.TabIndex = 18;
            this.btn_cikti_al.Text = "Çıktı Al";
            this.btn_cikti_al.UseVisualStyleBackColor = false;
            this.btn_cikti_al.Click += new System.EventHandler(this.btn_cikti_al_Click_1);
            // 
            // dgw_adm_vardiyalar
            // 
            this.dgw_adm_vardiyalar.AllowUserToResizeColumns = false;
            this.dgw_adm_vardiyalar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_adm_vardiyalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_adm_vardiyalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_adm_vardiyalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_adm_vardiyalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.dgw_adm_vardiyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_adm_vardiyalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_adm_vardiyalar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_adm_vardiyalar.Location = new System.Drawing.Point(12, 293);
            this.dgw_adm_vardiyalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_adm_vardiyalar.Name = "dgw_adm_vardiyalar";
            this.dgw_adm_vardiyalar.RowHeadersWidth = 51;
            this.dgw_adm_vardiyalar.Size = new System.Drawing.Size(1460, 298);
            this.dgw_adm_vardiyalar.TabIndex = 25;
            this.dgw_adm_vardiyalar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_adm_vardiyalar_CellMouseClick);
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
            this.btn_geri.TabIndex = 27;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_vardiya_olustur
            // 
            this.btn_vardiya_olustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_vardiya_olustur.FlatAppearance.BorderSize = 0;
            this.btn_vardiya_olustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vardiya_olustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vardiya_olustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_vardiya_olustur.Location = new System.Drawing.Point(12, 240);
            this.btn_vardiya_olustur.Margin = new System.Windows.Forms.Padding(0);
            this.btn_vardiya_olustur.Name = "btn_vardiya_olustur";
            this.btn_vardiya_olustur.Size = new System.Drawing.Size(231, 43);
            this.btn_vardiya_olustur.TabIndex = 29;
            this.btn_vardiya_olustur.Text = "Vardiya Oluştur";
            this.btn_vardiya_olustur.UseVisualStyleBackColor = false;
            this.btn_vardiya_olustur.Click += new System.EventHandler(this.btn_vardiya_olustur_Click);
            // 
            // btn_vardiya_sil
            // 
            this.btn_vardiya_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_vardiya_sil.FlatAppearance.BorderSize = 0;
            this.btn_vardiya_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vardiya_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vardiya_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_vardiya_sil.Location = new System.Drawing.Point(260, 240);
            this.btn_vardiya_sil.Margin = new System.Windows.Forms.Padding(0);
            this.btn_vardiya_sil.Name = "btn_vardiya_sil";
            this.btn_vardiya_sil.Size = new System.Drawing.Size(249, 43);
            this.btn_vardiya_sil.TabIndex = 30;
            this.btn_vardiya_sil.Text = "Vardiya Sil";
            this.btn_vardiya_sil.UseVisualStyleBackColor = false;
            this.btn_vardiya_sil.Click += new System.EventHandler(this.btn_vardiya_sil_Click);
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_sicil_no.Location = new System.Drawing.Point(23, 22);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(93, 20);
            this.lbl_sicil_no.TabIndex = 14;
            this.lbl_sicil_no.Text = "Sicil No : ";
            // 
            // lbl_vardiya
            // 
            this.lbl_vardiya.AutoSize = true;
            this.lbl_vardiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vardiya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_vardiya.Location = new System.Drawing.Point(23, 121);
            this.lbl_vardiya.Name = "lbl_vardiya";
            this.lbl_vardiya.Size = new System.Drawing.Size(90, 20);
            this.lbl_vardiya.TabIndex = 15;
            this.lbl_vardiya.Text = "Vardiya : ";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_tarih.Location = new System.Drawing.Point(23, 89);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(64, 20);
            this.lbl_tarih.TabIndex = 22;
            this.lbl_tarih.Text = "Tarih :";
            // 
            // cb_sicil_no
            // 
            this.cb_sicil_no.FormattingEnabled = true;
            this.cb_sicil_no.Location = new System.Drawing.Point(153, 17);
            this.cb_sicil_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_sicil_no.Name = "cb_sicil_no";
            this.cb_sicil_no.Size = new System.Drawing.Size(211, 24);
            this.cb_sicil_no.TabIndex = 26;
            // 
            // dtp_vardiya_tarih
            // 
            this.dtp_vardiya_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_vardiya_tarih.Location = new System.Drawing.Point(153, 85);
            this.dtp_vardiya_tarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_vardiya_tarih.Name = "dtp_vardiya_tarih";
            this.dtp_vardiya_tarih.Size = new System.Drawing.Size(211, 22);
            this.dtp_vardiya_tarih.TabIndex = 29;
            this.dtp_vardiya_tarih.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // cb_vardiya_saat
            // 
            this.cb_vardiya_saat.FormattingEnabled = true;
            this.cb_vardiya_saat.Location = new System.Drawing.Point(153, 119);
            this.cb_vardiya_saat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_vardiya_saat.Name = "cb_vardiya_saat";
            this.cb_vardiya_saat.Size = new System.Drawing.Size(211, 24);
            this.cb_vardiya_saat.TabIndex = 30;
            // 
            // pnl_personel
            // 
            this.pnl_personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.pnl_personel.Controls.Add(this.cb_lokasyon);
            this.pnl_personel.Controls.Add(this.cb_vardiya_saat);
            this.pnl_personel.Controls.Add(this.dtp_vardiya_tarih);
            this.pnl_personel.Controls.Add(this.lbl_lokasyon);
            this.pnl_personel.Controls.Add(this.cb_sicil_no);
            this.pnl_personel.Controls.Add(this.lbl_tarih);
            this.pnl_personel.Controls.Add(this.lbl_vardiya);
            this.pnl_personel.Controls.Add(this.lbl_sicil_no);
            this.pnl_personel.Location = new System.Drawing.Point(12, 69);
            this.pnl_personel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_personel.Name = "pnl_personel";
            this.pnl_personel.Size = new System.Drawing.Size(748, 161);
            this.pnl_personel.TabIndex = 28;
            // 
            // cb_lokasyon
            // 
            this.cb_lokasyon.FormattingEnabled = true;
            this.cb_lokasyon.Location = new System.Drawing.Point(153, 52);
            this.cb_lokasyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_lokasyon.Name = "cb_lokasyon";
            this.cb_lokasyon.Size = new System.Drawing.Size(211, 24);
            this.cb_lokasyon.TabIndex = 31;
            this.cb_lokasyon.SelectedIndexChanged += new System.EventHandler(this.cb_lokasyon_SelectedIndexChanged);
            // 
            // lbl_lokasyon
            // 
            this.lbl_lokasyon.AutoSize = true;
            this.lbl_lokasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lokasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_lokasyon.Location = new System.Drawing.Point(23, 52);
            this.lbl_lokasyon.Name = "lbl_lokasyon";
            this.lbl_lokasyon.Size = new System.Drawing.Size(106, 20);
            this.lbl_lokasyon.TabIndex = 27;
            this.lbl_lokasyon.Text = "Lokasyon : ";
            // 
            // btn_vardiya_guncelle
            // 
            this.btn_vardiya_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_vardiya_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_vardiya_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vardiya_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vardiya_guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_vardiya_guncelle.Location = new System.Drawing.Point(525, 240);
            this.btn_vardiya_guncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_vardiya_guncelle.Name = "btn_vardiya_guncelle";
            this.btn_vardiya_guncelle.Size = new System.Drawing.Size(235, 43);
            this.btn_vardiya_guncelle.TabIndex = 31;
            this.btn_vardiya_guncelle.Text = "Vardiya Güncelle";
            this.btn_vardiya_guncelle.UseVisualStyleBackColor = false;
            this.btn_vardiya_guncelle.Click += new System.EventHandler(this.btn_vardiya_guncelle_Click);
            // 
            // btn_vardiya_otomatik
            // 
            this.btn_vardiya_otomatik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.btn_vardiya_otomatik.FlatAppearance.BorderSize = 0;
            this.btn_vardiya_otomatik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vardiya_otomatik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vardiya_otomatik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_vardiya_otomatik.Location = new System.Drawing.Point(19, 96);
            this.btn_vardiya_otomatik.Margin = new System.Windows.Forms.Padding(0);
            this.btn_vardiya_otomatik.Name = "btn_vardiya_otomatik";
            this.btn_vardiya_otomatik.Size = new System.Drawing.Size(356, 43);
            this.btn_vardiya_otomatik.TabIndex = 32;
            this.btn_vardiya_otomatik.Text = "Otomatik Vardiya Oluştur";
            this.btn_vardiya_otomatik.UseVisualStyleBackColor = false;
            this.btn_vardiya_otomatik.Click += new System.EventHandler(this.btn_vardiya_otomatik_Click);
            // 
            // dtp_vardiya_baslangic
            // 
            this.dtp_vardiya_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_vardiya_baslangic.Location = new System.Drawing.Point(19, 54);
            this.dtp_vardiya_baslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_vardiya_baslangic.Name = "dtp_vardiya_baslangic";
            this.dtp_vardiya_baslangic.Size = new System.Drawing.Size(167, 22);
            this.dtp_vardiya_baslangic.TabIndex = 32;
            this.dtp_vardiya_baslangic.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // dtp_vardiya_bitis
            // 
            this.dtp_vardiya_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_vardiya_bitis.Location = new System.Drawing.Point(207, 54);
            this.dtp_vardiya_bitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_vardiya_bitis.Name = "dtp_vardiya_bitis";
            this.dtp_vardiya_bitis.Size = new System.Drawing.Size(167, 22);
            this.dtp_vardiya_bitis.TabIndex = 33;
            this.dtp_vardiya_bitis.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // lbl_vardiya_aralik
            // 
            this.lbl_vardiya_aralik.AutoSize = true;
            this.lbl_vardiya_aralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vardiya_aralik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_vardiya_aralik.Location = new System.Drawing.Point(15, 21);
            this.lbl_vardiya_aralik.Name = "lbl_vardiya_aralik";
            this.lbl_vardiya_aralik.Size = new System.Drawing.Size(237, 20);
            this.lbl_vardiya_aralik.TabIndex = 32;
            this.lbl_vardiya_aralik.Text = "Vardiya Gün Aralığı Girin : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.lbl_vardiya_aralik);
            this.panel1.Controls.Add(this.btn_vardiya_otomatik);
            this.panel1.Controls.Add(this.dtp_vardiya_bitis);
            this.panel1.Controls.Add(this.dtp_vardiya_baslangic);
            this.panel1.Location = new System.Drawing.Point(781, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 156);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_ara);
            this.panel2.Controls.Add(this.dtp_ara_bitis);
            this.panel2.Controls.Add(this.dtp_ara_baslangic);
            this.panel2.Location = new System.Drawing.Point(1183, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 156);
            this.panel2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Aranacak Gün Aralığı Girin : ";
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.btn_ara.FlatAppearance.BorderSize = 0;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_ara.Location = new System.Drawing.Point(12, 96);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(267, 43);
            this.btn_ara.TabIndex = 32;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // dtp_ara_bitis
            // 
            this.dtp_ara_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ara_bitis.Location = new System.Drawing.Point(159, 54);
            this.dtp_ara_bitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ara_bitis.Name = "dtp_ara_bitis";
            this.dtp_ara_bitis.Size = new System.Drawing.Size(119, 22);
            this.dtp_ara_bitis.TabIndex = 33;
            this.dtp_ara_bitis.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // dtp_ara_baslangic
            // 
            this.dtp_ara_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ara_baslangic.Location = new System.Drawing.Point(19, 54);
            this.dtp_ara_baslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ara_baslangic.Name = "dtp_ara_baslangic";
            this.dtp_ara_baslangic.Size = new System.Drawing.Size(128, 22);
            this.dtp_ara_baslangic.TabIndex = 32;
            this.dtp_ara_baslangic.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // btn_tum_vardiyayi_sil
            // 
            this.btn_tum_vardiyayi_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_tum_vardiyayi_sil.FlatAppearance.BorderSize = 0;
            this.btn_tum_vardiyayi_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tum_vardiyayi_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tum_vardiyayi_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_tum_vardiyayi_sil.Location = new System.Drawing.Point(781, 69);
            this.btn_tum_vardiyayi_sil.Margin = new System.Windows.Forms.Padding(0);
            this.btn_tum_vardiyayi_sil.Name = "btn_tum_vardiyayi_sil";
            this.btn_tum_vardiyayi_sil.Size = new System.Drawing.Size(393, 43);
            this.btn_tum_vardiyayi_sil.TabIndex = 36;
            this.btn_tum_vardiyayi_sil.Text = "Tüm Vardiyaları Sil";
            this.btn_tum_vardiyayi_sil.UseVisualStyleBackColor = false;
            this.btn_tum_vardiyayi_sil.Click += new System.EventHandler(this.btn_tum_vardiyayi_sil_Click);
            // 
            // frm_adm_vardiyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1488, 606);
            this.Controls.Add(this.btn_tum_vardiyayi_sil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_vardiya_guncelle);
            this.Controls.Add(this.btn_vardiya_sil);
            this.Controls.Add(this.btn_vardiya_olustur);
            this.Controls.Add(this.pnl_personel);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dgw_adm_vardiyalar);
            this.Controls.Add(this.btn_cikti_al);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_adm_vardiyalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesailer";
            this.Load += new System.EventHandler(this.frm_adm_mesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_vardiyalar)).EndInit();
            this.pnl_personel.ResumeLayout(false);
            this.pnl_personel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.Button btn_cikti_al;
        private System.Windows.Forms.DataGridView dgw_adm_vardiyalar;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_vardiya_olustur;
        private System.Windows.Forms.Button btn_vardiya_sil;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.Label lbl_vardiya;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.ComboBox cb_sicil_no;
        private System.Windows.Forms.DateTimePicker dtp_vardiya_tarih;
        private System.Windows.Forms.ComboBox cb_vardiya_saat;
        private System.Windows.Forms.Panel pnl_personel;
        private System.Windows.Forms.ComboBox cb_lokasyon;
        private System.Windows.Forms.Label lbl_lokasyon;
        private System.Windows.Forms.Button btn_vardiya_guncelle;
        private System.Windows.Forms.Button btn_vardiya_otomatik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_vardiya_baslangic;
        private System.Windows.Forms.DateTimePicker dtp_vardiya_bitis;
        private System.Windows.Forms.Label lbl_vardiya_aralik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.DateTimePicker dtp_ara_bitis;
        private System.Windows.Forms.DateTimePicker dtp_ara_baslangic;
        private System.Windows.Forms.Button btn_tum_vardiyayi_sil;
    }
}