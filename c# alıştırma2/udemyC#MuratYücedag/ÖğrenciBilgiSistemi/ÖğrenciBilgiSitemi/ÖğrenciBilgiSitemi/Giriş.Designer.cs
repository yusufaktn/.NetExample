namespace ÖğrenciBilgiSitemi
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.picture_ogr = new System.Windows.Forms.PictureBox();
            this.picture_akademisyen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ogr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_akademisyen)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_ogr
            // 
            this.picture_ogr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_ogr.Image = ((System.Drawing.Image)(resources.GetObject("picture_ogr.Image")));
            this.picture_ogr.Location = new System.Drawing.Point(95, 113);
            this.picture_ogr.Name = "picture_ogr";
            this.picture_ogr.Size = new System.Drawing.Size(204, 151);
            this.picture_ogr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ogr.TabIndex = 0;
            this.picture_ogr.TabStop = false;
            this.picture_ogr.Click += new System.EventHandler(this.picture_ogr_Click);
            // 
            // picture_akademisyen
            // 
            this.picture_akademisyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_akademisyen.Image = ((System.Drawing.Image)(resources.GetObject("picture_akademisyen.Image")));
            this.picture_akademisyen.Location = new System.Drawing.Point(404, 113);
            this.picture_akademisyen.Name = "picture_akademisyen";
            this.picture_akademisyen.Size = new System.Drawing.Size(204, 151);
            this.picture_akademisyen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_akademisyen.TabIndex = 1;
            this.picture_akademisyen.TabStop = false;
            this.picture_akademisyen.Click += new System.EventHandler(this.picture_akademisyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Akademisyen Girişi";
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(702, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_akademisyen);
            this.Controls.Add(this.picture_ogr);
            this.Font = new System.Drawing.Font("Sitka Small", 6.792453F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Giriş";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_ogr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_akademisyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_ogr;
        private System.Windows.Forms.PictureBox picture_akademisyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

