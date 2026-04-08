namespace Entity_Siparis
{
    partial class FrmKategori
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
            this.bn_list = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kategoriID = new System.Windows.Forms.TextBox();
            this.txt_kategoriAD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_list
            // 
            this.bn_list.Location = new System.Drawing.Point(32, 205);
            this.bn_list.Name = "bn_list";
            this.bn_list.Size = new System.Drawing.Size(145, 61);
            this.bn_list.TabIndex = 0;
            this.bn_list.Text = "Listele";
            this.bn_list.UseVisualStyleBackColor = true;
            this.bn_list.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(32, 292);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(145, 61);
            this.btn_güncelle.TabIndex = 1;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(201, 205);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(145, 61);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(201, 292);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(145, 61);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategri Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori Ad:";
            // 
            // txt_kategoriID
            // 
            this.txt_kategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kategoriID.Location = new System.Drawing.Point(201, 60);
            this.txt_kategoriID.Name = "txt_kategoriID";
            this.txt_kategoriID.Size = new System.Drawing.Size(145, 31);
            this.txt_kategoriID.TabIndex = 6;
            // 
            // txt_kategoriAD
            // 
            this.txt_kategoriAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kategoriAD.Location = new System.Drawing.Point(201, 104);
            this.txt_kategoriAD.Name = "txt_kategoriAD";
            this.txt_kategoriAD.Size = new System.Drawing.Size(145, 31);
            this.txt_kategoriAD.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(393, 341);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_kategoriAD);
            this.Controls.Add(this.txt_kategoriID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.bn_list);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_list;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kategoriID;
        private System.Windows.Forms.TextBox txt_kategoriAD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

