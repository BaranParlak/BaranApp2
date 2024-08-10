namespace BaranApp2
{
    partial class Diyagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diyagram));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            SilikDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SilikDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.ForeColor = Color.DarkCyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 79);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(1170, 0);
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
            label1.Location = new Point(281, 13);
            label1.Name = "label1";
            label1.Size = new Size(329, 51);
            label1.TabIndex = 0;
            label1.Text = "EnstrümanAGA";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.LightGreen;
            button4.Location = new Point(32, 18);
            button4.Name = "button4";
            button4.Size = new Size(84, 41);
            button4.TabIndex = 28;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 502);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SilikDGV
            // 
            SilikDGV.BackgroundColor = Color.DarkGray;
            SilikDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SilikDGV.Location = new Point(672, 157);
            SilikDGV.Name = "SilikDGV";
            SilikDGV.RowHeadersWidth = 51;
            SilikDGV.Size = new Size(529, 357);
            SilikDGV.TabIndex = 34;
            // 
            // Diyagram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1213, 577);
            Controls.Add(SilikDGV);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diyagram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diyagram";
            Load += Diyagram_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SilikDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button4;
        private PictureBox pictureBox1;
        private DataGridView SilikDGV;
    }
}