namespace UdemyKursC_
{
    partial class ProjectBilgi
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnDogru = new Label();
            BtnYanlis = new Label();
            BtnSoruNo = new Label();
            BtnSonraki = new Button();
            DogruCevap = new Label();
            VerilenCevap = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(461, 190);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(29, 215);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(157, 49);
            BtnA.TabIndex = 1;
            BtnA.Text = "button1";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(253, 215);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(157, 49);
            BtnB.TabIndex = 2;
            BtnB.Text = "button2";
            BtnB.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(29, 289);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(157, 49);
            BtnC.TabIndex = 3;
            BtnC.Text = "button3";
            BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(253, 289);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(157, 49);
            BtnD.TabIndex = 4;
            BtnD.Text = "button4";
            BtnD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 36);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 5;
            label1.Text = "Doğru:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 70);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 6;
            label2.Text = "Yanlış:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(549, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 7;
            label3.Text = "Soru:";
            // 
            // BtnDogru
            // 
            BtnDogru.AutoSize = true;
            BtnDogru.Location = new Point(623, 36);
            BtnDogru.Name = "BtnDogru";
            BtnDogru.Size = new Size(15, 17);
            BtnDogru.TabIndex = 8;
            BtnDogru.Text = "0";
            // 
            // BtnYanlis
            // 
            BtnYanlis.AutoSize = true;
            BtnYanlis.Location = new Point(623, 70);
            BtnYanlis.Name = "BtnYanlis";
            BtnYanlis.Size = new Size(15, 17);
            BtnYanlis.TabIndex = 9;
            BtnYanlis.Text = "0";
            // 
            // BtnSoruNo
            // 
            BtnSoruNo.AutoSize = true;
            BtnSoruNo.Location = new Point(623, 106);
            BtnSoruNo.Name = "BtnSoruNo";
            BtnSoruNo.Size = new Size(15, 17);
            BtnSoruNo.TabIndex = 10;
            BtnSoruNo.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(549, 154);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(143, 39);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // DogruCevap
            // 
            DogruCevap.AutoSize = true;
            DogruCevap.Location = new Point(433, 360);
            DogruCevap.Name = "DogruCevap";
            DogruCevap.Size = new Size(43, 17);
            DogruCevap.TabIndex = 12;
            DogruCevap.Text = "label4";
            DogruCevap.Visible = false;
            // 
            // VerilenCevap
            // 
            VerilenCevap.AutoSize = true;
            VerilenCevap.Location = new Point(433, 391);
            VerilenCevap.Name = "VerilenCevap";
            VerilenCevap.Size = new Size(43, 17);
            VerilenCevap.TabIndex = 13;
            VerilenCevap.Text = "label5";
            VerilenCevap.Visible = false;
            // 
            // ProjectBilgi
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 359);
            Controls.Add(VerilenCevap);
            Controls.Add(DogruCevap);
            Controls.Add(BtnSonraki);
            Controls.Add(BtnSoruNo);
            Controls.Add(BtnYanlis);
            Controls.Add(BtnDogru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Name = "ProjectBilgi";
            Text = "ProjectBilgi";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label BtnDogru;
        private Label BtnYanlis;
        private Label BtnSoruNo;
        private Button BtnSonraki;
        private Label DogruCevap;
        private Label VerilenCevap;
        private BindingSource bindingSource1;
    }
}