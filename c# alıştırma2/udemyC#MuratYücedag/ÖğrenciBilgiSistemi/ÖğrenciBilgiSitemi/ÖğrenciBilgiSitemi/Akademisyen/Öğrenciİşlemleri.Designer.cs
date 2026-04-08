namespace ÖğrenciBilgiSitemi.Akademisyen
{
    partial class Öğrenciİşlemleri
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
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.txt_öğrencAd = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_öğrenciSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_btn_erkek = new System.Windows.Forms.RadioButton();
            this.rd_btn_kadın = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_sil.Location = new System.Drawing.Point(12, 492);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(140, 60);
            this.btn_sil.TabIndex = 20;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ekle.Location = new System.Drawing.Point(12, 426);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(140, 60);
            this.btn_ekle.TabIndex = 19;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_güncelle.Location = new System.Drawing.Point(12, 360);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(140, 60);
            this.btn_güncelle.TabIndex = 18;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Listele.Location = new System.Drawing.Point(12, 294);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(140, 60);
            this.btn_Listele.TabIndex = 17;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // txt_öğrencAd
            // 
            this.txt_öğrencAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_öğrencAd.Location = new System.Drawing.Point(330, 407);
            this.txt_öğrencAd.Name = "txt_öğrencAd";
            this.txt_öğrencAd.Size = new System.Drawing.Size(190, 26);
            this.txt_öğrencAd.TabIndex = 16;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Location = new System.Drawing.Point(330, 374);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(190, 26);
            this.txt_Id.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(203, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Öğrenci Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(211, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Öğrenci ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(591, 259);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_öğrenciSoyad
            // 
            this.txt_öğrenciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_öğrenciSoyad.Location = new System.Drawing.Point(330, 442);
            this.txt_öğrenciSoyad.Name = "txt_öğrenciSoyad";
            this.txt_öğrenciSoyad.Size = new System.Drawing.Size(190, 26);
            this.txt_öğrenciSoyad.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(182, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Öğrenci Soyad";
            // 
            // rd_btn_erkek
            // 
            this.rd_btn_erkek.AutoSize = true;
            this.rd_btn_erkek.Location = new System.Drawing.Point(342, 483);
            this.rd_btn_erkek.Name = "rd_btn_erkek";
            this.rd_btn_erkek.Size = new System.Drawing.Size(53, 17);
            this.rd_btn_erkek.TabIndex = 23;
            this.rd_btn_erkek.TabStop = true;
            this.rd_btn_erkek.Text = "Erkek";
            this.rd_btn_erkek.UseVisualStyleBackColor = true;
            // 
            // rd_btn_kadın
            // 
            this.rd_btn_kadın.AutoSize = true;
            this.rd_btn_kadın.Location = new System.Drawing.Point(435, 483);
            this.rd_btn_kadın.Name = "rd_btn_kadın";
            this.rd_btn_kadın.Size = new System.Drawing.Size(52, 17);
            this.rd_btn_kadın.TabIndex = 24;
            this.rd_btn_kadın.TabStop = true;
            this.rd_btn_kadın.Text = "Kadın";
            this.rd_btn_kadın.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(231, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cinsiyet";
            // 
            // Öğrenciİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(590, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rd_btn_kadın);
            this.Controls.Add(this.rd_btn_erkek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_öğrenciSoyad);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_öğrencAd);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Öğrenciİşlemleri";
            this.Text = "Öğrenciİşlemleri";
            this.Load += new System.EventHandler(this.Öğrenciİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.TextBox txt_öğrencAd;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_öğrenciSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_btn_erkek;
        private System.Windows.Forms.RadioButton rd_btn_kadın;
        private System.Windows.Forms.Label label4;
    }
}