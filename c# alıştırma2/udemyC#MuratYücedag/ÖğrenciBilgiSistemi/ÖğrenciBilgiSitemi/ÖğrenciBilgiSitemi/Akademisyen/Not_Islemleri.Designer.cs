namespace ÖğrenciBilgiSitemi.Akademisyen
{
    partial class Not_Islemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ögrenciID = new System.Windows.Forms.TextBox();
            this.txt_vizenot = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ortalama = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.btn_ogrencibul = new System.Windows.Forms.Button();
            this.btn_notekle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_hesapla);
            this.groupBox1.Controls.Add(this.btn_güncelle);
            this.groupBox1.Controls.Add(this.btn_notekle);
            this.groupBox1.Controls.Add(this.btn_ogrencibul);
            this.groupBox1.Controls.Add(this.lbl_durum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_ortalama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_final);
            this.groupBox1.Controls.Add(this.txt_vizenot);
            this.groupBox1.Controls.Add(this.txt_ögrenciID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bul";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(805, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dersler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vize Not";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final";
            // 
            // txt_ögrenciID
            // 
            this.txt_ögrenciID.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ögrenciID.Location = new System.Drawing.Point(174, 64);
            this.txt_ögrenciID.Name = "txt_ögrenciID";
            this.txt_ögrenciID.Size = new System.Drawing.Size(146, 27);
            this.txt_ögrenciID.TabIndex = 4;
            // 
            // txt_vizenot
            // 
            this.txt_vizenot.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vizenot.Location = new System.Drawing.Point(174, 167);
            this.txt_vizenot.Name = "txt_vizenot";
            this.txt_vizenot.Size = new System.Drawing.Size(146, 27);
            this.txt_vizenot.TabIndex = 6;
            // 
            // txt_final
            // 
            this.txt_final.Font = new System.Drawing.Font("Sitka Small", 10.86792F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_final.Location = new System.Drawing.Point(174, 219);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(146, 27);
            this.txt_final.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ortalama :";
            // 
            // lbl_ortalama
            // 
            this.lbl_ortalama.AutoSize = true;
            this.lbl_ortalama.Location = new System.Drawing.Point(686, 63);
            this.lbl_ortalama.Name = "lbl_ortalama";
            this.lbl_ortalama.Size = new System.Drawing.Size(20, 23);
            this.lbl_ortalama.TabIndex = 9;
            this.lbl_ortalama.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum :";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Location = new System.Drawing.Point(686, 18);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(0, 23);
            this.lbl_durum.TabIndex = 11;
            // 
            // btn_ogrencibul
            // 
            this.btn_ogrencibul.Location = new System.Drawing.Point(389, 55);
            this.btn_ogrencibul.Name = "btn_ogrencibul";
            this.btn_ogrencibul.Size = new System.Drawing.Size(129, 31);
            this.btn_ogrencibul.TabIndex = 12;
            this.btn_ogrencibul.Text = "Öğrenci Bul";
            this.btn_ogrencibul.UseVisualStyleBackColor = true;
            this.btn_ogrencibul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_notekle
            // 
            this.btn_notekle.Location = new System.Drawing.Point(389, 113);
            this.btn_notekle.Name = "btn_notekle";
            this.btn_notekle.Size = new System.Drawing.Size(129, 31);
            this.btn_notekle.TabIndex = 13;
            this.btn_notekle.Text = "Notları Ekle";
            this.btn_notekle.UseVisualStyleBackColor = true;
            this.btn_notekle.Click += new System.EventHandler(this.btn_notekle_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(389, 162);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(129, 31);
            this.btn_güncelle.TabIndex = 14;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(389, 215);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(129, 31);
            this.btn_hesapla.TabIndex = 15;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 31);
            this.comboBox1.TabIndex = 16;
            // 
            // Not_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sitka Small", 10.18868F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Not_Islemleri";
            this.Text = "Not_Islemleri";
            this.Load += new System.EventHandler(this.Not_Islemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ortalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.TextBox txt_vizenot;
        private System.Windows.Forms.TextBox txt_ögrenciID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_notekle;
        private System.Windows.Forms.Button btn_ogrencibul;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}