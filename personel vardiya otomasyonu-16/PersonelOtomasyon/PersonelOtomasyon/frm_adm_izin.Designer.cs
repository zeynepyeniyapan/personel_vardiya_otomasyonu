﻿namespace PersonelOtomasyon
{
    partial class frm_adm_izin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_izinler = new System.Windows.Forms.Label();
            this.btn_izin_sil = new System.Windows.Forms.Button();
            this.dgw_adm_izinler = new System.Windows.Forms.DataGridView();
            this.btn_izin_kaydet = new System.Windows.Forms.Button();
            this.pnl_og = new System.Windows.Forms.Panel();
            this.tbox_izin_sebep = new System.Windows.Forms.TextBox();
            this.lbl_izin_sebep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_izin_tarih_bitis = new System.Windows.Forms.DateTimePicker();
            this.cb_sicil_no = new System.Windows.Forms.ComboBox();
            this.dtp_izin_tarih_baslangic = new System.Windows.Forms.DateTimePicker();
            this.lbl_izin_tarih = new System.Windows.Forms.Label();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_izinler)).BeginInit();
            this.pnl_og.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(700, 11);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 33);
            this.btn_kapat.TabIndex = 19;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_izinler
            // 
            this.lbl_izinler.AutoSize = true;
            this.lbl_izinler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.lbl_izinler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izinler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_izinler.Location = new System.Drawing.Point(363, 1);
            this.lbl_izinler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_izinler.Name = "lbl_izinler";
            this.lbl_izinler.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_izinler.Size = new System.Drawing.Size(108, 43);
            this.lbl_izinler.TabIndex = 18;
            this.lbl_izinler.Text = "İzinler";
            // 
            // btn_izin_sil
            // 
            this.btn_izin_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_izin_sil.FlatAppearance.BorderSize = 0;
            this.btn_izin_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_izin_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_izin_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_izin_sil.Location = new System.Drawing.Point(392, 279);
            this.btn_izin_sil.Margin = new System.Windows.Forms.Padding(0);
            this.btn_izin_sil.Name = "btn_izin_sil";
            this.btn_izin_sil.Size = new System.Drawing.Size(308, 33);
            this.btn_izin_sil.TabIndex = 25;
            this.btn_izin_sil.Text = "İzin Sil";
            this.btn_izin_sil.UseVisualStyleBackColor = false;
            this.btn_izin_sil.Click += new System.EventHandler(this.btn_izin_sil_Click);
            // 
            // dgw_adm_izinler
            // 
            this.dgw_adm_izinler.AllowUserToResizeColumns = false;
            this.dgw_adm_izinler.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_adm_izinler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw_adm_izinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_adm_izinler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_adm_izinler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.dgw_adm_izinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_adm_izinler.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgw_adm_izinler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_adm_izinler.Location = new System.Drawing.Point(53, 335);
            this.dgw_adm_izinler.Margin = new System.Windows.Forms.Padding(4);
            this.dgw_adm_izinler.Name = "dgw_adm_izinler";
            this.dgw_adm_izinler.RowHeadersWidth = 51;
            this.dgw_adm_izinler.Size = new System.Drawing.Size(647, 198);
            this.dgw_adm_izinler.TabIndex = 24;
            this.dgw_adm_izinler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_adm_izinler_CellContentClick);
            // 
            // btn_izin_kaydet
            // 
            this.btn_izin_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.btn_izin_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_izin_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_izin_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_izin_kaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btn_izin_kaydet.Location = new System.Drawing.Point(53, 279);
            this.btn_izin_kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_izin_kaydet.Name = "btn_izin_kaydet";
            this.btn_izin_kaydet.Size = new System.Drawing.Size(325, 33);
            this.btn_izin_kaydet.TabIndex = 23;
            this.btn_izin_kaydet.Text = "İzin Kaydet";
            this.btn_izin_kaydet.UseVisualStyleBackColor = false;
            this.btn_izin_kaydet.Click += new System.EventHandler(this.btn_izin_kaydet_Click);
            // 
            // pnl_og
            // 
            this.pnl_og.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            this.pnl_og.Controls.Add(this.tbox_izin_sebep);
            this.pnl_og.Controls.Add(this.lbl_izin_sebep);
            this.pnl_og.Controls.Add(this.label1);
            this.pnl_og.Controls.Add(this.dtp_izin_tarih_bitis);
            this.pnl_og.Controls.Add(this.cb_sicil_no);
            this.pnl_og.Controls.Add(this.dtp_izin_tarih_baslangic);
            this.pnl_og.Controls.Add(this.lbl_izin_tarih);
            this.pnl_og.Controls.Add(this.lbl_sicil_no);
            this.pnl_og.Location = new System.Drawing.Point(53, 59);
            this.pnl_og.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_og.Name = "pnl_og";
            this.pnl_og.Size = new System.Drawing.Size(647, 199);
            this.pnl_og.TabIndex = 22;
            this.pnl_og.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_og_Paint);
            // 
            // tbox_izin_sebep
            // 
            this.tbox_izin_sebep.Location = new System.Drawing.Point(157, 97);
            this.tbox_izin_sebep.Margin = new System.Windows.Forms.Padding(4);
            this.tbox_izin_sebep.Name = "tbox_izin_sebep";
            this.tbox_izin_sebep.Size = new System.Drawing.Size(265, 22);
            this.tbox_izin_sebep.TabIndex = 23;
            this.tbox_izin_sebep.TextChanged += new System.EventHandler(this.tbox_izin_sebep_TextChanged);
            // 
            // lbl_izin_sebep
            // 
            this.lbl_izin_sebep.AutoSize = true;
            this.lbl_izin_sebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin_sebep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_izin_sebep.Location = new System.Drawing.Point(24, 101);
            this.lbl_izin_sebep.Name = "lbl_izin_sebep";
            this.lbl_izin_sebep.Size = new System.Drawing.Size(114, 20);
            this.lbl_izin_sebep.TabIndex = 22;
            this.lbl_izin_sebep.Text = "İzin Sebebi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(280, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // dtp_izin_tarih_bitis
            // 
            this.dtp_izin_tarih_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_izin_tarih_bitis.Location = new System.Drawing.Point(305, 143);
            this.dtp_izin_tarih_bitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_izin_tarih_bitis.Name = "dtp_izin_tarih_bitis";
            this.dtp_izin_tarih_bitis.Size = new System.Drawing.Size(117, 22);
            this.dtp_izin_tarih_bitis.TabIndex = 20;
            this.dtp_izin_tarih_bitis.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // cb_sicil_no
            // 
            this.cb_sicil_no.FormattingEnabled = true;
            this.cb_sicil_no.Location = new System.Drawing.Point(157, 54);
            this.cb_sicil_no.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sicil_no.Name = "cb_sicil_no";
            this.cb_sicil_no.Size = new System.Drawing.Size(265, 24);
            this.cb_sicil_no.TabIndex = 19;
            this.cb_sicil_no.SelectedIndexChanged += new System.EventHandler(this.cb_sicil_no_SelectedIndexChanged);
            // 
            // dtp_izin_tarih_baslangic
            // 
            this.dtp_izin_tarih_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_izin_tarih_baslangic.Location = new System.Drawing.Point(157, 143);
            this.dtp_izin_tarih_baslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_izin_tarih_baslangic.Name = "dtp_izin_tarih_baslangic";
            this.dtp_izin_tarih_baslangic.Size = new System.Drawing.Size(115, 22);
            this.dtp_izin_tarih_baslangic.TabIndex = 17;
            this.dtp_izin_tarih_baslangic.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // lbl_izin_tarih
            // 
            this.lbl_izin_tarih.AutoSize = true;
            this.lbl_izin_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin_tarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_izin_tarih.Location = new System.Drawing.Point(24, 146);
            this.lbl_izin_tarih.Name = "lbl_izin_tarih";
            this.lbl_izin_tarih.Size = new System.Drawing.Size(111, 20);
            this.lbl_izin_tarih.TabIndex = 15;
            this.lbl_izin_tarih.Text = "İzin Tarihi : ";
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbl_sicil_no.Location = new System.Drawing.Point(24, 54);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(93, 20);
            this.lbl_sicil_no.TabIndex = 14;
            this.lbl_sicil_no.Text = "Sicil No : ";
            this.lbl_sicil_no.Click += new System.EventHandler(this.lbl_sicil_no_Click);
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
            this.btn_geri.TabIndex = 26;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frm_adm_izin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(751, 554);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_izin_sil);
            this.Controls.Add(this.dgw_adm_izinler);
            this.Controls.Add(this.btn_izin_kaydet);
            this.Controls.Add(this.pnl_og);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_izinler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_adm_izin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adm_izin";
            this.Load += new System.EventHandler(this.frm_adm_izin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adm_izinler)).EndInit();
            this.pnl_og.ResumeLayout(false);
            this.pnl_og.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_izinler;
        private System.Windows.Forms.Button btn_izin_sil;
        private System.Windows.Forms.DataGridView dgw_adm_izinler;
        private System.Windows.Forms.Button btn_izin_kaydet;
        private System.Windows.Forms.Panel pnl_og;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_izin_tarih_bitis;
        private System.Windows.Forms.ComboBox cb_sicil_no;
        private System.Windows.Forms.DateTimePicker dtp_izin_tarih_baslangic;
        private System.Windows.Forms.Label lbl_izin_tarih;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.TextBox tbox_izin_sebep;
        private System.Windows.Forms.Label lbl_izin_sebep;
        private System.Windows.Forms.Button btn_geri;
    }
}