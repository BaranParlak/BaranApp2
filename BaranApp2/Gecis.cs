using Microsoft.VisualBasic.Logging;

namespace BaranApp2
{
    public partial class Gecis : Form
    {
        public Gecis()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int baslang�c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            baslang�c += 1;
            progressBar1.Value = baslang�c;
            YuzdeLbl.Text = baslang�c + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
                log.Show();

            }
        }

        private void Gecis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
