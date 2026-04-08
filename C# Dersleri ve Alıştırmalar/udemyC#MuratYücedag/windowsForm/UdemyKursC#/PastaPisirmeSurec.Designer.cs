namespace UdemyKursC_
{
    partial class PastaPisirmeSurec
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 29);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(806, 32);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 17);
            label1.TabIndex = 1;
            label1.Text = "Un Ve Yumurta Karıştırılıyor...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 2;
            label2.Text = "Çırpma İşlemi Yapılıyor...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(268, 17);
            label3.TabIndex = 3;
            label3.Text = "Diğer Malzemeler Ekleniyor Ve Karıştırılıyor...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 263);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 4;
            label4.Text = "Pasta Pişiriliyor...";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(-1, 113);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(806, 32);
            progressBar2.TabIndex = 5;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(-1, 208);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(806, 32);
            progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(-1, 292);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(806, 32);
            progressBar4.TabIndex = 7;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // PastaPisirmeSurec
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "PastaPisirmeSurec";
            Text = "PastaPişirmeSüreç";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}