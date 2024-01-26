namespace PersonelOtomasyon
{
    partial class frm_adm_personel
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
            this.btn_personel_sil = new System.Windows.Forms.Button();
            this.dgw_adm_personel = new System.Windows.Forms.DataGridView();
            this.btn_personel_kaydet = new System.Windows.Forms.Button();
            this.pnl_personel = new System.Windows.Forms.Panel();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.tbox_adres = new System.Windows.Forms.TextBox();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_izin2 = new System.Windows.Forms.ComboBox();
            this.cb_izin1 = new System.Windows.Forms.ComboBox();
            this.cb_kadro = new System.Windows.Forms.ComboBox();
            this.tbox_unvan = new System.Windows.Forms.TextBox();
            this.lbl_izin_1 = new System.Windows.Forms.Label();
            this.lbl_izin_2 = new System.Windows.Forms.Label();
            this.lbl_unvan = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.tbox_telefon = new System.Windows.Forms.TextBox();
            this.lbl_kadro_tip = new System.Windows.Forms.Label();
            this.tbox_eposta = new System.Windows.Forms.TextBox();
            this.tbox_sifre = new System.Windows.Forms.TextBox();
            this.tbox_kimlik_no = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_kimlik_no = new System.Windows.Forms.Label();
            this.tbox_soyad = new System.Windows.Forms.TextBox();
            this.tbox_ad = new System.Windows.Forms.TextBox();
            this.tbox_sicil_no = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.btn_cikti_al = new System.Windows.Forms.Button();
            this.btn_personel_guncelle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_personel)).BeginInit();
            this.pnl_personel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(1154, 9);
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
            this.lbl_giris_paneli.Location = new System.Drawing.Point(553, 1);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(115, 35);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Personel";
            // 
            // btn_personel_sil
            // 
            this.btn_personel_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_personel_sil.FlatAppearance.BorderSize = 0;
            this.btn_personel_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personel_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_personel_sil.Location = new System.Drawing.Point(338, 326);
            this.btn_personel_sil.Margin = new System.Windows.Forms.Padding(0);
            this.btn_personel_sil.Name = "btn_personel_sil";
            this.btn_personel_sil.Size = new System.Drawing.Size(237, 27);
            this.btn_personel_sil.TabIndex = 29;
            this.btn_personel_sil.Text = "Personel Sil";
            this.btn_personel_sil.UseVisualStyleBackColor = false;
            this.btn_personel_sil.Click += new System.EventHandler(this.btn_personel_sil_Click);
            // 
            // dgw_adm_personel
            // 
            this.dgw_adm_personel.AllowUserToResizeColumns = false;
            this.dgw_adm_personel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_adm_personel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_adm_personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_adm_personel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_adm_personel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.dgw_adm_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_adm_personel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_adm_personel.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_adm_personel.Location = new System.Drawing.Point(15, 365);
            this.dgw_adm_personel.Name = "dgw_adm_personel";
            this.dgw_adm_personel.Size = new System.Drawing.Size(1168, 290);
            this.dgw_adm_personel.TabIndex = 28;
            this.dgw_adm_personel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_adm_personel_CellDoubleClick);
            // 
            // btn_personel_kaydet
            // 
            this.btn_personel_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_personel_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_personel_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personel_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel_kaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_personel_kaydet.Location = new System.Drawing.Point(12, 326);
            this.btn_personel_kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_personel_kaydet.Name = "btn_personel_kaydet";
            this.btn_personel_kaydet.Size = new System.Drawing.Size(249, 27);
            this.btn_personel_kaydet.TabIndex = 27;
            this.btn_personel_kaydet.Text = "Personel Kaydet";
            this.btn_personel_kaydet.UseVisualStyleBackColor = false;
            this.btn_personel_kaydet.Click += new System.EventHandler(this.btn_personel_kaydet_Click);
            // 
            // pnl_personel
            // 
            this.pnl_personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.pnl_personel.Controls.Add(this.lbl_adres);
            this.pnl_personel.Controls.Add(this.tbox_adres);
            this.pnl_personel.Controls.Add(this.cb_rol);
            this.pnl_personel.Controls.Add(this.label1);
            this.pnl_personel.Controls.Add(this.cb_izin2);
            this.pnl_personel.Controls.Add(this.cb_izin1);
            this.pnl_personel.Controls.Add(this.cb_kadro);
            this.pnl_personel.Controls.Add(this.tbox_unvan);
            this.pnl_personel.Controls.Add(this.lbl_izin_1);
            this.pnl_personel.Controls.Add(this.lbl_izin_2);
            this.pnl_personel.Controls.Add(this.lbl_unvan);
            this.pnl_personel.Controls.Add(this.lbl_telefon);
            this.pnl_personel.Controls.Add(this.tbox_telefon);
            this.pnl_personel.Controls.Add(this.lbl_kadro_tip);
            this.pnl_personel.Controls.Add(this.tbox_eposta);
            this.pnl_personel.Controls.Add(this.tbox_sifre);
            this.pnl_personel.Controls.Add(this.tbox_kimlik_no);
            this.pnl_personel.Controls.Add(this.lbl_sifre);
            this.pnl_personel.Controls.Add(this.lbl_eposta);
            this.pnl_personel.Controls.Add(this.lbl_kimlik_no);
            this.pnl_personel.Controls.Add(this.tbox_soyad);
            this.pnl_personel.Controls.Add(this.tbox_ad);
            this.pnl_personel.Controls.Add(this.tbox_sicil_no);
            this.pnl_personel.Controls.Add(this.lbl_ad);
            this.pnl_personel.Controls.Add(this.lbl_soyad);
            this.pnl_personel.Controls.Add(this.lbl_sicil_no);
            this.pnl_personel.Location = new System.Drawing.Point(12, 52);
            this.pnl_personel.Name = "pnl_personel";
            this.pnl_personel.Size = new System.Drawing.Size(1168, 257);
            this.pnl_personel.TabIndex = 26;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_adres.Location = new System.Drawing.Point(18, 162);
            this.lbl_adres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(65, 17);
            this.lbl_adres.TabIndex = 55;
            this.lbl_adres.Text = "Adres : ";
            // 
            // tbox_adres
            // 
            this.tbox_adres.Location = new System.Drawing.Point(121, 159);
            this.tbox_adres.Multiline = true;
            this.tbox_adres.Name = "tbox_adres";
            this.tbox_adres.Size = new System.Drawing.Size(544, 83);
            this.tbox_adres.TabIndex = 54;
            // 
            // cb_rol
            // 
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(985, 122);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(171, 21);
            this.cb_rol.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(874, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Rolü : ";
            // 
            // cb_izin2
            // 
            this.cb_izin2.FormattingEnabled = true;
            this.cb_izin2.Location = new System.Drawing.Point(985, 87);
            this.cb_izin2.Name = "cb_izin2";
            this.cb_izin2.Size = new System.Drawing.Size(171, 21);
            this.cb_izin2.TabIndex = 50;
            // 
            // cb_izin1
            // 
            this.cb_izin1.FormattingEnabled = true;
            this.cb_izin1.Location = new System.Drawing.Point(985, 56);
            this.cb_izin1.Name = "cb_izin1";
            this.cb_izin1.Size = new System.Drawing.Size(171, 21);
            this.cb_izin1.TabIndex = 49;
            // 
            // cb_kadro
            // 
            this.cb_kadro.FormattingEnabled = true;
            this.cb_kadro.Location = new System.Drawing.Point(121, 122);
            this.cb_kadro.Name = "cb_kadro";
            this.cb_kadro.Size = new System.Drawing.Size(159, 21);
            this.cb_kadro.TabIndex = 48;
            this.cb_kadro.SelectedIndexChanged += new System.EventHandler(this.cb_kadro_SelectedIndexChanged);
            // 
            // tbox_unvan
            // 
            this.tbox_unvan.Location = new System.Drawing.Point(985, 20);
            this.tbox_unvan.Name = "tbox_unvan";
            this.tbox_unvan.Size = new System.Drawing.Size(171, 20);
            this.tbox_unvan.TabIndex = 45;
            // 
            // lbl_izin_1
            // 
            this.lbl_izin_1.AutoSize = true;
            this.lbl_izin_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_izin_1.Location = new System.Drawing.Point(874, 53);
            this.lbl_izin_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_izin_1.Name = "lbl_izin_1";
            this.lbl_izin_1.Size = new System.Drawing.Size(106, 17);
            this.lbl_izin_1.TabIndex = 44;
            this.lbl_izin_1.Text = "1. İzin Günü :";
            // 
            // lbl_izin_2
            // 
            this.lbl_izin_2.AutoSize = true;
            this.lbl_izin_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_izin_2.Location = new System.Drawing.Point(874, 87);
            this.lbl_izin_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_izin_2.Name = "lbl_izin_2";
            this.lbl_izin_2.Size = new System.Drawing.Size(106, 17);
            this.lbl_izin_2.TabIndex = 43;
            this.lbl_izin_2.Text = "2. İzin Günü :";
            // 
            // lbl_unvan
            // 
            this.lbl_unvan.AutoSize = true;
            this.lbl_unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_unvan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_unvan.Location = new System.Drawing.Point(874, 23);
            this.lbl_unvan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_unvan.Name = "lbl_unvan";
            this.lbl_unvan.Size = new System.Drawing.Size(73, 17);
            this.lbl_unvan.TabIndex = 42;
            this.lbl_unvan.Text = "Ünvanı : ";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_telefon.Location = new System.Drawing.Point(416, 122);
            this.lbl_telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(78, 17);
            this.lbl_telefon.TabIndex = 41;
            this.lbl_telefon.Text = "Telefon : ";
            // 
            // tbox_telefon
            // 
            this.tbox_telefon.Location = new System.Drawing.Point(511, 119);
            this.tbox_telefon.Name = "tbox_telefon";
            this.tbox_telefon.Size = new System.Drawing.Size(154, 20);
            this.tbox_telefon.TabIndex = 40;
            // 
            // lbl_kadro_tip
            // 
            this.lbl_kadro_tip.AutoSize = true;
            this.lbl_kadro_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kadro_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_kadro_tip.Location = new System.Drawing.Point(18, 122);
            this.lbl_kadro_tip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kadro_tip.Name = "lbl_kadro_tip";
            this.lbl_kadro_tip.Size = new System.Drawing.Size(98, 17);
            this.lbl_kadro_tip.TabIndex = 38;
            this.lbl_kadro_tip.Text = "Kadro Tipi : ";
            // 
            // tbox_eposta
            // 
            this.tbox_eposta.Location = new System.Drawing.Point(511, 87);
            this.tbox_eposta.Name = "tbox_eposta";
            this.tbox_eposta.Size = new System.Drawing.Size(154, 20);
            this.tbox_eposta.TabIndex = 31;
            // 
            // tbox_sifre
            // 
            this.tbox_sifre.Location = new System.Drawing.Point(511, 53);
            this.tbox_sifre.Name = "tbox_sifre";
            this.tbox_sifre.Size = new System.Drawing.Size(154, 20);
            this.tbox_sifre.TabIndex = 30;
            // 
            // tbox_kimlik_no
            // 
            this.tbox_kimlik_no.Location = new System.Drawing.Point(511, 23);
            this.tbox_kimlik_no.Name = "tbox_kimlik_no";
            this.tbox_kimlik_no.Size = new System.Drawing.Size(154, 20);
            this.tbox_kimlik_no.TabIndex = 29;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_sifre.Location = new System.Drawing.Point(416, 56);
            this.lbl_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(52, 17);
            this.lbl_sifre.TabIndex = 28;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_eposta.Location = new System.Drawing.Point(416, 90);
            this.lbl_eposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(80, 17);
            this.lbl_eposta.TabIndex = 27;
            this.lbl_eposta.Text = "E-Posta : ";
            // 
            // lbl_kimlik_no
            // 
            this.lbl_kimlik_no.AutoSize = true;
            this.lbl_kimlik_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kimlik_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_kimlik_no.Location = new System.Drawing.Point(416, 26);
            this.lbl_kimlik_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kimlik_no.Name = "lbl_kimlik_no";
            this.lbl_kimlik_no.Size = new System.Drawing.Size(90, 17);
            this.lbl_kimlik_no.TabIndex = 26;
            this.lbl_kimlik_no.Text = "Kimlik No : ";
            // 
            // tbox_soyad
            // 
            this.tbox_soyad.Location = new System.Drawing.Point(121, 87);
            this.tbox_soyad.Name = "tbox_soyad";
            this.tbox_soyad.Size = new System.Drawing.Size(159, 20);
            this.tbox_soyad.TabIndex = 25;
            // 
            // tbox_ad
            // 
            this.tbox_ad.Location = new System.Drawing.Point(121, 53);
            this.tbox_ad.Name = "tbox_ad";
            this.tbox_ad.Size = new System.Drawing.Size(159, 20);
            this.tbox_ad.TabIndex = 24;
            // 
            // tbox_sicil_no
            // 
            this.tbox_sicil_no.Location = new System.Drawing.Point(121, 23);
            this.tbox_sicil_no.Name = "tbox_sicil_no";
            this.tbox_sicil_no.Size = new System.Drawing.Size(159, 20);
            this.tbox_sicil_no.TabIndex = 23;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_ad.Location = new System.Drawing.Point(18, 53);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(37, 17);
            this.lbl_ad.TabIndex = 22;
            this.lbl_ad.Text = "Ad :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_soyad.Location = new System.Drawing.Point(18, 87);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(68, 17);
            this.lbl_soyad.TabIndex = 15;
            this.lbl_soyad.Text = "Soyad : ";
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_sicil_no.Location = new System.Drawing.Point(18, 23);
            this.lbl_sicil_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(78, 17);
            this.lbl_sicil_no.TabIndex = 14;
            this.lbl_sicil_no.Text = "Sicil No : ";
            // 
            // btn_cikti_al
            // 
            this.btn_cikti_al.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_cikti_al.FlatAppearance.BorderSize = 0;
            this.btn_cikti_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikti_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikti_al.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_cikti_al.Location = new System.Drawing.Point(932, 326);
            this.btn_cikti_al.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cikti_al.Name = "btn_cikti_al";
            this.btn_cikti_al.Size = new System.Drawing.Size(248, 27);
            this.btn_cikti_al.TabIndex = 30;
            this.btn_cikti_al.Text = "Çıktı Al";
            this.btn_cikti_al.UseVisualStyleBackColor = false;
            this.btn_cikti_al.Click += new System.EventHandler(this.btn_cikti_al_Click);
            // 
            // btn_personel_guncelle
            // 
            this.btn_personel_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_personel_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_personel_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personel_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel_guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_personel_guncelle.Location = new System.Drawing.Point(628, 326);
            this.btn_personel_guncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_personel_guncelle.Name = "btn_personel_guncelle";
            this.btn_personel_guncelle.Size = new System.Drawing.Size(249, 27);
            this.btn_personel_guncelle.TabIndex = 30;
            this.btn_personel_guncelle.Text = "Personel Güncelle";
            this.btn_personel_guncelle.UseVisualStyleBackColor = false;
            this.btn_personel_guncelle.Click += new System.EventHandler(this.btn_personel_guncelle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(9, 9);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(29, 27);
            this.btn_geri.TabIndex = 31;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frm_adm_personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1192, 667);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_personel_guncelle);
            this.Controls.Add(this.btn_personel_sil);
            this.Controls.Add(this.dgw_adm_personel);
            this.Controls.Add(this.btn_personel_kaydet);
            this.Controls.Add(this.pnl_personel);
            this.Controls.Add(this.btn_cikti_al);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_adm_personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adm_personel";
            this.Load += new System.EventHandler(this.frm_adm_personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_personel)).EndInit();
            this.pnl_personel.ResumeLayout(false);
            this.pnl_personel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.Button btn_personel_sil;
        private System.Windows.Forms.DataGridView dgw_adm_personel;
        private System.Windows.Forms.Button btn_personel_kaydet;
        private System.Windows.Forms.Panel pnl_personel;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.Button btn_cikti_al;
        private System.Windows.Forms.TextBox tbox_unvan;
        private System.Windows.Forms.Label lbl_izin_1;
        private System.Windows.Forms.Label lbl_izin_2;
        private System.Windows.Forms.Label lbl_unvan;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox tbox_telefon;
        private System.Windows.Forms.Label lbl_kadro_tip;
        private System.Windows.Forms.TextBox tbox_eposta;
        private System.Windows.Forms.TextBox tbox_sifre;
        private System.Windows.Forms.TextBox tbox_kimlik_no;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_kimlik_no;
        private System.Windows.Forms.TextBox tbox_soyad;
        private System.Windows.Forms.TextBox tbox_ad;
        private System.Windows.Forms.TextBox tbox_sicil_no;
        private System.Windows.Forms.Button btn_personel_guncelle;
        private System.Windows.Forms.ComboBox cb_izin2;
        private System.Windows.Forms.ComboBox cb_izin1;
        private System.Windows.Forms.ComboBox cb_kadro;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.TextBox tbox_adres;
    }
}