namespace UdemyKursC_
{
    partial class Form3DortIslem
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(455, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 25);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(348, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(348, 65);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(348, 120);
            button3.Name = "button3";
            button3.Size = new Size(83, 25);
            button3.TabIndex = 4;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(348, 176);
            button4.Name = "button4";
            button4.Size = new Size(83, 25);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(258, 227);
            button5.Name = "button5";
            button5.Size = new Size(276, 83);
            button5.TabIndex = 6;
            button5.Text = "Hesapla";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(371, 363);
            label.Name = "label";
            label.Size = new Size(46, 17);
            label.TabIndex = 8;
            label.Text = "Sonuc:";
            // 
            // Form3DortIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3DortIslem";
            Text = "Form3DortIslem";
            Load += Form3DortIslem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label;
    }
}