namespace KayıtDefteri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(178, 41);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(499, 502);
            button1.Name = "button1";
            button1.Size = new Size(151, 78);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(561, 38);
            label2.Name = "label2";
            label2.Size = new Size(174, 49);
            label2.TabIndex = 3;
            label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(761, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 49);
            label3.TabIndex = 4;
            label3.Text = "00";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(33, 119);
            label4.Name = "label4";
            label4.Size = new Size(148, 41);
            label4.TabIndex = 5;
            label4.Text = "Telefonu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(761, 114);
            label5.Name = "label5";
            label5.Size = new Size(58, 49);
            label5.TabIndex = 8;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(561, 114);
            label6.Name = "label6";
            label6.Size = new Size(150, 49);
            label6.TabIndex = 7;
            label6.Text = "Telefonu:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Akyurt,", "Altındağ", "Ayaş,", "Balâ", "Beypazarı", "Çamlıdere", "Çankaya", "Çubuk", "Elmadağ", "Etimesgut", "Evren", "Gölbaşı", "Güdül", "Haymana", "Kahramankazan", "Kalecik", "Keçiören", "Kızılcahamam", "Mamak", "Nallıhan", "Polatlı", "Pursaklar", "Sincan", "Şereflikoçhisar ", "Yenimahalle" });
            comboBox1.Location = new Point(239, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 28);
            comboBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 214);
            label7.Name = "label7";
            label7.Size = new Size(130, 41);
            label7.TabIndex = 10;
            label7.Text = "İlçe Seç:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(761, 179);
            label8.Name = "label8";
            label8.Size = new Size(58, 49);
            label8.TabIndex = 12;
            label8.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(561, 179);
            label9.Name = "label9";
            label9.Size = new Size(111, 49);
            label9.TabIndex = 11;
            label9.Text = "Semti:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(33, 280);
            label10.Name = "label10";
            label10.Size = new Size(107, 41);
            label10.TabIndex = 13;
            label10.Text = "Adres:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 294);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 142);
            textBox3.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(761, 246);
            label11.Name = "label11";
            label11.Size = new Size(58, 49);
            label11.TabIndex = 16;
            label11.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Banner Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(561, 246);
            label12.Name = "label12";
            label12.Size = new Size(118, 49);
            label12.TabIndex = 15;
            label12.Text = "Adresi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1036, 592);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private Label label12;
    }
}