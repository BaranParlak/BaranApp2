namespace BaranApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            KullaniciTb = new TextBox();
            SifreTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            ERgit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkCyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 94);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(590, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 38);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(148, 19);
            label1.Name = "label1";
            label1.Size = new Size(329, 51);
            label1.TabIndex = 0;
            label1.Text = "EnstrümanAGA";
            // 
            // label3
            // 
            label3.BackColor = Color.LightGreen;
            label3.Location = new Point(386, 181);
            label3.Name = "label3";
            label3.Size = new Size(200, 3);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // KullaniciTb
            // 
            KullaniciTb.BorderStyle = BorderStyle.None;
            KullaniciTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KullaniciTb.Location = new Point(386, 160);
            KullaniciTb.Name = "KullaniciTb";
            KullaniciTb.Size = new Size(200, 23);
            KullaniciTb.TabIndex = 3;
            KullaniciTb.TextChanged += textBox1_TextChanged;
            // 
            // SifreTb
            // 
            SifreTb.BorderStyle = BorderStyle.None;
            SifreTb.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SifreTb.Location = new Point(386, 233);
            SifreTb.Name = "SifreTb";
            SifreTb.PasswordChar = '*';
            SifreTb.Size = new Size(200, 23);
            SifreTb.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.LightGreen;
            label4.Location = new Point(386, 256);
            label4.Name = "label4";
            label4.Size = new Size(200, 3);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.LightGreen;
            label5.Location = new Point(220, 146);
            label5.Name = "label5";
            label5.Size = new Size(160, 38);
            label5.TabIndex = 6;
            label5.Text = "Kullanıcı:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.LightGreen;
            label6.Location = new Point(284, 221);
            label6.Name = "label6";
            label6.Size = new Size(96, 38);
            label6.TabIndex = 7;
            label6.Text = "Şifre:";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.LightGreen;
            button1.Location = new Point(284, 283);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.LightGreen;
            button2.Location = new Point(468, 283);
            button2.Name = "button2";
            button2.Size = new Size(143, 41);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(12, 368);
            label7.Name = "label7";
            label7.Size = new Size(172, 25);
            label7.TabIndex = 11;
            label7.Text = "Faturalandırma";
            label7.Click += label7_Click;
            // 
            // ERgit
            // 
            ERgit.BackColor = Color.Gray;
            ERgit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ERgit.ForeColor = Color.LightGreen;
            ERgit.Location = new Point(545, 373);
            ERgit.Name = "ERgit";
            ERgit.Size = new Size(66, 41);
            ERgit.TabIndex = 12;
            ERgit.Text = "E.R";
            ERgit.UseVisualStyleBackColor = false;
            ERgit.Click += ERgit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(630, 426);
            Controls.Add(ERgit);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SifreTb);
            Controls.Add(label4);
            Controls.Add(KullaniciTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox KullaniciTb;
        private TextBox SifreTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Button ERgit;
    }
}