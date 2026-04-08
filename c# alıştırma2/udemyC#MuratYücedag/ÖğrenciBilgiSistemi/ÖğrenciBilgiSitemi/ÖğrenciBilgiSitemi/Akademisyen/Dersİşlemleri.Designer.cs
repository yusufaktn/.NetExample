namespace ÖğrenciBilgiSitemi.Akademisyen
{
    partial class Dersİşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dersİşlemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_DersAd = new System.Windows.Forms.TextBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(507, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(211, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(201, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders Adı";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Location = new System.Drawing.Point(302, 403);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(190, 26);
            this.txt_Id.TabIndex = 3;
            // 
            // txt_DersAd
            // 
            this.txt_DersAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DersAd.Location = new System.Drawing.Point(302, 436);
            this.txt_DersAd.Name = "txt_DersAd";
            this.txt_DersAd.Size = new System.Drawing.Size(190, 26);
            this.txt_DersAd.TabIndex = 4;
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Listele.Location = new System.Drawing.Point(21, 321);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(140, 60);
            this.btn_Listele.TabIndex = 5;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_güncelle.Location = new System.Drawing.Point(21, 387);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(140, 60);
            this.btn_güncelle.TabIndex = 6;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click_1);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ekle.Location = new System.Drawing.Point(21, 453);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(140, 60);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_sil.Location = new System.Drawing.Point(21, 519);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(140, 60);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(464, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dersİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(507, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_DersAd);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dersİşlemleri";
            this.Text = "Ders İşlemleri";
            this.Load += new System.EventHandler(this.Dersİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_DersAd;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}