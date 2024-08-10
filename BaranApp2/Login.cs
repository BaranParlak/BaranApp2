using System.Data;
using System.Data.SqlClient;

namespace BaranApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\baran\OneDrive\Belgeler\MuzikShpDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void KullaniciTb_TextChanged(object sender, EventArgs e)
        {
            // Bu alanı istediğiniz gibi doldurabilirsiniz.
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Burada metin değişikliğine yanıt verecek kodu yazabilirsiniz.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from AdminTbl where AdminAdSoyad='" + KullaniciTb.Text + "' and AdminSifre='" + SifreTb.Text + "'", baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Bilgi bil = new Bilgi();
                bil.Show();
                this.Hide();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Yada Şifre");
            }
            baglanti.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Satıs sat = new Satıs();
            sat.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ERgit_Click(object sender, EventArgs e)
        {
            Diyagram diyagramForm = new Diyagram();
            diyagramForm.FormClosed += (s, args) => this.Show();
            diyagramForm.Show();
            this.Hide();
        }
    }
}
