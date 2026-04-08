namespace MobilyaForm
{
    partial class MusteriEkle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbx_Kategori = new System.Windows.Forms.ComboBox();
            this.cmb_ÜrünAd = new System.Windows.Forms.ComboBox();
            this.Eklenen_Ürünler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ürünAdet = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_indirim = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_toplam_tutar = new System.Windows.Forms.Label();
            this.mobilyaDbDataSet3 = new MobilyaForm.MobilyaDbDataSet3();
            this.tblKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KategoriTableAdapter = new MobilyaForm.MobilyaDbDataSet3TableAdapters.Tbl_KategoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kategori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Ad:";
            // 
            // cmbbx_Kategori
            // 
            this.cmbbx_Kategori.FormattingEnabled = true;
            this.cmbbx_Kategori.Location = new System.Drawing.Point(200, 75);
            this.cmbbx_Kategori.Name = "cmbbx_Kategori";
            this.cmbbx_Kategori.Size = new System.Drawing.Size(149, 27);
            this.cmbbx_Kategori.TabIndex = 3;
            this.cmbbx_Kategori.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Kategori_SelectedIndexChanged);
            // 
            // cmb_ÜrünAd
            // 
            this.cmb_ÜrünAd.FormattingEnabled = true;
            this.cmb_ÜrünAd.Location = new System.Drawing.Point(200, 123);
            this.cmb_ÜrünAd.Name = "cmb_ÜrünAd";
            this.cmb_ÜrünAd.Size = new System.Drawing.Size(149, 27);
            this.cmb_ÜrünAd.TabIndex = 4;
            this.cmb_ÜrünAd.SelectedIndexChanged += new System.EventHandler(this.cmb_ÜrünAd_SelectedIndexChanged);
            // 
            // Eklenen_Ürünler
            // 
            this.Eklenen_Ürünler.FormattingEnabled = true;
            this.Eklenen_Ürünler.ItemHeight = 19;
            this.Eklenen_Ürünler.Location = new System.Drawing.Point(648, 68);
            this.Eklenen_Ürünler.Name = "Eklenen_Ürünler";
            this.Eklenen_Ürünler.Size = new System.Drawing.Size(349, 479);
            this.Eklenen_Ürünler.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 127);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 82);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fiyat Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Adet:";
            // 
            // txt_ürünAdet
            // 
            this.txt_ürünAdet.Location = new System.Drawing.Point(200, 171);
            this.txt_ürünAdet.Name = "txt_ürünAdet";
            this.txt_ürünAdet.Size = new System.Drawing.Size(149, 24);
            this.txt_ürünAdet.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(105, 230);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 23);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İndirim Uygula";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(245, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 23);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İndirim Yok";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "İndirim (%):";
            // 
            // txt_indirim
            // 
            this.txt_indirim.Location = new System.Drawing.Point(200, 280);
            this.txt_indirim.Name = "txt_indirim";
            this.txt_indirim.Size = new System.Drawing.Size(149, 24);
            this.txt_indirim.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(451, 82);
            this.button3.TabIndex = 14;
            this.button3.Text = "Siparişi Oluştur";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(867, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Toplam Tutar :";
            // 
            // lbl_toplam_tutar
            // 
            this.lbl_toplam_tutar.AutoSize = true;
            this.lbl_toplam_tutar.Location = new System.Drawing.Point(980, 563);
            this.lbl_toplam_tutar.Name = "lbl_toplam_tutar";
            this.lbl_toplam_tutar.Size = new System.Drawing.Size(17, 19);
            this.lbl_toplam_tutar.TabIndex = 16;
            this.lbl_toplam_tutar.Text = "0";
            // 
            // mobilyaDbDataSet3
            // 
            this.mobilyaDbDataSet3.DataSetName = "MobilyaDbDataSet3";
            this.mobilyaDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKategoriBindingSource
            // 
            this.tblKategoriBindingSource.DataMember = "Tbl_Kategori";
            this.tblKategoriBindingSource.DataSource = this.mobilyaDbDataSet3;
            // 
            // tbl_KategoriTableAdapter
            // 
            this.tbl_KategoriTableAdapter.ClearBeforeFill = true;
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 628);
            this.Controls.Add(this.lbl_toplam_tutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_indirim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_ürünAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Eklenen_Ürünler);
            this.Controls.Add(this.cmb_ÜrünAd);
            this.Controls.Add(this.cmbbx_Kategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusteriEkle";
            this.Text = "Musteri Ve Sipariş Oluştur";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbx_Kategori;
        private System.Windows.Forms.ComboBox cmb_ÜrünAd;
        private System.Windows.Forms.ListBox Eklenen_Ürünler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ürünAdet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_indirim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_toplam_tutar;
        private MobilyaDbDataSet3 mobilyaDbDataSet3;
        private System.Windows.Forms.BindingSource tblKategoriBindingSource;
        private MobilyaDbDataSet3TableAdapters.Tbl_KategoriTableAdapter tbl_KategoriTableAdapter;
    }
}