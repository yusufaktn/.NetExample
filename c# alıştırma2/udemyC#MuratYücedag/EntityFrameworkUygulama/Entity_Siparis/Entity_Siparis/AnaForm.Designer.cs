namespace Entity_Siparis
{
    partial class AnaForm
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
            this.btn_kategoriislem = new System.Windows.Forms.Button();
            this.btn_ürünislem = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_ist = new System.Windows.Forms.Button();
            this.btn_rapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kategoriislem
            // 
            this.btn_kategoriislem.Location = new System.Drawing.Point(719, 168);
            this.btn_kategoriislem.Name = "btn_kategoriislem";
            this.btn_kategoriislem.Size = new System.Drawing.Size(216, 163);
            this.btn_kategoriislem.TabIndex = 0;
            this.btn_kategoriislem.Text = "KATEGORİ İŞLEMLERİ";
            this.btn_kategoriislem.UseVisualStyleBackColor = true;
            // 
            // btn_ürünislem
            // 
            this.btn_ürünislem.Location = new System.Drawing.Point(400, 168);
            this.btn_ürünislem.Name = "btn_ürünislem";
            this.btn_ürünislem.Size = new System.Drawing.Size(216, 163);
            this.btn_ürünislem.TabIndex = 1;
            this.btn_ürünislem.Text = "ÜRÜN İŞLEMLERİ";
            this.btn_ürünislem.UseVisualStyleBackColor = true;
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.Location = new System.Drawing.Point(90, 168);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(216, 163);
            this.btn_istatistik.TabIndex = 2;
            this.btn_istatistik.Text = "İSTATİSTİKLER";
            this.btn_istatistik.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_kategori
            // 
            this.btn_kategori.Location = new System.Drawing.Point(33, 108);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(239, 156);
            this.btn_kategori.TabIndex = 0;
            this.btn_kategori.Text = "Kategori";
            this.btn_kategori.UseVisualStyleBackColor = true;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btn_urun
            // 
            this.btn_urun.Location = new System.Drawing.Point(311, 108);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(239, 156);
            this.btn_urun.TabIndex = 1;
            this.btn_urun.Text = "Ürünler";
            this.btn_urun.UseVisualStyleBackColor = true;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_ist
            // 
            this.btn_ist.Location = new System.Drawing.Point(576, 108);
            this.btn_ist.Name = "btn_ist";
            this.btn_ist.Size = new System.Drawing.Size(239, 156);
            this.btn_ist.TabIndex = 2;
            this.btn_ist.Text = "İstatistik";
            this.btn_ist.UseVisualStyleBackColor = true;
            this.btn_ist.Click += new System.EventHandler(this.btn_ist_Click);
            // 
            // btn_rapor
            // 
            this.btn_rapor.Location = new System.Drawing.Point(844, 108);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(239, 156);
            this.btn_rapor.TabIndex = 3;
            this.btn_rapor.Text = "Rapor";
            this.btn_rapor.UseVisualStyleBackColor = true;
//            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 419);
            this.ControlBox = false;
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.btn_ist);
            this.Controls.Add(this.btn_urun);
            this.Controls.Add(this.btn_kategori);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
//            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kategoriislem;
        private System.Windows.Forms.Button btn_ürünislem;
        private System.Windows.Forms.Button btn_istatistik;
       
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_ist;
        private System.Windows.Forms.Button btn_rapor;
    }
}