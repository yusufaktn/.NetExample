namespace Windows_Form_Uyglama
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
            this.btnMesajGoster = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesajGoster
            // 
            this.btnMesajGoster.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMesajGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajGoster.ForeColor = System.Drawing.Color.Yellow;
            this.btnMesajGoster.Location = new System.Drawing.Point(96, 63);
            this.btnMesajGoster.Name = "btnMesajGoster";
            this.btnMesajGoster.Size = new System.Drawing.Size(152, 54);
            this.btnMesajGoster.TabIndex = 0;
            this.btnMesajGoster.Text = "Mesajı Göster";
            this.btnMesajGoster.UseVisualStyleBackColor = false;
            this.btnMesajGoster.Click += new System.EventHandler(this.btnMesajGoster_Click);
            this.btnMesajGoster.Enter += new System.EventHandler(this.btnMesajGoster_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(51, 141);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(70, 42);
            this.btn.TabIndex = 1;
            this.btn.Text = "button2";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 229);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnMesajGoster);
            this.Name = "Form1";
            this.Text = "UYARI MESAJI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesajGoster;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button3;
    }
}

