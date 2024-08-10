namespace BaranApp2
{
    partial class Gecis
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gecis));
            panel1 = new Panel();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            YuzdeLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkCyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(164, 21);
            label1.Name = "label1";
            label1.Size = new Size(329, 51);
            label1.TabIndex = 0;
            label1.Text = "EnstrümanAGA";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = Color.Black;
            progressBar1.Location = new Point(0, 401);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(657, 29);
            progressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(657, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // YuzdeLbl
            // 
            YuzdeLbl.AutoSize = true;
            YuzdeLbl.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            YuzdeLbl.ForeColor = Color.LightGreen;
            YuzdeLbl.Location = new Point(215, 234);
            YuzdeLbl.Name = "YuzdeLbl";
            YuzdeLbl.Size = new Size(51, 38);
            YuzdeLbl.TabIndex = 3;
            YuzdeLbl.Text = "%";
            // 
            // Gecis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(657, 429);
            Controls.Add(YuzdeLbl);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gecis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Gecis_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label YuzdeLbl;
    }
}
