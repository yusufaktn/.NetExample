namespace ÖğrenciBilgiSitemi
{
    partial class ÖğrenciGiriş
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
            this.txt_ogrencino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ogrenciad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No :";
            // 
            // txt_ogrencino
            // 
            this.txt_ogrencino.Font = new System.Drawing.Font("Sitka Small", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrencino.Location = new System.Drawing.Point(339, 119);
            this.txt_ogrencino.Name = "txt_ogrencino";
            this.txt_ogrencino.Size = new System.Drawing.Size(161, 30);
            this.txt_ogrencino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(189, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Ad  :";
            // 
            // txt_ogrenciad
            // 
            this.txt_ogrenciad.Font = new System.Drawing.Font("Sitka Small", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrenciad.Location = new System.Drawing.Point(339, 162);
            this.txt_ogrenciad.Name = "txt_ogrenciad";
            this.txt_ogrenciad.Size = new System.Drawing.Size(161, 30);
            this.txt_ogrenciad.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(339, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ÖğrenciGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(693, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ogrenciad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ogrencino);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 6.792453F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ÖğrenciGiriş";
            this.Text = "ÖğrenciGiriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogrencino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogrenciad;
        private System.Windows.Forms.Button button1;
    }
}