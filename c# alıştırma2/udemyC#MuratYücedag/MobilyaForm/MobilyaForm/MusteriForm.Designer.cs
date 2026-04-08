namespace MobilyaForm
{
    partial class MusteriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_musteriAD = new System.Windows.Forms.TextBox();
            this.txt_musteriSOYAD = new System.Windows.Forms.TextBox();
            this.txt_musteriTC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_devamet = new System.Windows.Forms.Button();
            this.ekle_txtAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle_txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ekle_txtSoyad = new System.Windows.Forms.TextBox();
            this.ekle_txtTc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tc:";
            // 
            // txt_musteriAD
            // 
            this.txt_musteriAD.Location = new System.Drawing.Point(190, 130);
            this.txt_musteriAD.Name = "txt_musteriAD";
            this.txt_musteriAD.Size = new System.Drawing.Size(159, 24);
            this.txt_musteriAD.TabIndex = 3;
            // 
            // txt_musteriSOYAD
            // 
            this.txt_musteriSOYAD.Location = new System.Drawing.Point(190, 166);
            this.txt_musteriSOYAD.Name = "txt_musteriSOYAD";
            this.txt_musteriSOYAD.Size = new System.Drawing.Size(159, 24);
            this.txt_musteriSOYAD.TabIndex = 4;
            // 
            // txt_musteriTC
            // 
            this.txt_musteriTC.Location = new System.Drawing.Point(190, 200);
            this.txt_musteriTC.Name = "txt_musteriTC";
            this.txt_musteriTC.Size = new System.Drawing.Size(159, 24);
            this.txt_musteriTC.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_musteriAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_musteriSOYAD);
            this.groupBox1.Controls.Add(this.txt_musteriTC);
            this.groupBox1.Location = new System.Drawing.Point(46, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 505);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ara";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(81, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_devamet);
            this.groupBox2.Controls.Add(this.ekle_txtAdres);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ekle_txtAd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ekle_txtSoyad);
            this.groupBox2.Controls.Add(this.ekle_txtTc);
            this.groupBox2.Location = new System.Drawing.Point(474, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 505);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Ekle";
            // 
            // btn_devamet
            // 
            this.btn_devamet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_devamet.Location = new System.Drawing.Point(128, 357);
            this.btn_devamet.Name = "btn_devamet";
            this.btn_devamet.Size = new System.Drawing.Size(159, 54);
            this.btn_devamet.TabIndex = 7;
            this.btn_devamet.Text = "Devam et";
            this.btn_devamet.UseVisualStyleBackColor = false;
            this.btn_devamet.Click += new System.EventHandler(this.button2_Click);
            // 
            // ekle_txtAdres
            // 
            this.ekle_txtAdres.Location = new System.Drawing.Point(190, 236);
            this.ekle_txtAdres.Name = "ekle_txtAdres";
            this.ekle_txtAdres.Size = new System.Drawing.Size(159, 24);
            this.ekle_txtAdres.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tc:";
            // 
            // ekle_txtAd
            // 
            this.ekle_txtAd.Location = new System.Drawing.Point(190, 130);
            this.ekle_txtAd.Name = "ekle_txtAd";
            this.ekle_txtAd.Size = new System.Drawing.Size(159, 24);
            this.ekle_txtAd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Müşteri Soyad:";
            // 
            // ekle_txtSoyad
            // 
            this.ekle_txtSoyad.Location = new System.Drawing.Point(190, 166);
            this.ekle_txtSoyad.Name = "ekle_txtSoyad";
            this.ekle_txtSoyad.Size = new System.Drawing.Size(159, 24);
            this.ekle_txtSoyad.TabIndex = 4;
            // 
            // ekle_txtTc
            // 
            this.ekle_txtTc.Location = new System.Drawing.Point(190, 200);
            this.ekle_txtTc.Name = "ekle_txtTc";
            this.ekle_txtTc.Size = new System.Drawing.Size(159, 24);
            this.ekle_txtTc.TabIndex = 5;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_musteriAD;
        private System.Windows.Forms.TextBox txt_musteriSOYAD;
        private System.Windows.Forms.TextBox txt_musteriTC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ekle_txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ekle_txtSoyad;
        private System.Windows.Forms.TextBox ekle_txtTc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_devamet;
        private System.Windows.Forms.TextBox ekle_txtAdres;
    }
}