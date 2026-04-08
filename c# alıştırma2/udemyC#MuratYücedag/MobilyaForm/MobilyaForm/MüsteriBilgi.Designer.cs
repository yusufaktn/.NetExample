namespace MobilyaForm
{
    partial class MüsteriBilgi
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_borc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mobilyaDbDataSet2 = new MobilyaForm.MobilyaDbDataSet2();
            this.tblOdemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OdemeTableAdapter = new MobilyaForm.MobilyaDbDataSet2TableAdapters.Tbl_OdemeTableAdapter();
            this.odemeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdemeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(186, 76);
            this.lbl_tc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(17, 19);
            this.lbl_tc.TabIndex = 3;
            this.lbl_tc.Text = "0";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(186, 127);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(17, 19);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "0";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(186, 176);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(17, 19);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Borç:";
            // 
            // lbl_borc
            // 
            this.lbl_borc.AutoSize = true;
            this.lbl_borc.Location = new System.Drawing.Point(186, 226);
            this.lbl_borc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_borc.Name = "lbl_borc";
            this.lbl_borc.Size = new System.Drawing.Size(17, 19);
            this.lbl_borc.TabIndex = 7;
            this.lbl_borc.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kayıt Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "18/10/2024";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(840, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Taksit Sayısı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(931, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_adres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_ad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_borc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(41, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 401);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(186, 271);
            this.lbl_adres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(17, 19);
            this.lbl_adres.TabIndex = 10;
            this.lbl_adres.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adres:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeTarihiDataGridViewTextBoxColumn,
            this.odenenMiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOdemeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(522, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(378, 401);
            this.dataGridView1.TabIndex = 11;
            // 
            // mobilyaDbDataSet2
            // 
            this.mobilyaDbDataSet2.DataSetName = "MobilyaDbDataSet2";
            this.mobilyaDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOdemeBindingSource
            // 
            this.tblOdemeBindingSource.DataMember = "Tbl_Odeme";
            this.tblOdemeBindingSource.DataSource = this.mobilyaDbDataSet2;
            // 
            // tbl_OdemeTableAdapter
            // 
            this.tbl_OdemeTableAdapter.ClearBeforeFill = true;
            // 
            // odemeTarihiDataGridViewTextBoxColumn
            // 
            this.odemeTarihiDataGridViewTextBoxColumn.DataPropertyName = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.HeaderText = "OdemeTarihi";
            this.odemeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTarihiDataGridViewTextBoxColumn.Name = "odemeTarihiDataGridViewTextBoxColumn";
            // 
            // odenenMiktarDataGridViewTextBoxColumn
            // 
            this.odenenMiktarDataGridViewTextBoxColumn.DataPropertyName = "Odenen_Miktar";
            this.odenenMiktarDataGridViewTextBoxColumn.HeaderText = "Odenen_Miktar";
            this.odenenMiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odenenMiktarDataGridViewTextBoxColumn.Name = "odenenMiktarDataGridViewTextBoxColumn";
            // 
            // MüsteriBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(961, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MüsteriBilgi";
            this.Text = "Müsteri Bilgi";
            this.Load += new System.EventHandler(this.MüsteriBilgi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilyaDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdemeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_borc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MobilyaDbDataSet2 mobilyaDbDataSet2;
        private System.Windows.Forms.BindingSource tblOdemeBindingSource;
        private MobilyaDbDataSet2TableAdapters.Tbl_OdemeTableAdapter tbl_OdemeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenMiktarDataGridViewTextBoxColumn;
    }
}