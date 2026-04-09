namespace KutuphaneOtomasyon
{
    partial class KullanicilarForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ad_txt = new TextBox();
            soyad_txt = new TextBox();
            mail_txt = new TextBox();
            kullanicilar_data = new DataGridView();
            bul_btn = new Button();
            ekle_btn = new Button();
            sil_btn = new Button();
            güncelle_btn = new Button();
            kitapver_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)kullanicilar_data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 65);
            label1.Name = "label1";
            label1.Size = new Size(27, 17);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 151);
            label3.Name = "label3";
            label3.Size = new Size(36, 17);
            label3.TabIndex = 2;
            label3.Text = "Mail:";
            // 
            // ad_txt
            // 
            ad_txt.Location = new Point(140, 62);
            ad_txt.Name = "ad_txt";
            ad_txt.Size = new Size(151, 25);
            ad_txt.TabIndex = 3;
            // 
            // soyad_txt
            // 
            soyad_txt.Location = new Point(140, 103);
            soyad_txt.Name = "soyad_txt";
            soyad_txt.Size = new Size(151, 25);
            soyad_txt.TabIndex = 4;
            // 
            // mail_txt
            // 
            mail_txt.Location = new Point(140, 148);
            mail_txt.Name = "mail_txt";
            mail_txt.Size = new Size(151, 25);
            mail_txt.TabIndex = 5;
            // 
            // kullanicilar_data
            // 
            kullanicilar_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kullanicilar_data.Location = new Point(-1, 213);
            kullanicilar_data.Name = "kullanicilar_data";
            kullanicilar_data.RowHeadersWidth = 45;
            kullanicilar_data.Size = new Size(1140, 211);
            kullanicilar_data.TabIndex = 6;
            // 
            // bul_btn
            // 
            bul_btn.Location = new Point(548, 52);
            bul_btn.Name = "bul_btn";
            bul_btn.Size = new Size(137, 42);
            bul_btn.TabIndex = 7;
            bul_btn.Text = "Bul";
            bul_btn.UseVisualStyleBackColor = true;
            // 
            // ekle_btn
            // 
            ekle_btn.Location = new Point(548, 117);
            ekle_btn.Name = "ekle_btn";
            ekle_btn.Size = new Size(137, 42);
            ekle_btn.TabIndex = 8;
            ekle_btn.Text = "Ekle";
            ekle_btn.UseVisualStyleBackColor = true;
            // 
            // sil_btn
            // 
            sil_btn.Location = new Point(748, 52);
            sil_btn.Name = "sil_btn";
            sil_btn.Size = new Size(137, 42);
            sil_btn.TabIndex = 9;
            sil_btn.Text = "Sil";
            sil_btn.UseVisualStyleBackColor = true;
            // 
            // güncelle_btn
            // 
            güncelle_btn.Location = new Point(748, 117);
            güncelle_btn.Name = "güncelle_btn";
            güncelle_btn.Size = new Size(137, 42);
            güncelle_btn.TabIndex = 10;
            güncelle_btn.Text = "Güncelle";
            güncelle_btn.UseVisualStyleBackColor = true;
            // 
            // kitapver_btn
            // 
            kitapver_btn.Location = new Point(946, 52);
            kitapver_btn.Name = "kitapver_btn";
            kitapver_btn.Size = new Size(137, 107);
            kitapver_btn.TabIndex = 11;
            kitapver_btn.Text = "Kitap Ver";
            kitapver_btn.UseVisualStyleBackColor = true;
            // 
            // Kullanicilar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 423);
            Controls.Add(kitapver_btn);
            Controls.Add(güncelle_btn);
            Controls.Add(sil_btn);
            Controls.Add(ekle_btn);
            Controls.Add(bul_btn);
            Controls.Add(kullanicilar_data);
            Controls.Add(mail_txt);
            Controls.Add(soyad_txt);
            Controls.Add(ad_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Kullanicilar";
            Text = "Kullanicilar";
            Load += Kullanicilar_Load;
            ((System.ComponentModel.ISupportInitialize)kullanicilar_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ad_txt;
        private TextBox soyad_txt;
        private TextBox mail_txt;
        private DataGridView kullanicilar_data;
        private Button bul_btn;
        private Button ekle_btn;
        private Button sil_btn;
        private Button güncelle_btn;
        private Button kitapver_btn;
    }
}