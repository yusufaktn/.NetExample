namespace UdemyKursC_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 49);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 0;
            label1.Text = "Tel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(20, 17);
            label2.TabIndex = 1;
            label2.Text = "Tc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 133);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 2;
            label3.Text = "Şehir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 184);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 3;
            label4.Text = "Tarih";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(109, 49);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(110, 25);
            maskedTextBox1.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(109, 92);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(110, 25);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "İstanbul", "Ankara", "İzmir", "Kütahya", "Eskişehir" });
            comboBox1.Location = new Point(109, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 25);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 9);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 8;
            label5.Text = "Ad Soyad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 25);
            textBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(608, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(39, 279);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(411, 140);
            listBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(39, 235);
            button1.Name = "button1";
            button1.Size = new Size(345, 38);
            button1.TabIndex = 12;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
    }
}