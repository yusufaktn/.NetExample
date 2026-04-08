namespace PersonelKayitt
{
    partial class AnaFrom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_bekar = new System.Windows.Forms.RadioButton();
            this.rd_evli = new System.Windows.Forms.RadioButton();
            this.PerSehir = new System.Windows.Forms.ComboBox();
            this.PerMaas = new System.Windows.Forms.MaskedTextBox();
            this.PerMeslek = new System.Windows.Forms.TextBox();
            this.PerSoyad = new System.Windows.Forms.TextBox();
            this.PerAd = new System.Windows.Forms.TextBox();
            this.PerDurumLabel = new System.Windows.Forms.Label();
            this.PerSehirLabel = new System.Windows.Forms.Label();
            this.PerMaasLabel = new System.Windows.Forms.Label();
            this.PerMeslekLabel = new System.Windows.Forms.Label();
            this.PerSoyadLabel = new System.Windows.Forms.Label();
            this.PerAdLabel = new System.Windows.Forms.Label();
            this.PerIdLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new PersonelKayitt.PersonelDataSet();
            this.tbl_PersonelTableAdapter = new PersonelKayitt.PersonelDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.rd_bekar);
            this.groupBox1.Controls.Add(this.rd_evli);
            this.groupBox1.Controls.Add(this.PerSehir);
            this.groupBox1.Controls.Add(this.PerMaas);
            this.groupBox1.Controls.Add(this.PerMeslek);
            this.groupBox1.Controls.Add(this.PerSoyad);
            this.groupBox1.Controls.Add(this.PerAd);
            this.groupBox1.Controls.Add(this.PerDurumLabel);
            this.groupBox1.Controls.Add(this.PerSehirLabel);
            this.groupBox1.Controls.Add(this.PerMaasLabel);
            this.groupBox1.Controls.Add(this.PerMeslekLabel);
            this.groupBox1.Controls.Add(this.PerSoyadLabel);
            this.groupBox1.Controls.Add(this.PerAdLabel);
            this.groupBox1.Controls.Add(this.PerIdLabel);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Size = new System.Drawing.Size(383, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // rd_bekar
            // 
            this.rd_bekar.AutoSize = true;
            this.rd_bekar.Location = new System.Drawing.Point(241, 377);
            this.rd_bekar.Margin = new System.Windows.Forms.Padding(4);
            this.rd_bekar.Name = "rd_bekar";
            this.rd_bekar.Size = new System.Drawing.Size(88, 27);
            this.rd_bekar.TabIndex = 14;
            this.rd_bekar.TabStop = true;
            this.rd_bekar.Text = "Bekar";
            this.rd_bekar.UseVisualStyleBackColor = true;
            this.rd_bekar.CheckedChanged += new System.EventHandler(this.rd_bekar_CheckedChanged);
            // 
            // rd_evli
            // 
            this.rd_evli.AutoSize = true;
            this.rd_evli.Location = new System.Drawing.Point(144, 375);
            this.rd_evli.Margin = new System.Windows.Forms.Padding(4);
            this.rd_evli.Name = "rd_evli";
            this.rd_evli.Size = new System.Drawing.Size(64, 27);
            this.rd_evli.TabIndex = 13;
            this.rd_evli.TabStop = true;
            this.rd_evli.Text = "Evli";
            this.rd_evli.UseVisualStyleBackColor = true;
            this.rd_evli.CheckedChanged += new System.EventHandler(this.rd_evli_CheckedChanged);
            // 
            // PerSehir
            // 
            this.PerSehir.FormattingEnabled = true;
            this.PerSehir.Location = new System.Drawing.Point(144, 311);
            this.PerSehir.Margin = new System.Windows.Forms.Padding(4);
            this.PerSehir.Name = "PerSehir";
            this.PerSehir.Size = new System.Drawing.Size(185, 31);
            this.PerSehir.TabIndex = 12;
            // 
            // PerMaas
            // 
            this.PerMaas.Location = new System.Drawing.Point(144, 254);
            this.PerMaas.Margin = new System.Windows.Forms.Padding(4);
            this.PerMaas.Mask = "00000";
            this.PerMaas.Name = "PerMaas";
            this.PerMaas.Size = new System.Drawing.Size(185, 27);
            this.PerMaas.TabIndex = 11;
            this.PerMaas.ValidatingType = typeof(int);
            // 
            // PerMeslek
            // 
            this.PerMeslek.Location = new System.Drawing.Point(144, 203);
            this.PerMeslek.Margin = new System.Windows.Forms.Padding(4);
            this.PerMeslek.Name = "PerMeslek";
            this.PerMeslek.Size = new System.Drawing.Size(185, 27);
            this.PerMeslek.TabIndex = 10;
            // 
            // PerSoyad
            // 
            this.PerSoyad.Location = new System.Drawing.Point(144, 151);
            this.PerSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.PerSoyad.Name = "PerSoyad";
            this.PerSoyad.Size = new System.Drawing.Size(185, 27);
            this.PerSoyad.TabIndex = 9;
            // 
            // PerAd
            // 
            this.PerAd.Location = new System.Drawing.Point(144, 97);
            this.PerAd.Margin = new System.Windows.Forms.Padding(4);
            this.PerAd.Name = "PerAd";
            this.PerAd.Size = new System.Drawing.Size(185, 27);
            this.PerAd.TabIndex = 8;
            // 
            // PerDurumLabel
            // 
            this.PerDurumLabel.AutoSize = true;
            this.PerDurumLabel.Location = new System.Drawing.Point(46, 379);
            this.PerDurumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerDurumLabel.Name = "PerDurumLabel";
            this.PerDurumLabel.Size = new System.Drawing.Size(80, 23);
            this.PerDurumLabel.TabIndex = 6;
            this.PerDurumLabel.Text = "Durum";
            // 
            // PerSehirLabel
            // 
            this.PerSehirLabel.AutoSize = true;
            this.PerSehirLabel.Location = new System.Drawing.Point(48, 314);
            this.PerSehirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerSehirLabel.Name = "PerSehirLabel";
            this.PerSehirLabel.Size = new System.Drawing.Size(63, 23);
            this.PerSehirLabel.TabIndex = 5;
            this.PerSehirLabel.Text = "Şehir";
            // 
            // PerMaasLabel
            // 
            this.PerMaasLabel.AutoSize = true;
            this.PerMaasLabel.Location = new System.Drawing.Point(52, 258);
            this.PerMaasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerMaasLabel.Name = "PerMaasLabel";
            this.PerMaasLabel.Size = new System.Drawing.Size(59, 23);
            this.PerMaasLabel.TabIndex = 4;
            this.PerMaasLabel.Text = "Maaş";
            // 
            // PerMeslekLabel
            // 
            this.PerMeslekLabel.AutoSize = true;
            this.PerMeslekLabel.Location = new System.Drawing.Point(46, 206);
            this.PerMeslekLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerMeslekLabel.Name = "PerMeslekLabel";
            this.PerMeslekLabel.Size = new System.Drawing.Size(78, 23);
            this.PerMeslekLabel.TabIndex = 3;
            this.PerMeslekLabel.Text = "Meslek";
            // 
            // PerSoyadLabel
            // 
            this.PerSoyadLabel.AutoSize = true;
            this.PerSoyadLabel.Location = new System.Drawing.Point(46, 155);
            this.PerSoyadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerSoyadLabel.Name = "PerSoyadLabel";
            this.PerSoyadLabel.Size = new System.Drawing.Size(70, 23);
            this.PerSoyadLabel.TabIndex = 2;
            this.PerSoyadLabel.Text = "Soyad";
            // 
            // PerAdLabel
            // 
            this.PerAdLabel.AutoSize = true;
            this.PerAdLabel.Location = new System.Drawing.Point(52, 101);
            this.PerAdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerAdLabel.Name = "PerAdLabel";
            this.PerAdLabel.Size = new System.Drawing.Size(39, 23);
            this.PerAdLabel.TabIndex = 1;
            this.PerAdLabel.Text = "Ad";
            // 
            // PerIdLabel
            // 
            this.PerIdLabel.AutoSize = true;
            this.PerIdLabel.Location = new System.Drawing.Point(49, 91);
            this.PerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PerIdLabel.Name = "PerIdLabel";
            this.PerIdLabel.Size = new System.Drawing.Size(0, 23);
            this.PerIdLabel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.btnRapor);
            this.groupBox2.Controls.Add(this.btnGrafik);
            this.groupBox2.Controls.Add(this.btnİstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(476, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox2.Size = new System.Drawing.Size(374, 490);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(108, 379);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(4);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(175, 41);
            this.btnRapor.TabIndex = 7;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(108, 323);
            this.btnGrafik.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(175, 41);
            this.btnGrafik.TabIndex = 6;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.Location = new System.Drawing.Point(108, 274);
            this.btnİstatistik.Margin = new System.Windows.Forms.Padding(4);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(175, 41);
            this.btnİstatistik.TabIndex = 5;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = true;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(108, 225);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(175, 41);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(108, 176);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(175, 41);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(108, 127);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(175, 41);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(108, 78);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(175, 41);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(108, 29);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(175, 41);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(26, 519);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(828, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(820, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 110;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 110;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 110;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 110;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 110;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 110;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // AnaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 782);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "AnaFrom";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PerMeslek;
        private System.Windows.Forms.TextBox PerSoyad;
        private System.Windows.Forms.TextBox PerAd;
        private System.Windows.Forms.Label PerDurumLabel;
        private System.Windows.Forms.Label PerSehirLabel;
        private System.Windows.Forms.Label PerMaasLabel;
        private System.Windows.Forms.Label PerMeslekLabel;
        private System.Windows.Forms.Label PerSoyadLabel;
        private System.Windows.Forms.Label PerAdLabel;
        private System.Windows.Forms.Label PerIdLabel;
        private System.Windows.Forms.RadioButton rd_bekar;
        private System.Windows.Forms.RadioButton rd_evli;
        private System.Windows.Forms.ComboBox PerSehir;
        private System.Windows.Forms.MaskedTextBox PerMaas;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnRapor;
    }
}

