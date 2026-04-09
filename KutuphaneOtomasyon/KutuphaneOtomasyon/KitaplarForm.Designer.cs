namespace KutuphaneOtomasyon
{
    partial class KitaplarForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(544, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.Size = new Size(514, 414);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 1;
            label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 2;
            label2.Text = "Yazar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 131);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 3;
            label3.Text = "Yayın Yılı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 25);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(48, 178);
            button1.Name = "button1";
            button1.Size = new Size(103, 46);
            button1.TabIndex = 7;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(183, 178);
            button2.Name = "button2";
            button2.Size = new Size(103, 46);
            button2.TabIndex = 8;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(48, 254);
            button3.Name = "button3";
            button3.Size = new Size(103, 46);
            button3.TabIndex = 9;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(183, 254);
            button4.Name = "button4";
            button4.Size = new Size(103, 46);
            button4.TabIndex = 10;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(48, 330);
            button5.Name = "button5";
            button5.Size = new Size(238, 46);
            button5.TabIndex = 11;
            button5.Text = "Ödünç Ver";
            button5.UseVisualStyleBackColor = true;
            // 
            // KitaplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 411);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "KitaplarForm";
            Text = "Kitaplar";
            Load += KitaplarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}