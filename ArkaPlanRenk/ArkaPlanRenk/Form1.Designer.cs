namespace ArkaPlanRenk
{
    partial class Form1
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.btnSari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.BackColor = System.Drawing.Color.Red;
            this.btnKirmizi.Location = new System.Drawing.Point(60, 38);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(100, 40);
            this.btnKirmizi.TabIndex = 1;
            this.btnKirmizi.Text = "KIRMIZI";
            this.btnKirmizi.UseVisualStyleBackColor = false;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.Blue;
            this.btnMavi.Location = new System.Drawing.Point(240, 38);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(100, 40);
            this.btnMavi.TabIndex = 2;
            this.btnMavi.Text = "MAVİ";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.BackColor = System.Drawing.Color.Lime;
            this.btnYesil.Location = new System.Drawing.Point(60, 97);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(100, 40);
            this.btnYesil.TabIndex = 3;
            this.btnYesil.Text = "YEŞİL";
            this.btnYesil.UseVisualStyleBackColor = false;
            this.btnYesil.Click += new System.EventHandler(this.btnYesil_Click);
            // 
            // btnSari
            // 
            this.btnSari.BackColor = System.Drawing.Color.Yellow;
            this.btnSari.Location = new System.Drawing.Point(240, 97);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(100, 40);
            this.btnSari.TabIndex = 4;
            this.btnSari.Text = "SARI";
            this.btnSari.UseVisualStyleBackColor = false;
            this.btnSari.Click += new System.EventHandler(this.btnSari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnSari);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnKirmizi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKA PLAN DEĞİŞTİRME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Button btnSari;
    }
}

