namespace UdemyKursC_
{
    partial class Form3Alıstırma
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 154);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Showcard Gothic", 16.3018875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 52);
            label1.Name = "label1";
            label1.Size = new Size(262, 31);
            label1.TabIndex = 0;
            label1.Text = "TÜRK HAVA YOLLARI";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(426, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 232);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 51);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 0;
            label2.Text = "Nereden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 84);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 1;
            label3.Text = "Nereye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 116);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 2;
            label4.Text = "Tarih";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara ", "İstanbul", "Bursa" });
            comboBox1.Location = new Point(130, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara ", "İstanbul", "Bursa" });
            comboBox2.Location = new Point(130, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 25);
            comboBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 25);
            dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 56);
            label5.Name = "label5";
            label5.Size = new Size(22, 17);
            label5.TabIndex = 3;
            label5.Text = "TC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 89);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 4;
            label6.Text = "İsim Soyisim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 124);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 5;
            label7.Text = "Telefon";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 25);
            textBox2.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(152, 48);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(110, 25);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(152, 124);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(110, 25);
            maskedTextBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(99, 176);
            button1.Name = "button1";
            button1.Size = new Size(92, 39);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(0, 458);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(801, 123);
            listBox1.TabIndex = 3;
            // 
            // Form3Alıstırma
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 582);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form3Alıstırma";
            Text = "Form3Alıstırma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private ListBox listBox1;
    }
}